using Microsoft.EntityFrameworkCore;
using SoftwareShopping.ProductsAPI.Entities;

namespace SoftwareShopping.ProductsAPI.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product() { Category = "GiftCard", Description = "1500vp", ProductId = 1, Name = "Valorant 1", Price = 13.0m, ImageUrl = "" },
            new Product() { Category = "GiftCard", Description = "3500vp", ProductId = 2, Name = "Valorant 2", Price = 22.0m, ImageUrl = "" },
            new Product() { Category = "Antivírus", Description = "1 year license", ProductId = 3, Name = "Kaspersky 1", Price = 15.0m, ImageUrl = "" },
            new Product() { Category = "Antivírus", Description = "2 years license", ProductId = 4, Name = "Kaspersky 2", Price = 22.0m , ImageUrl = "" }
        );
    }
}