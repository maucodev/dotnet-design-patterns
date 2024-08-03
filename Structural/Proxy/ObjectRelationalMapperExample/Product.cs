namespace Proxy.ObjectRelationalMapperExample;

/// <summary>
/// Represents a product.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets the unique identifier for the product.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the product.</param>
    public Product(int id)
    {
        Id = id;
    }

    /// <summary>
    /// Sets the name of the product. This is a virtual method that can be overridden in derived classes.
    /// </summary>
    /// <param name="name">The name to set for the product.</param>
    public virtual void SetName(string name)
    {
    }
}