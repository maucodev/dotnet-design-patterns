using System.Collections.Generic;

namespace Factory.BasicExample;

/// <summary>
/// Controller for managing products.
/// </summary>
/// <remarks>This class can inherits Controller or ProductsSharpController</remarks>
public class ProductsController : ProductsSharpController
{
    /// <summary>
    /// Lists the products.
    /// </summary>
    public void ListProducts()
    {
        Dictionary<string, object> data = [];

        Render("products", data);
    }
}