using Builder.WordProcessor.App;

namespace Builder.WordProcessor.Abstractions;

/// <summary>
/// Defines the methods required to build a document, including adding text and images, 
/// and retrieving the final result.
/// </summary>
public interface IDocumentBuilder
{
    /// <summary>
    /// Adds a text element to the document.
    /// </summary>
    /// <param name="text">The text element to add.</param>
    public void AddText(Text  text);

    /// <summary>
    /// Adds an image element to the document.
    /// </summary>
    /// <param name="image">The image element to add.</param>
    public void AddImage(Image image);

    /// <summary>
    /// Returns the result of the document building process.
    /// </summary>
    /// <returns>A string representing the constructed document.</returns>
    public string GetResult();
}