using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Repositories;
public class ProductRepository(AppDbContext db) : IProductRepository
{
    public Task<List<Product>> GetAllAsync() =>
        db.Products.AsNoTracking().OrderByDescending(p => p.Id).ToListAsync();

    public Task<Product?> GetByIdAsync(int id) => db.Products.FindAsync(id).AsTask();

    public async Task AddAsync(Product p)
    {
        db.Products.Add(p);
        await db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Product p)
    {
        db.Products.Remove(p);
        await db.SaveChangesAsync();
    }
}
