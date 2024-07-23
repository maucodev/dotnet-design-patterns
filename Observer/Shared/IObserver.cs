namespace Observer.Shared;

/// <summary>
/// Defines an interface for observers that need to be notified of changes.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Called when the subject's state changes.
    /// </summary>
    /// <param name="value">The new value of the subject.</param>
    void Update(int value);
}