using System;

namespace State.DirectionExample.TravelModes;

/// <summary>
/// Represents the transit travel mode.
/// </summary>
public class TransitTravelModel: ITravelMode
{
    /// <inheritdoc/>
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (transit)");
        return 3;
    }

    /// <inheritdoc/>
    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (transit)");
        return 3;
    }
}