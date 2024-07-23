using System;
using Observer.Shared;

namespace Observer.SpreadSheetsExample;

/// <summary>
/// Represents an observer that displays updates on a spreadsheet.
/// </summary>
public class SpreadSheet : IObserver
{
    /// <inheritdoc/>
    public void Update(int value)
    {
        Console.WriteLine($"SpreadSheet got updated: {value}");
    }
}