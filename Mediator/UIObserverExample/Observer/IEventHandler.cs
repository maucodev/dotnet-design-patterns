namespace Mediator.UIObserverExample.Observer;

/// <summary>
/// Defines an interface for handling events.
/// </summary>
public interface IEventHandler
{
    /// <summary>
    /// Handles the event.
    /// </summary>
    public void Handle();
}