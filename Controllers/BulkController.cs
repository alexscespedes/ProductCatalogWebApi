using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Configuration;
using ProductCatalogApi.DTOs;
using ProductCatalogApi.Models;
using ProductCatalogApi.Service;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BulkController : ControllerBase
    {
        private readonly BulkImportService _importService;
        public BulkController(BulkImportService importService) => _importService = importService;

        [HttpPost("preview")]
        public async Task<IActionResult> PreviewCsv(IFormFile file, CancellationToken ct)
        {
            if (file == null) return BadRequest("File is required.");
            var preview = await _importService.PreviewCsvAsync(file.OpenReadStream(), ct);
            return Ok(preview);
        }

        [HttpPost("import")]
        public async Task<IActionResult> ImportCsv(IFormFile file, bool runInBackground = false, CancellationToken ct = default)
        {
            if (file == null) return BadRequest("File is required");
            if (runInBackground)
            {
                var jobId = await _importService.QueueImportJobAsync(file.OpenReadStream());
                return Accepted(new { jobId });
            }
            else
            {
                var result = await _importService.ImportCsvAsync(file.OpenReadStream());
                return Ok(result);
            }
        }

        [HttpGet("import/status/{jobId}")]
        public IActionResult GetJobStatus(Guid jobId)
        {
            var status = _importService.GetJobStatus(jobId);

            if (status == null)
                return NotFound(new { message = "Job ID not found", jobId });

            return Ok(new { jobId, status });
        }

    }
}
