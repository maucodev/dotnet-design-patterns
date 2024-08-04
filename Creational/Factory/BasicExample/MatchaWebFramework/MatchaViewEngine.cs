using System.Collections.Generic;

namespace Factory.BasicExample.MatchaWebFramework;

/// <summary>
/// A view engine implementation using Matcha.
/// </summary>
public class MatchaViewEngine : IViewEngine
{
    /// <inheritdoc />
    public string Render(string viewName, Dictionary<string, object> data)
    {
        return "View rendered by Matcha";
    }
}