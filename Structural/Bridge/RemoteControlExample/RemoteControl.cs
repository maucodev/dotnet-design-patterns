namespace Bridge.RemoteControlExample;

/// <summary>
/// Abstract class that provides basic remote control functionality.
/// </summary>
public class RemoteControl
{
    /// <summary>
    /// The device associated with the remote control.
    /// </summary>
    protected readonly IDevice Device;

    /// <summary>
    /// Initializes a new instance of the <see cref="RemoteControl"/> class.
    /// </summary>
    /// <param name="device">The device to control.</param>
    public RemoteControl(IDevice device)
    {
        Device = device;
    }

    /// <summary>
    /// Turns on the device.
    /// </summary>
    public void TurnOn()
    {
        Device.TurnOn();
    }

    /// <summary>
    /// Turns off the device.
    /// </summary>
    public void TurnOff()
    {
        Device.TurnOff();
    }
}