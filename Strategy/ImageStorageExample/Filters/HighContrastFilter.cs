using System;

namespace Strategy.ImageStorageExample.Filters;

/// <summary>
/// A concrete implementation of the IFilter interface that applies a high-contrast filter.
/// </summary>
public class HighContrastFilter : IFilter
{
    /// <inheritdoc/>
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying High-Contrast filter");
    }
}