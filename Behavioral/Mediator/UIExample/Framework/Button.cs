namespace Mediator.UIExample.Framework;

/// <summary>
/// Represents a button UI control.
/// </summary>
public class Button : UIControl
{
    private bool _isEnabled;

    /// <summary>
    /// Initializes a new instance of the <see cref="Button"/> class with the specified owner dialog box.
    /// </summary>
    /// <param name="owner">The owner dialog box.</param>
    public Button(DialogBox owner) : base(owner)
    {
    }

    /// <summary>
    /// Gets or sets a value indicating whether the button is enabled.
    /// Notifies the owner dialog box when the enabled state changes.
    /// </summary>
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            _isEnabled = value;
            Owner.Changed(this);
        }
    }
}