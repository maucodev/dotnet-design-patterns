using Factory.BasicExample.SharpWebFramework;

namespace Factory.BasicExample;

/// <summary>
/// Controller for managing products using the Sharp view engine.
/// </summary>
public class ProductsSharpController : Controller
{
    /// <inheritdoc />
    protected override IViewEngine CreateViewEngine()
    {
        return new SharpViewEngine();
    }
}