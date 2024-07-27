namespace Mediator.SignUpDialogExample.Framework;

/// <summary>
/// Represents a text box UI control.
/// </summary>
public class TextBox : UIControl
{
    private string _content;

    /// <summary>
    /// Gets or sets the content of the text box.
    /// Notifies event handlers when the content changes.
    /// </summary>
    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            NotifyEventHandlers();
        }
    }
}