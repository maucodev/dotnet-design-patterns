using System.Collections.Generic;

namespace Proxy.EbookExample;

/// <summary>
/// Represents a library that manages a collection of ebooks.
/// </summary>
public class Library
{
    private readonly Dictionary<string, Ebook> _ebooks = [];

    /// <summary>
    /// Adds an ebook to the library.
    /// </summary>
    /// <param name="realEbook">The ebook to add.</param>
    public void Add(Ebook realEbook)
    {
        _ebooks.Add(realEbook.FileName, realEbook);
    }

    /// <summary>
    /// Opens and displays the content of an ebook by file name.
    /// </summary>
    /// <param name="fileName">The file name of the ebook to open.</param>
    public void Open(string fileName)
    {
        _ebooks[fileName].Show();
    }
}