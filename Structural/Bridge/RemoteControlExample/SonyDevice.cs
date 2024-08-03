using System;

namespace Bridge.RemoteControlExample;

/// <summary>
/// Implements a Sony device.
/// </summary>
public class SonyDevice : IDevice
{
    /// <inheritdoc/>
    public void TurnOn()
    {
        Console.WriteLine("Sony: TurnOn");
    }

    /// <inheritdoc/>
    public void TurnOff()
    {
        Console.WriteLine("Sony: TurnOff");
    }

    /// <inheritdoc/>
    public void SetChannel(int number)
    {
        Console.WriteLine("Sony: SetChannel");
    }
}