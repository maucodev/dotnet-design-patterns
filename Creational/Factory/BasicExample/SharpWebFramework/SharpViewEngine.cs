using System.Collections.Generic;

namespace Factory.BasicExample.SharpWebFramework;

/// <summary>
/// A view engine implementation using Sharp.
/// </summary>
public class SharpViewEngine : IViewEngine
{
    /// <inheritdoc />
    public string Render(string viewName, Dictionary<string, object> data)
    {
        return "View rendered by Sharp";
    }
}