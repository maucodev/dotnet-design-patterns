using System.Collections.Generic;
using System.Text;

namespace Builder.WordProcessor.Html;

/// <summary>
/// Represents an HTML document composed of various HTML elements.
/// </summary>
public class HtmlDocument
{
    private readonly List<HtmlElement> _elements = [];

    /// <summary>
    /// Adds an HTML element to the document.
    /// </summary>
    /// <param name="element">The HTML element to add.</param>
    public void Add(HtmlElement element)
    {
        _elements.Add(element);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.Append("<html>");

        foreach (var element in _elements) 
            builder.Append(element);

        builder.Append("</html>");

        return builder.ToString();
    }
}
