namespace InventoryManagementSystem.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public decimal Price { get; private set; }

    public int Quantity { get; private set; }

    public Guid CategoryId { get; private set; }

    public Guid SupplierId { get; private set; }

   
    private Product()
    {
    }

    public Product(
        string name,
        decimal price,
        int quantity,
        Guid categoryId,
        Guid supplierId)
    {
        ValidateName(name);
        ValidatePrice(price);
        ValidateQuantity(quantity);
        ValidateCategoryId(categoryId);
        ValidateSupplierId(supplierId);

        Id = Guid.NewGuid();
        Name = name.Trim();
        Price = price;
        Quantity = quantity;
        CategoryId = categoryId;
        SupplierId = supplierId;
    }

    private static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Product name is required.",
                nameof(name));
        }
    }

    private static void ValidateQuantity(int quantity)
    {
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(quantity),
                "Quantity cannot be negative.");
        }
    }

    private static void ValidatePrice(decimal price)
    {
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(price),
                "Price must be greater than zero.");
        }
    }

    private static void ValidateCategoryId(Guid categoryId)
    {
        if (categoryId == Guid.Empty)
        {
            throw new ArgumentException(
                "Category ID is required.",
                nameof(categoryId));
        }
    }

    private static void ValidateSupplierId(Guid supplierId)
    {
        if (supplierId == Guid.Empty)
        {
            throw new ArgumentException(
                "Supplier ID is required.",
                nameof(supplierId));
        }
    }

    private static void ValidateStockAdjustment(int quantity)
{
    if (quantity <= 0)
        throw new ArgumentOutOfRangeException(
            nameof(quantity),
            "Quantity must be greater than zero.");
}


    public void UpdatePrice(decimal price)
    {
        ValidatePrice(price);
        Price=price;
    }

public void IncreaseStock(int quantity)
    {
        ValidateStockAdjustment(quantity);
        Quantity+=quantity;
    }

public void DecreaseStock(int quantity)
    {
        ValidateStockAdjustment(quantity);
        if(Quantity>=quantity)
        Quantity-=quantity;
        else
        {
           throw new InvalidOperationException(
          "Insufficient stock.");
        }
        
    }

public void ChangeCategory(Guid categoryId)
    {
        ValidateCategoryId(categoryId);
        CategoryId=categoryId;
    }



}