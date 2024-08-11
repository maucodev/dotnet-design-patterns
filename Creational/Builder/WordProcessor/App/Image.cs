namespace Builder.WordProcessor.App;

/// <summary>
/// Represents an image element in a document.
/// </summary>
public class Image : IElement
{
    /// <summary>
    /// Gets the source URL of the image.
    /// </summary>
    public string Source { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Image"/> class with the specified source URL.
    /// </summary>
    /// <param name="source">The source URL of the image.</param>
    public Image(string source)
    {
        Source = source;
    }
}