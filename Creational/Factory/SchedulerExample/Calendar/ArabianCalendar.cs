using System;

namespace Factory.SchedulerExample.Calendar;

/// <summary>
/// An Arabian calendar implementation.
/// </summary>
public class ArabianCalendar : ICalendar
{
    /// <inheritdoc />
    public void AddEvent(Event.Event @event, DateOnly date)
    {
        Console.WriteLine($"Adding an event on {date} to the Arabian Calendar");
    }
}