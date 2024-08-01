using System;

namespace Adapter.BasicExample.ThirdFilters;

/// <summary>
/// Represents the Caramel filter which is a third-party filter library.
/// </summary>
public class Caramel
{
    /// <summary>
    /// Initializes the Caramel filter.
    /// </summary>
    public void Init()
    {
        Console.WriteLine("Initializing the Caramel class");
    }

    /// <summary>
    /// Renders the Caramel filter effect on the given image.
    /// </summary>
    /// <param name="image">The image to apply the Caramel filter to.</param>
    public void Render(Image image)
    {
        Console.WriteLine("Applying caramel filter");
    }
}