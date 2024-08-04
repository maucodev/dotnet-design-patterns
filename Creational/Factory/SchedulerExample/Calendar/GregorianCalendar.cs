using System;

namespace Factory.SchedulerExample.Calendar;

/// <summary>
/// A Gregorian calendar implementation.
/// </summary>
public class GregorianCalendar : ICalendar
{
    /// <inheritdoc />
    public void AddEvent(Event.Event @event, DateOnly date)
    {
        Console.WriteLine($"Adding an event on {date} to the Gregorian Calendar");
    }
}