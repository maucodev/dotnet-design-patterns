using System.Text;
using Builder.WordProcessor.Abstractions;
using Builder.WordProcessor.App;

namespace Builder.WordProcessor.Builders;

/// <summary>
/// A concrete builder that constructs a plain text document.
/// </summary>
public class TextDocumentBuilder : IDocumentBuilder
{
    private readonly StringBuilder _builder = new();

    /// <inheritdoc/>
    public void AddText(Text text)
    {
        _builder.AppendJoin(' ', text.Content);
    }

    /// <inheritdoc/>
    public void AddImage(Image image)
    {
        _builder.AppendJoin(' ', image.Source);
    }

    /// <inheritdoc/>
    public string GetResult()
    {
        return _builder.ToString();
    }
}