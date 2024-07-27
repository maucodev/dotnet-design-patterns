using System;
using Observer.Shared;

namespace Observer.StocksExample;

/// <summary>
/// Represents an observer that displays updates on a status bar.
/// </summary>
public class StatusBar : IObserver
{
    /// <inheritdoc/>
    public void Update(int value)
    {
        Console.WriteLine($"Status bar updated: {value}");
    }
}