using System;

namespace Proxy.EbookExample;

/// <summary>
/// Represents a real ebook with the actual implementation of loading and showing the content.
/// </summary>
public class RealEbook : Ebook
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RealEbook"/> class.
    /// </summary>
    /// <param name="fileName">The file name of the ebook.</param>
    public RealEbook(string fileName)
    {
        FileName = fileName;
        Load();
    }

    /// <summary>
    /// Loads the ebook content. This is a simulated method for the purpose of this example.
    /// </summary>
    private void Load()
    {
        Console.WriteLine($"Loading the ebook: {FileName}");
    }

    /// <inheritdoc/>
    public override void Show()
    {
        Console.WriteLine($"Showing the ebook: {FileName}");
    }
}