namespace Bridge.RemoteControlExample;

/// <summary>
/// Extends <see cref="RemoteControl"/> to provide advanced functionality.
/// </summary>
public class AdvancedRemoteControl : RemoteControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AdvancedRemoteControl"/> class.
    /// </summary>
    /// <param name="device">The device to control.</param>
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    /// <summary>
    /// Sets the channel on the device.
    /// </summary>
    /// <param name="number">The channel number to set.</param>
    public void SetChannel(int number)
    {
        Device.SetChannel(number);
    }
}