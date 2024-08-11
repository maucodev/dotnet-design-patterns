using System.Globalization;

namespace Builder.WordProcessor.Html;

/// <summary>
/// Represents an HTML paragraph element.
/// </summary>
public class HtmlParagraph : HtmlElement
{
    private readonly string _text;

    /// <summary>
    /// Initializes a new instance of the <see cref="HtmlParagraph"/> class with the specified text content.
    /// </summary>
    /// <param name="text">The text content of the paragraph.</param>
    public HtmlParagraph(string text)
    {
        _text = text;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return string.Format(CultureInfo.InvariantCulture, "<p>{0}</p>", _text);
    }
}