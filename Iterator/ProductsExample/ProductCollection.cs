using System.Collections.Generic;
using Iterator.Iterators;

namespace Iterator.ProductsExample;

/// <summary>
/// Represents a collection of products.
/// </summary>
public class ProductCollection
{
    private readonly List<Product> _products = [];

    /// <summary>
    /// Adds a product to the collection.
    /// </summary>
    /// <param name="product">The product to add.</param>
    public void Add(Product product)
    {
        _products.Add(product);
    }

    /// <summary>
    /// Creates an iterator for the product collection.
    /// </summary>
    /// <returns>An iterator for the products in the collection.</returns>
    public IIterator<Product> CreateIterator()
    {
        return new ListIterator<Product>(_products);
    }
}