using Microsoft.EntityFrameworkCore;
using CursedShop.Models;

namespace CursedShop.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}