using ProductApi.Models;

namespace ProductApi.Services;
public interface IProductService
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetAsync(int id);
    Task<Product> CreateAsync(string name, decimal price, string? category);
    Task<bool> DeleteAsync(int id);
}
