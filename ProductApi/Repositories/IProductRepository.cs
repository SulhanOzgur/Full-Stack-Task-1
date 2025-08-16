using ProductApi.Models;

namespace ProductApi.Repositories;
public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task AddAsync(Product p);
    Task DeleteAsync(Product p);
}
