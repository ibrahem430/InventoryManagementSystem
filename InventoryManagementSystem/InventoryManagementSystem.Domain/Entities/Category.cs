namespace InventoryManagementSystem.Domain.Entities;

public class Category
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    private Category()
    {
    }

    public Category(string name)
    {
        ValidateName(name);

        Id = Guid.NewGuid();
        Name = name.Trim();
    }

        public void Rename(string name)
    {
        ValidateName(name);
        Name = name.Trim();
    }

    private static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Category name is required.",
                nameof(name));
        }
    }
}