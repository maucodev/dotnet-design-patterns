namespace State.DirectionExample;

public interface ITravelMode
{
    /// <summary>
    /// Gets the estimated time of arrival (ETA) for the current travel mode.
    /// </summary>
    /// <returns>The ETA as an object.</returns>
    public object GetEta();

    /// <summary>
    /// Gets the direction for the current travel mode.
    /// </summary>
    /// <returns>The direction as an object.</returns>
    public object GetDirection();
}