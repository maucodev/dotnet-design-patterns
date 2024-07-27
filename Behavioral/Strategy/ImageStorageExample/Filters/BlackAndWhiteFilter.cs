using System;

namespace Strategy.ImageStorageExample.Filters;

/// <summary>
/// A concrete implementation of the IFilter interface that applies a black-and-white filter.
/// </summary>
public class BlackAndWhiteFilter : IFilter
{
    /// <inheritdoc/>
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying B&W filter");
    }
}