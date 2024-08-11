using Builder.WordProcessor.Abstractions;
using Builder.WordProcessor.App;
using Builder.WordProcessor.Html;

namespace Builder.WordProcessor.Builders;

/// <summary>
/// A concrete builder that constructs an HTML document.
/// </summary>
public class HtmlDocumentBuilder : IDocumentBuilder
{
    private readonly HtmlDocument _document = new();

    /// <inheritdoc/>
    public void AddText(Text text)
    {
        _document.Add(new HtmlParagraph(text.Content));
    }

    /// <inheritdoc/>
    public void AddImage(Image image)
    {
        _document.Add(new HtmlImage(image.Source));
    }

    /// <inheritdoc/>
    public string GetResult()
    {
        return "HTML document result";
    }
}