using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Text;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Configuration;
using ProductCatalogApi.Data;
using ProductCatalogApi.DTOs;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Service;

public class BulkImportService : IBulkImportService
{
    private readonly ConcurrentDictionary<Guid, string> _jobStatus = new();
    private readonly ConcurrentQueue<BackgroundImportJob> _jobQueue = new();

    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<BulkImportService> _logger;

    public BulkImportService(IServiceScopeFactory scopeFactory, ILogger<BulkImportService> logger)
    {
        _scopeFactory = scopeFactory;
        _logger = logger;

        Task.Run(ProcessQueueAsync);
    }

    private async Task ProcessQueueAsync()
    {
        while (true)
        {
            try
            {
                if (_jobQueue.TryDequeue(out var job))
                {
                    await ExecuteBackgroundJobAsync(job);
                }
                else
                {
                    await Task.Delay(300);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Background worker error");
            }
        }
    }

    // Preview
    public async Task<ImportPreviewResult> PreviewCsvAsync(Stream csvStream, CancellationToken ct = default)
    {
        var results = new ImportPreviewResult();

        using var reader = new StreamReader(csvStream);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<ProductImportMap>();

        var rowNum = 0;
        await foreach (var row in csv.GetRecordsAsync<ProductImportDto>().WithCancellation(ct))
        {
            rowNum++;
            var rowResult = new ImportRowResult { RowNumber = rowNum, Row = row };
            ValidateRow(row, rowResult.Errors);
            rowResult.IsValid = rowResult.Errors.Count == 0;
            results.Rows.Add(rowResult);
        }

        results.TotalRows = results.Rows.Count;
        return results;
    }

    // Import
    public async Task<int> ImportCsvAsync(Stream csvStream, CancellationToken ct = default)
    {
        using var reader = new StreamReader(csvStream, Encoding.UTF8);

        string? header = await reader.ReadLineAsync();
        if (header == null) return 0;

        using var scope = _scopeFactory.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        var newProducts = new List<Product>();

        while (!reader.EndOfStream)
        {
            ct.ThrowIfCancellationRequested();

            var line = await reader.ReadLineAsync();
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split(',');
            if (parts.Length < 7) continue;

            var product = new Product
            {
                SKU = parts[0].Trim(),
                Name = parts[1].Trim(),
                Price = decimal.Parse(parts[2], CultureInfo.InvariantCulture),
                Rating = double.Parse(parts[3], CultureInfo.InvariantCulture),
                CategoryId = int.Parse(parts[4].Trim()),
                IsActive = bool.Parse(parts[5]),
                CreatedAt = DateTime.Parse(parts[6], CultureInfo.InvariantCulture)
            };

            newProducts.Add(product);
        }

        if (newProducts.Count > 0)
        {
            db.Products.AddRange(newProducts);
            await db.SaveChangesAsync(ct);
        }

        return newProducts.Count;
    }

    // Persist a batch
    private async Task<(int Inserted, int Updated, int Skipped)> PersistBatchAsync(List<ProductImportDto> batch, CancellationToken ct = default)
    {
        using var scope = _scopeFactory.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        using var tx = await db.Database.BeginTransactionAsync(ct);

        var skus = batch.Select(b => b.SKU).ToList();
        var existing = await db.Products.Where(p => skus.Contains(p.SKU)).ToDictionaryAsync(p => p.SKU, ct);

        var toInsert = new List<Product>();
        var updatedCount = 0;
        var insertedCount = 0;
        var skippedCount = 0;

        foreach (var dto in batch)
        {
            if (existing.TryGetValue(dto.SKU, out var existingProduct))
            {
                existingProduct.Name = dto.Name;
                existingProduct.Price = dto.Price;
                existingProduct.Rating = dto.Rating;
                existingProduct.CategoryId = dto.CategoryId;
                existingProduct.IsActive = dto.IsActive;
                existingProduct.CreatedAt = dto.CreatedAt;
                updatedCount++;
            }
            else
            {
                var newProduct = new Product
                {
                    SKU = dto.SKU,
                    Name = dto.Name,
                    Price = dto.Price,
                    Rating = dto.Rating,
                    CategoryId = dto.CategoryId,
                    IsActive = dto.IsActive,
                    CreatedAt = dto.CreatedAt
                };
                toInsert.Add(newProduct);
            }
        }

        if (toInsert.Any())
        {
            db.Products.AddRange(toInsert);
            insertedCount = toInsert.Count;
        }

        await db.SaveChangesAsync(ct);
        await tx.CommitAsync(ct);

        return (insertedCount, updatedCount, skippedCount);
    }

    // Basic validation
    private void ValidateRow(ProductImportDto dto, List<string> errors)
    {
        if (string.IsNullOrWhiteSpace(dto.SKU)) errors.Add("SKU is required.");
        if (string.IsNullOrWhiteSpace(dto.Name)) errors.Add("Name is required.");
        if (dto.Price < 0) errors.Add("Price must be >= 0.");
        if (dto.Rating < 0 || dto.Rating > 5) errors.Add("Rating must be between 0 and 5.");
    }

    // Background job
    
    public async Task<Guid> QueueImportJobAsync(Stream csvStream, CancellationToken ct = default)
    {
        var jobId = Guid.NewGuid();

        var ms = new MemoryStream();
        await csvStream.CopyToAsync(ms, ct);
        ms.Position = 0;

        var job = new BackgroundImportJob
        {
            JobId = jobId,
            CsvData = ms
        };

        _jobStatus[jobId] = "Queued";

        _jobQueue.Enqueue(job);

        return jobId;
    }


    // public async Task<Guid> EnqueueImportJobAsync(Stream csvStream)
    // {
    //     var ms = new MemoryStream();
    //     await csvStream.CopyToAsync(ms);
    //     ms.Position = 0;

    //     var jobId = Guid.NewGuid();
    //     _jobStatus[jobId] = "Queued";

    //     BackgroundImportQueue.Instance.Enqueue(new BackgroundImportJob { JobId = jobId, CsvData = ms});
    //     return jobId;
    // }

    public string GetJobStatus (Guid jobId)
    {
        return _jobStatus.TryGetValue(jobId, out var status)
            ? status
            : "NotFound";
    }

    internal async Task ExecuteBackgroundJobAsync(BackgroundImportJob job, CancellationToken ct = default)
    {
        try
        {
            _jobStatus[job.JobId] = "Running";
            // Use ImportCsvAsync but stream is job.CsvData
            job.CsvData.Position = 0;
            await ImportCsvAsync(job.CsvData, ct);
            _jobStatus[job.JobId] = "Completed";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Job failed {JobId}", job.JobId);
            _jobStatus[job.JobId] = $"Failed: {ex.Message}";
        }
    }
}
