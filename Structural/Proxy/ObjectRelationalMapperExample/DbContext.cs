using System;
using System.Collections.Generic;

namespace Proxy.ObjectRelationalMapperExample;

/// <summary>
/// Represents a database context that tracks changes to products and provides methods for interacting with products.
/// </summary>
public class DbContext
{
    private readonly Dictionary<int, Product> _updatedProducts = new();

    /// <summary>
    /// Gets a product by its unique identifier. Returns a proxy for the product.
    /// </summary>
    /// <param name="id">The unique identifier of the product.</param>
    /// <returns>A <see cref="ProductProxy"/> representing the product.</returns>
    public Product GetProduct(int id)
    {
        var product = new ProductProxy(id, this);

        return product;
    }

    /// <summary>
    /// Saves all changes made to products in the context.
    /// </summary>
    public void SaveChanges()
    {
        Console.WriteLine($"Saving {_updatedProducts.Count} products");

        _updatedProducts.Clear();
    }

    /// <summary>
    /// Marks a product as changed in the context.
    /// </summary>
    /// <param name="product">The product that has been changed.</param>
    public void MarkAsChanged(Product product)
    {
        if (_updatedProducts.TryGetValue(product.Id, out _))
        {
            _updatedProducts[product.Id] = product;
            return;
        }

        _updatedProducts.Add(product.Id, product);
    }
}