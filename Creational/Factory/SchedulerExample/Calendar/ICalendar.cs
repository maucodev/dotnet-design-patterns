using System;

namespace Factory.SchedulerExample.Calendar;

/// <summary>
/// Represents a calendar that can have events added to it.
/// </summary>
public interface ICalendar
{
    /// <summary>
    /// Adds an event to the calendar on the specified date.
    /// </summary>
    /// <param name="event">The event to add.</param>
    /// <param name="date">The date of the event.</param>
    public void AddEvent(Event.Event @event, DateOnly date);
}