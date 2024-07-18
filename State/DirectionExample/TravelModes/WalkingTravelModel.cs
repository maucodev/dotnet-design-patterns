using System;

namespace State.DirectionExample.TravelModes;

/// <summary>
/// Represents the walking travel mode.
/// </summary>
public class WalkingTravelModel: ITravelMode
{
    /// <inheritdoc/>
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (walking)");
        return 4;
    }

    /// <inheritdoc/>
    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (walking)");
        return 4;
    }
}