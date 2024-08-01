using System;

namespace Adapter.BasicExample;

/// <summary>
/// Represents a vivid filter that can be applied to an image.
/// </summary>
public class VividFilter : IFilter
{
    /// <inheritdoc />
    public void Apply(Image image)
    {
        Console.WriteLine("Applying vivid filter");
    }
}