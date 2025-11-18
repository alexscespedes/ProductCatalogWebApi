using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using ProductCatalogApi.Models;
using ProductCatalogApi.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddScoped<ProductService>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.WriteIndented = true;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // Seed Categories
    if (!db.Categories.Any())
    {
        var categories = new List<Category>
        {
            new () {Name = "Electronics"},
            new () {Name = "Home Appliances"},
            new () {Name = "Sports & Fitness"},
            new () {Name = "Office Suppliers"},
            new () {Name = "Gaming"},
            new () {Name = "Clothing"},
        };

        db.Categories.AddRange(categories);
        db.SaveChanges();
    }

    // Seed Products
    if (!db.Products.Any())
    {
        var rand = new Random();
        var categories = db.Categories.ToList();

        var productNames = new[]
        {
            "Smartphone", "Laptop","Headset", "Keyboard", "Monitor",
            "Running Shoes", "Electric Kettle","Backpack", "Desk Lamp",
            "Gaming Chair", "Bluetooh Speaker","Air Purifier", "T-Shirt",
            "Fitness Tracker", "LED Strip","Coffee Maker", "Mechanical Keyboard",
            "USB-C Hub", "Wireless Mouse","Smart Watch"
        };

        var products = new List<Product>();

        for (int i = 1; i <= 150; i++)
        {
            var name = productNames[rand.Next(productNames.Length)];
            var category = categories[rand.Next(categories.Count)];

            products.Add(new Product
            {
                Name = $"{name} #{i}",
                Price = rand.Next(10, 3000),
                Rating = Math.Round(rand.NextDouble() * 5, 1),
                CategoryId = category.Id,
                IsActive = rand.Next(0,2) == 1,
                CreatedAt = DateTime.UtcNow.AddDays(-rand.Next(0, 365))
            });
        }

        db.Products.AddRange(products);
        db.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
