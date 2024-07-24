namespace Mediator.UIExample.Framework;

/// <summary>
/// Represents a text box UI control.
/// </summary>
public class TextBox : UIControl
{
    private string _content;

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBox"/> class with the specified owner dialog box.
    /// </summary>
    /// <param name="owner">The owner dialog box.</param>
    public TextBox(DialogBox owner) : base(owner)
    {
    }

    /// <summary>
    /// Gets or sets the content of the text box.
    /// Notifies the owner dialog box when the content changes.
    /// </summary>
    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            Owner.Changed(this);
        }
    }
}