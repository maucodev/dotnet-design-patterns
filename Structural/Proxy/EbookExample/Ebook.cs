namespace Proxy.EbookExample;

/// <summary>
/// Represents an abstract base class for an ebook.
/// </summary>
public abstract class Ebook
{
    /// <summary>
    /// Gets or sets the file name of the ebook.
    /// </summary>
    public string FileName;

    /// <summary>
    /// Displays the ebook content.
    /// </summary>
    public abstract void Show();
}