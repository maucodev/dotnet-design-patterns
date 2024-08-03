using System;

namespace Bridge.RemoteControlExample;

/// <summary>
/// Implements a Samsung device.
/// </summary>
public class SamsungDevice : IDevice
{
    /// <inheritdoc/>
    public void TurnOn()
    {
        Console.WriteLine("Samsung: TurnOn");
    }

    /// <inheritdoc/>
    public void TurnOff()
    {
        Console.WriteLine("Samsung: TurnOff");
    }

    /// <inheritdoc/>
    public void SetChannel(int number)
    {
        Console.WriteLine("Samsung: SetChannel");
    }
}