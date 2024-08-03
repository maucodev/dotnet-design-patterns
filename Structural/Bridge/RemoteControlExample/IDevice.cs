namespace Bridge.RemoteControlExample;

/// <summary>
/// Defines the interface for device operations.
/// </summary>
public interface IDevice
{
    /// <summary>
    /// Turns on the device.
    /// </summary>
    public void TurnOn();

    /// <summary>
    /// Turns off the device.
    /// </summary>
    public void TurnOff();

    /// <summary>
    /// Sets the channel on the device.
    /// </summary>
    /// <param name="number">The channel number to set.</param>
    public void SetChannel(int number);
}