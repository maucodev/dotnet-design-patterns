using System;

namespace Proxy.EbookExample;

/// <summary>
/// Represents a logging proxy class for an ebook that logs access to the real ebook.
/// </summary>
public class LoggingEbookProxy : Ebook
{
    private RealEbook _ebook;

    /// <summary>
    /// Initializes a new instance of the <see cref="LoggingEbookProxy"/> class.
    /// </summary>
    /// <param name="fileName">The file name of the ebook.</param>
    public LoggingEbookProxy(string fileName)
    {
        FileName = fileName;
    }

    /// <inheritdoc/>
    public override void Show()
    {
        _ebook ??= new RealEbook(FileName);

        Console.WriteLine($"Logging: {FileName}");

        _ebook.Show();
    }
}