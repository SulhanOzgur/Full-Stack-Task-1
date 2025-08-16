using ProductApi.Models;
using ProductApi.Repositories;

namespace ProductApi.Services;
public class ProductService(IProductRepository repo) : IProductService
{
    public Task<List<Product>> GetAllAsync() => repo.GetAllAsync();
    public Task<Product?> GetAsync(int id) => repo.GetByIdAsync(id);

    public async Task<Product> CreateAsync(string name, decimal price, string? category)
    {
        var p = new Product { Name = name, Price = price, Category = category };
        await repo.AddAsync(p);
        return p;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var p = await repo.GetByIdAsync(id);
        if (p is null) return false;
        await repo.DeleteAsync(p);
        return true;
    }
}
