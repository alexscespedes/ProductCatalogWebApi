using System;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Data;

public class AppDbContext : DbContext
{   
   public AppDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        // Seed Categories
        var categories = new List<Category>
        {
            new () { Id = 1, Name = "Electronics"},
            new () { Id = 2, Name = "Home Appliances"},
            new () { Id = 3, Name = "Sports & Fitness"},
            new () { Id = 4, Name = "Office Suppliers"},
            new () { Id = 5, Name = "Gaming"},
            new () { Id = 6, Name = "Clothing"},
        };

        modelBuilder.Entity<Category>().HasData(categories);

        // Seed Products using Bogus

        var faker = new Bogus.Faker("en");

        var productFaker = new Bogus.Faker<Product>("en")
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.SKU, f => f.Random.AlphaNumeric(8).ToUpper())
            .RuleFor(p => p.Price, f => f.Random.Decimal(5, 1500))
            .RuleFor(p => p.Rating, f => f.Random.Double(1, 5))
            .RuleFor(p => p.IsActive, f => f.Random.Bool(0.85f))
            .RuleFor(p => p.CreatedAt, f => f.Date.Past(2))
            .RuleFor(p => p.CategoryId, f => f.Random.Int(1,6));

        var products = productFaker.Generate(150);

        modelBuilder.Entity<Product>().HasData(products);
    }
}
