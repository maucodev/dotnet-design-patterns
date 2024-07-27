using System;
using Observer.Shared;

namespace Observer.SpreadSheetsExample;

/// <summary>
/// Represents an observer that displays updates on a chart.
/// </summary>
public class Chart : IObserver
{
    /// <inheritdoc/>
    public void Update(int value)
    {
        Console.WriteLine($"Chart got updated: {value}");
    }
}