using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Application.Interface;

public interface ICategoryRepository
{
    Task <Category> AddAsync(Category category);
    Task updateAsync(Category category);
    Task<IEnumerable<Category>> GetAllAsync();
    Task <Category?> GetByIdAsync(Guid id);
    Task  DeleteByIdAsync(Guid id);
}

