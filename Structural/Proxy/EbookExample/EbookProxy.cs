namespace Proxy.EbookExample;

/// <summary>
/// Represents a proxy class for an ebook that controls access to the real ebook.
/// </summary>
public class EbookProxy : Ebook
{
    private RealEbook _ebook;

    /// <summary>
    /// Initializes a new instance of the <see cref="EbookProxy"/> class.
    /// </summary>
    /// <param name="filename">The file name of the ebook.</param>
    public EbookProxy(string filename)
    {
        FileName = filename;
    }

    /// <inheritdoc/>
    public override void Show()
    {
        _ebook ??= new RealEbook(FileName);

        _ebook.Show();
    }
}