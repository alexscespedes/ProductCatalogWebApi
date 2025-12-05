using System;

namespace ProductCatalogApi.Service;

public interface IBulkImportService
{
    Task<Guid> QueueImportJobAsync(Stream csvStream, CancellationToken ct);
    string GetJobStatus(Guid jobId);

}
