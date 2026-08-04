using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Application.Interface;

public interface ISupplierRepository
{
    Task <Supplier> AddAsync(Supplier supplier);
    Task updateAsync(Supplier supplier);
    Task<IEnumerable<Supplier>> GetSupplierAsync();
    Task <Supplier?> GetByIdAsync(Guid id);
    Task  DeleteByIdAsync(Guid id);


}