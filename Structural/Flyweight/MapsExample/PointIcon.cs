namespace Flyweight.MapsExample;

/// <summary>
/// Represents an icon for a point.
/// </summary>
public class PointIcon
{
    /// <summary>
    /// Gets the type of point the icon represents.
    /// </summary>
    public PointType Type { get; }

    private readonly byte[] _icon;

    /// <summary>
    /// Initializes a new instance of the <see cref="PointIcon"/> class.
    /// </summary>
    /// <param name="type">The type of point.</param>
    /// <param name="icon">The icon data.</param>
    public PointIcon(PointType type, byte[] icon)
    {
        Type = type;
        _icon = icon;
    }
}