using System;

namespace ProductCatalogApi.Configuration;

public class BackgroundImportJob
{
    public Guid JobId { get; set; }
    public MemoryStream CsvData { get; set; } = new MemoryStream();
}
