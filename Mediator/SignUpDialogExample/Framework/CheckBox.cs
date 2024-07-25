namespace Mediator.SignUpDialogExample.Framework;

/// <summary>
/// Represents a checkbox UI control.
/// </summary>
public class CheckBox: UIControl
{
    private bool _isEnabled;

    /// <summary>
    /// Gets or sets a value indicating whether the checkbox is enabled.
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