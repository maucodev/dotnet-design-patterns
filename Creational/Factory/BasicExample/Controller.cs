using System;
using System.Collections.Generic;
using Factory.BasicExample.MatchaWebFramework;

namespace Factory.BasicExample;

/// <summary>
/// Base controller class that provides rendering functionality.
/// </summary>
public class Controller
{
    /// <summary>
    /// Renders the specified view with the provided data.
    /// </summary>
    /// <param name="viewName">The name of the view to render.</param>
    /// <param name="data">A dictionary containing the data to be used in the view.</param>
    protected void Render(string viewName, Dictionary<string, object> data)
    {
        var engine = CreateViewEngine();
        var html = engine.Render(viewName, data);

        Console.WriteLine(html);
    }

    /// <summary>
    /// Creates a view engine. This method can be overridden to provide a different view engine.
    /// </summary>
    /// <returns>An instance of <see cref="IViewEngine"/>.</returns>
    protected virtual IViewEngine CreateViewEngine()
    {
        // This is a default implementation.
        // This method can be declared as abstract.
        return new MatchaViewEngine();
    }
}