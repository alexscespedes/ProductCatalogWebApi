using System;
using ProductCatalogApi.DTOs;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Service;

public static class ProductSearchExtensions
{
    public static IQueryable<Product> ApplyBasicSearch(
        this IQueryable<Product> query,
        string? search,
        ProductQueryParameters p)
    {
        if (string.IsNullOrWhiteSpace(search))
            return query;

        search = search.ToLower();

        return query.Where(product =>
            (p.includeName && product.Name.ToLower().Contains(search)) ||
            (p.includeDescription && product.Description.ToLower().Contains(search)) ||
            (p.includeSKU && product.SKU.ToLower().Contains(search))
        );
    }

    public static IQueryable<Product> ApplyWeightedSearch(
        this IQueryable<Product> query,
        string search)
    {
        search = search.ToLower();

        return query
            .Select(product => new
            {
                Product = product,
                Score = 
                    (product.Name.ToLower().Contains(search) ? 5 : 0) +
                    (product.Description.ToLower().Contains(search) ? 2 : 0) +
                    (product.SKU.ToLower().Contains(search) ? 3 : 0)
            })
            .Where(x => x.Score > 0)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Product);
    }
}
