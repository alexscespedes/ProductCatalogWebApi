using System;

namespace ProductCatalogApi.DTOs;

public class ImportPreviewResult
{
    public int TotalRows { get; set; }
    public List<ImportRowResult> Rows { get; set; } = new();
    public int ValidCount => Rows.Count(r => r.IsValid);
    public int InvalidCount => Rows.Count(r => !r.IsValid);
}
