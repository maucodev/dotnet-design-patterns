namespace State.DirectionExample;

/// <summary>
/// Provides services for direction calculation based on the current travel mode.
/// </summary>
public class DirectionService
{
    /// <summary>
    /// Gets or sets the current travel mode.
    /// </summary>
    public ITravelMode TravelMode { get; set; }

    /// <summary>
    /// Gets the estimated time of arrival (ETA) by delegating to the current travel mode.
    /// </summary>
    /// <returns>The ETA as an object.</returns>
    public object GetEta()
    {
        return TravelMode.GetEta();
    }

    /// <summary>
    /// Gets the direction by delegating to the current travel mode.
    /// </summary>
    /// <returns>The direction as an object.</returns>
    public object GetDirection()
    {
        return TravelMode.GetDirection();
    }
}