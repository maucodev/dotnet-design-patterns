namespace Iterator.ProductsExample;

/// <summary>
/// Represents a product.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets the ID of the product.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the product.
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Initializes a new instance of the Product class.
    /// </summary>
    /// <param name="id">The ID of the product.</param>
    /// <param name="name">The name of the product.</param>
    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"{Id} - {Name}";
    }
}