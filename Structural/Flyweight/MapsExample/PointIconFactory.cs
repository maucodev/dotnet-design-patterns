using System.Collections.Generic;

namespace Flyweight.MapsExample;

/// <summary>
/// Factory for creating and managing point icons.
/// </summary>
public class PointIconFactory
{
    private readonly Dictionary<PointType, PointIcon> _icons = [];

    /// <summary>
    /// Gets the point icon for the specified type. If it does not exist, creates a new one.
    /// </summary>
    /// <param name="type">The type of point.</param>
    /// <returns>The point icon.</returns>
    public PointIcon GetPointIcon(PointType type)
    {
        if (_icons.TryGetValue(type, out PointIcon value))
        {
            return value;
        }

        value = new PointIcon(type, icon: default);
        
        _icons.Add(type, value);

        return value;
    }
}