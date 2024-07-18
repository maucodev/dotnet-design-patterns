using System;

namespace State.DirectionExample.TravelModes;

/// <summary>
/// Represents the driving travel mode.
/// </summary>
public class DrivingTravelMode : ITravelMode
{
    /// <inheritdoc/>
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (driving)");
        return 1;
    }

    /// <inheritdoc/>
    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (driving)");
        return 1;
    }
}