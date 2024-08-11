using System.Globalization;

namespace Builder.WordProcessor.Html;

/// <summary>
/// Represents an HTML image element.
/// </summary>
public class HtmlImage : HtmlElement
{
    private readonly string _source;

    /// <summary>
    /// Initializes a new instance of the <see cref="HtmlImage"/> class with the specified image source.
    /// </summary>
    /// <param name="source">The source URL of the image.</param>
    public HtmlImage(string source)
    {
        _source = source;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return string.Format(CultureInfo.InvariantCulture, "<img src=\"{0}\" />", _source);
    }
}