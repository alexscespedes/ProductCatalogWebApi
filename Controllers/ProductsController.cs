using System.Globalization;
using ClosedXML.Excel;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Configuration;
using ProductCatalogApi.DTOs;
using ProductCatalogApi.Service;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            ProductService service,
            IServiceScopeFactory scopeFactory,
            ILogger<ProductsController> logger
            )
        {
            _service = service;
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] ProductQueryParameters parameters)
        {
            var result = await _service.GetProductsAsync(parameters);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] ProductQueryParameters parameters)
        {
            var result = await _service.GetProductsAsync(parameters);
            return Ok(result);
        }

        [HttpGet("export/csv")]
        public async Task ExportCsv([FromQuery] ProductQueryParameters parameters, CancellationToken cancellationToken)
        {
            Response.ContentType = "text/csv";
            var filename = $"products_{DateTime.UtcNow:yyyyMMdd_HHmmss}.csv";
            Response.Headers.Append("Content-Disposition", $"attachment; filename={filename}");

            await using var writer = new StreamWriter(Response.Body, System.Text.Encoding.UTF8, 65536, leaveOpen: true);
            await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<ProductExportMap>();

            csv.WriteHeader<ProductExportDto>();
            await csv.NextRecordAsync();

            int flushCounter = 0;

            await foreach (var product in _service.QueryAsAsyncEnumerable(parameters).WithCancellation(cancellationToken))
            {
                var dto = new ProductExportDto
                {
                    SKU = product.SKU ?? string.Empty,
                    Name = product.Name,
                    Price = product.Price,
                    Rating = product.Rating,
                    Category = product.Category?.Name ?? string.Empty,
                    IsActive = product.IsActive,
                    CreatedAt = product.CreatedAt
                };

                csv.WriteRecord(dto);
                await csv.NextRecordAsync();

                flushCounter++;

                if (flushCounter % 100 == 0)
                    await writer.FlushAsync();
            }

            await writer.FlushAsync();
        }

        [HttpGet("export/excel")]
        public async Task<IActionResult> ExportExcel([FromQuery] ProductQueryParameters parameters, CancellationToken cancellationToken)
        {
            using var workbook = new XLWorkbook();

            var ws = workbook.Worksheets.Add("Products");
            // Header row
            ws.Cell(1,1).Value = "SKU";
            ws.Cell(1,2).Value = "Name";
            ws.Cell(1,3).Value = "Price";
            ws.Cell(1,4).Value = "Rating";
            ws.Cell(1,5).Value = "Category";
            ws.Cell(1,6).Value = "IsActive";
            ws.Cell(1,7).Value = "CreatedAt";

            var rowIndex = 2;
            await foreach (var product in _service.QueryAsAsyncEnumerable(parameters).WithCancellation(cancellationToken))
            {
                ws.Cell(rowIndex,1).Value = product.SKU ?? string.Empty;
                ws.Cell(rowIndex,2).Value = product.Name;
                ws.Cell(rowIndex,3).Value = product.Price; 
                ws.Cell(rowIndex,4).Value = product.Rating; 
                ws.Cell(rowIndex,5).Value = product.Category?.Name ?? string.Empty;
                ws.Cell(rowIndex,6).Value = product.IsActive;
                ws.Cell(rowIndex,7).Value = product.CreatedAt;

                rowIndex++;

                if (rowIndex % 1000 == 0)
                    cancellationToken.ThrowIfCancellationRequested();
            }

            using var ms = new MemoryStream();
            workbook.SaveAs(ms);
            ms.Position = 0;

            var filename = $"products_{DateTime.UtcNow:yyyyyMMdd_HHmmss}.xlsx";
            return File(ms.ToArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheethtml.sheet",
                filename);
        }
    }
}
