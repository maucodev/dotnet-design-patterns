using System.Collections.Generic;

namespace Flyweight.MapsExample;

/// <summary>
/// Service for managing points on a map.
/// </summary>
public class PointService
{
    private readonly PointIconFactory _iconFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="PointService"/> class.
    /// </summary>
    /// <param name="iconFactory">The factory for creating point icons.</param>
    public PointService(PointIconFactory iconFactory)
    {
        _iconFactory = iconFactory;
    }

    /// <summary>
    /// Gets a list of points.
    /// </summary>
    /// <returns>A list of points.</returns>
    public List<Point> GetPoints()
    {
        return [new(1, 2, _iconFactory.GetPointIcon(PointType.Cafe))];
    }
}