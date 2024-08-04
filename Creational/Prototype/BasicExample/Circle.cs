using System;

namespace Prototype.BasicExample;

/// <summary>
/// Represents a circle component that implements the <see cref="IComponent"/> interface.
/// </summary>
public class Circle : IComponent
{
    private readonly int _radius;

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(int radius)
    {
        _radius = radius;
    }

    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine($"Rendering a circle with a radius of {_radius}");
    }

    /// <inheritdoc />
    public IComponent Clone()
    {
        Console.WriteLine("Cloning a circle");

        return new Circle(_radius);
    }
}