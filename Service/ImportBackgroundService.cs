using System;
using ProductCatalogApi.Configuration;

namespace ProductCatalogApi.Service;

public class ImportBackgroundService : BackgroundService
{
    private readonly IServiceProvider _sp;
    private readonly ILogger<ImportBackgroundService> _logger;

    public ImportBackgroundService(IServiceProvider sp, ILogger<ImportBackgroundService> logger)
    {
        _sp = sp;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("ImportBackgroundService started.");
        while (!stoppingToken.IsCancellationRequested)
        {
            if (BackgroundImportQueue.Instance.TryDequeue(out var job))
            {
                using var scope = _sp.CreateScope();
                var importService = scope.ServiceProvider.GetRequiredService<BulkImportService>();
                await importService.ExecuteBackgroundJobAsync(job!, stoppingToken);
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(2), stoppingToken);
            }
        }
    }
}
