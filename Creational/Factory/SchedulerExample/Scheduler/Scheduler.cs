using System;
using Factory.SchedulerExample.Calendar;

namespace Factory.SchedulerExample.Scheduler;

/// <summary>
/// Represents a scheduler that schedules events in a calendar.
/// </summary>
public class Scheduler
{
    private readonly ICalendar _calendar;

    /// <summary>
    /// Initializes a new instance of the <see cref="Scheduler"/> class.
    /// </summary>
    public Scheduler()
    {
        _calendar = CreateCalendar();
    }

    /// <summary>
    /// Creates a calendar. This method can be overridden to provide a different calendar implementation.
    /// </summary>
    /// <returns>An instance of <see cref="ICalendar"/>.</returns>
    protected virtual ICalendar CreateCalendar()
    {
        return new GregorianCalendar();
    }

    /// <summary>
    /// Schedules the specified event.
    /// </summary>
    /// <param name="event">The event to schedule.</param>
    public void Schedule(Event.Event @event)
    {
        var date = DateOnly.FromDateTime(DateTime.Now);

        _calendar.AddEvent(@event, date);
    }
}