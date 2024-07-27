using System.Collections.Generic;
using Mediator.SignUpDialogExample.Observer;

namespace Mediator.SignUpDialogExample.Framework;

/// <summary>
/// Represents a base class for UI controls.
/// Manages a list of event handlers and notifies them when an event occurs.
/// </summary>
public abstract class UIControl
{
    private readonly List<IEventHandler> _eventHandlers = [];

    /// <summary>
    /// Adds an event handler to the control.
    /// </summary>
    /// <param name="eventHandler">The event handler to add.</param>
    public void AddEventHandler(IEventHandler eventHandler)
    {
        _eventHandlers.Add(eventHandler);
    }

    /// <summary>
    /// Notifies all event handlers when an event occurs.
    /// </summary>
    protected void NotifyEventHandlers()
    {
        foreach (var eventHandler in _eventHandlers)
        {
            eventHandler.Handle();
        }
    }
}