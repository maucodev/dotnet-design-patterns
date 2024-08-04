using System.Collections.Generic;

namespace Factory.BasicExample;

/// <summary>
/// Represents a view engine that renders views.
/// </summary>
public interface IViewEngine
{
    /// <summary>
    /// Renders the specified view with the provided data.
    /// </summary>
    /// <param name="viewName">The name of the view to render.</param>
    /// <param name="data">A dictionary containing the data to be used in the view.</param>
    /// <returns>A string representing the rendered view.</returns>
    string Render(string viewName, Dictionary<string, object> data);
}