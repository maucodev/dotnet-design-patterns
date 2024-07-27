using System;
using Observer.Shared;

namespace Observer.StocksExample;

/// <summary>
/// Represents an observer that displays updates on a stock list view.
/// </summary>
public class StockListView : IObserver
{
    /// <inheritdoc/>
    public void Update(int value)
    {
        Console.WriteLine($"Stock list updated: {value}");
    }
}