using CursedShop.Models;

namespace CursedShop.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();
    Task AddAsync(Product product);
}