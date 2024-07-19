using System.Collections.Generic;
using Iterator.Iterators;

namespace Iterator.BrowseExample;

/// <summary>
/// Represents the browsing history which maintains a list of URLs.
/// </summary>
public class BrowseHistory
{
    private int _totalItems;
    private List<string> _urls = [];

    /// <summary>
    /// Adds a new URL to the browsing history.
    /// </summary>
    /// <param name="url">The URL to add.</param>
    public void Push(string url)
    {
        _urls.Add(url);
        _totalItems++;
    }

    /// <summary>
    /// Removes the most recently added URL from the browsing history.
    /// </summary>
    /// <returns>The URL that was removed.</returns>
    public string Pop()
    {
        var item = _urls[_totalItems - 1];
        _urls.RemoveAt(_totalItems - 1);
        return item;
    }

    /// <summary>
    /// Creates an iterator for the browsing history.
    /// </summary>
    /// <returns>An iterator for the URLs in the browsing history.</returns>
    public IIterator<string> CreateIterator()
    {
        return new ListIterator<string>(_urls);
    }
}