using Microsoft.EntityFrameworkCore;
using CursedShop.Models;
using CursedShop.Interfaces;
using CursedShop.Data;

namespace CursedShop.Services;

public class ProductService(AppDbContext db) : IProductService
{
    public Task<List<Product>> GetAllAsync() => db.Products.ToListAsync();

    public async Task AddAsync(Product product)
    {
        db.Products.Add(product);
        await db.SaveChangesAsync();
    }
}