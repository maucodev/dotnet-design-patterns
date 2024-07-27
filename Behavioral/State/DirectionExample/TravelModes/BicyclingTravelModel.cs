using System;

namespace State.DirectionExample.TravelModes;

/// <summary>
/// Represents the bicycling travel mode.
/// </summary>
public class BicyclingTravelModel: ITravelMode
{
    /// <inheritdoc/>
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (bicycling)");
        return 2;
    }

    /// <inheritdoc/>
    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (bicycling)");
        return 2;
    }
}