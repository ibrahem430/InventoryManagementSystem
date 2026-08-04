namespace InventoryManagementSystem.Application.Responses.Supplier;
using InventoryManagementSystem.Domain.Entities;


public class SupplierResponse
{
       public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public static SupplierResponse FromModel(Supplier supplier)
    {
        if (supplier==null)
        throw new ArgumentNullException(nameof(supplier));

        return new SupplierResponse
        {
            Id=supplier.Id,
            Name=supplier.Name
        };
    }

     public static IEnumerable< SupplierResponse> FromModels(IEnumerable<Supplier> suppliers)
    {
        if (suppliers==null)
        throw new ArgumentNullException(nameof(suppliers));

        return suppliers.Select(FromModel);
    }
}