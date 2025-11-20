using System;

namespace ProductCatalogApi.DTOs;

public class ProductQueryParameters
{
    // Search
    public string? Search { get; set; }
    public bool WeightedSearch { get; set; } = true;

    // Advanced: fields to include
    public bool includeName { get; set; } = true;
    public bool includeDescription { get; set; } = true;
    public bool includeSKU { get; set; } = true;

    // Filtering
    public string? Name { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public double? MinRating { get; set; }
    public double? MaxRating { get; set; }
    public int? CategoryId { get; set; }
    public bool? IsActive { get; set; }

    // Sorting
    public string? SortBy { get; set; }
    public string? SortOrder { get; set; }

    // Paging
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;

    // Cursor pagination
    public DateTime? After { get; set; }
    public int? Limit { get; set; }
}
