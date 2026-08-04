using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Application.Interface;

public interface IProductRepository

{
    Task <Product> AddAsync(Product product);
    Task updateAsync(Product product);
    Task<IEnumerable<Product>> GetAllAsync();
    Task <Product?> GetByIdAsync(Guid id);
    Task  DeleteByIdAsync(Guid id);

}