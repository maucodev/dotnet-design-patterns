namespace Proxy.ObjectRelationalMapperExample;

/// <summary>
/// Represents a proxy for a product that tracks changes to the product and interacts with a <see cref="DbContext"/>.
/// </summary>
public class ProductProxy : Product
{
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProxy"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the product.</param>
    /// <param name="context">The <see cref="DbContext"/> instance used to track changes.</param>
    public ProductProxy(int id, DbContext context) : base(id)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public override void SetName(string name)
    {
        base.SetName(name);

        _context.MarkAsChanged(this);
    }
}