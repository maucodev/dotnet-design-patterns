using System;

namespace Composite.BasicExample;

/// <summary>
/// Represents a shape.
/// </summary>
public class Shape : IComponent
{
    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine("Render shape");
    }

    /// <inheritdoc />
    public void Move()
    {
        Console.WriteLine("Move shape");
    }
}