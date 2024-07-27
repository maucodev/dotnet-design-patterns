namespace Iterator;

public interface IIterator<T>
{
    /// <summary>
    /// Determines if there are more elements to iterate over.
    /// </summary>
    /// <returns>True if there are more elements, otherwise false.</returns>
    public bool HasNext();

    /// <summary>
    /// Gets the current element in the iteration.
    /// </summary>
    /// <returns>The current element.</returns>
    public T Current();

    /// <summary>
    /// Advances the iterator to the next element.
    /// </summary>
    public void Next();
}