using System;

namespace Flyweight.MapsExample;

/// <summary>
/// Represents a point on a map with coordinates and an icon.
/// </summary>
public class Point
{
    private readonly int _x;
    private readonly int _y;
    private readonly PointIcon _icon;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the point.</param>
    /// <param name="y">The y-coordinate of the point.</param>
    /// <param name="icon">The icon representing the point.</param>
    public Point(int x, int y, PointIcon icon)
    {
        _x = x;
        _y = y;
        _icon = icon;
    }

    /// <summary>
    /// Draws the point on the map.
    /// </summary>
    public void Draw()
    {
        Console.WriteLine($"{_icon.Type} at ({_x},{_y})");
    }
}