using System;
using CsvHelper.Configuration;
using ProductCatalogApi.DTOs;

namespace ProductCatalogApi.Configuration;

public sealed class ProductExportMap : ClassMap<ProductExportDto>
{
    public ProductExportMap()
    {
        Map(m => m.SKU).Name("SKU");
        Map(m => m.Name).Name("Name");
        Map(m => m.Price).Name("Price");
        Map(m => m.Rating).Name("Rating");
        Map(m => m.Category).Name("Category");
        Map(m => m.IsActive).Name("IsActive");
        Map(m => m.CreatedAt).Name("CreatedAt");
    }
}
