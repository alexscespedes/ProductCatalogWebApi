using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using ProductCatalogApi.DTOs;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Service;

public class ProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    private IQueryable<Product> ApplyFiltering(IQueryable<Product> query, ProductQueryParameters p)
    {
        if (!string.IsNullOrWhiteSpace(p.Name))
            query = query.Where(x => x.Name.Contains(p.Name));

        if (p.MinPrice.HasValue)
            query = query.Where(x => x.Price >= p.MinPrice);

        if (p.MaxPrice.HasValue)
            query = query.Where(x => x.Price <= p.MaxPrice);


        if (p.MinRating.HasValue)
            query = query.Where(x => x.Rating >= p.MinRating);


        if (p.MaxRating.HasValue)
            query = query.Where(x => x.Rating <= p.MinRating);


        if (p.CategoryId.HasValue)
            query = query.Where(x => x.CategoryId == p.CategoryId);


        if (p.IsActive.HasValue)
            query = query.Where(x => x.IsActive == p.IsActive);

        return query;
    }

    private IQueryable<Product> ApplySorting(IQueryable<Product> query, string? sortBy, string? sortOrder)
    {
        bool desc = sortOrder?.ToLower() == "desc";

        return sortBy?.ToLower() switch
        {
            "price"     => desc ? query.OrderByDescending(x => x.Price) : query.OrderBy(x => x.Price),
            "rating"     => desc ? query.OrderByDescending(x => x.Rating) : query.OrderBy(x => x.Rating),
            "createdat"     => desc ? query.OrderByDescending(x => x.CreatedAt) : query.OrderBy(x => x.CreatedAt),
            "name"     => desc ? query.OrderByDescending(x => x.Name) : query.OrderBy(x => x.Name),
            _ => query.OrderBy(x => x.Name)
        };
    }

    private async Task<PagedResult<Product>> ApplyPaging(
        IQueryable<Product> query,
        int pageNumber,
        int pageSize)
    {
        var totalCount = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Product>(items, totalCount, totalPages, pageNumber, pageSize);
    }

    private async Task<List<Product>> ApplyCursorPagination(
        IQueryable<Product> query, DateTime? after, int? limit)
    {
        if (after.HasValue)
            query = query.Where(x => x.CreatedAt > after.Value);

        return await query
            .OrderBy(x => x.CreatedAt)
            .Take(limit ?? 10)
            .ToListAsync();
    }

    public async Task<object> GetProductsAsync(ProductQueryParameters p)
    {
        var query = _context.Products.Include(x => x.Category).AsQueryable();

        query = ApplyFiltering(query, p);
        query = ApplySorting(query, p.SortBy, p.SortOrder);

        // Cursor pagination mode
        if (p.After.HasValue)
        {
            return await ApplyCursorPagination(query, p.After, p.Limit);
        }

        // Page-based pagination mode
        return await ApplyPaging(query, p.PageNumber, p.PageSize);
    }
}