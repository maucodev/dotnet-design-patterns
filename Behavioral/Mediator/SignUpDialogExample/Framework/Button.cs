namespace Mediator.SignUpDialogExample.Framework;

/// <summary>
/// Represents a button UI control.
/// </summary>
public class Button : UIControl
{
    private bool _isEnabled;

    /// <summary>
    /// Gets or sets a value indicating whether the button is enabled.
    /// Notifies event handlers when the enabled state changes.
    /// </summary>
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            _isEnabled = value;
            NotifyEventHandlers();
        }
    }
}