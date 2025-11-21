using System;

namespace ProductCatalogApi.DTOs;

public class ImportRowResult
{
    public int RowNumber { get; set; }
    public ProductImportDto? Row { get; set; }
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
}
