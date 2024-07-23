using System.Collections.Generic;

namespace Observer.Shared;

/// <summary>
/// Represents the subject that maintains a list of observers and notifies them of changes.
/// </summary>
public class Subject
{
    private readonly List<IObserver> _observers = [];

    /// <summary>
    /// Adds an observer to the list.
    /// </summary>
    /// <param name="observer">The observer to be added.</param>
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// Removes an observer from the list.
    /// </summary>
    /// <param name="observer">The observer to be removed.</param>
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    /// <summary>
    /// Notifies all observers of a change in state.
    /// </summary>
    /// <param name="value">The new value to notify observers about.</param>
    protected void NotifyObservers(int value)
    {
        foreach (var observer in _observers)
        {
            observer.Update(value);
        }
    }
}