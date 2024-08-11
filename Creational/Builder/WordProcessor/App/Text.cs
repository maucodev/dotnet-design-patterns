namespace Builder.WordProcessor.App;

/// <summary>
/// Represents a text element in a document.
/// </summary>
public class Text : IElement
{
    /// <summary>
    /// Gets the content of the text element.
    /// </summary>
    public string Content { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Text"/> class with the specified content.
    /// </summary>
    /// <param name="content">The content of the text element.</param>
    public Text(string content)
    {
        Content = content;
    }
}