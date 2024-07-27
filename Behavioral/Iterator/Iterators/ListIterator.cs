using System.Collections.Generic;

namespace Iterator.Iterators;

/// <summary>
/// A concrete implementation of the IIterator interface for a list.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
public class ListIterator<T> : IIterator<T>
{
    private int _index;
    private readonly List<T> _list;

    /// <summary>
    /// Initializes a new instance of the ListIterator class.
    /// </summary>
    /// <param name="list">The list to iterate over.</param>
    public ListIterator(List<T> list)
    {
        _list = list;
    }

    /// <inheritdoc/>
    public bool HasNext()
    {
        return _index < _list.Count;
    }

    /// <inheritdoc/>
    public T Current()
    {
        return _list[_index];
    }

    /// <inheritdoc/>
    public void Next()
    {
        _index++;
    }
}