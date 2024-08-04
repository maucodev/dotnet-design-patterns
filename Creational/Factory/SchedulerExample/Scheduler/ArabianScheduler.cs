using Factory.SchedulerExample.Calendar;

namespace Factory.SchedulerExample.Scheduler;

/// <summary>
/// Scheduler that uses the Arabian calendar for scheduling events.
/// </summary>
public class ArabianScheduler : Scheduler
{
    /// <inheritdoc />
    protected override ICalendar CreateCalendar()
    {
        return new ArabianCalendar();
    }
}