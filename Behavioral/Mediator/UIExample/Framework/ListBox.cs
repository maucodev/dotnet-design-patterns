namespace Mediator.UIExample.Framework;

/// <summary>
/// Represents a list box UI control.
/// </summary>
public class ListBox : UIControl
{
    private string _selection;

    /// <summary>
    /// Initializes a new instance of the <see cref="ListBox"/> class with the specified owner dialog box.
    /// </summary>
    /// <param name="owner">The owner dialog box.</param>
    public ListBox(DialogBox owner) : base(owner)
    {
    }

    /// <summary>
    /// Gets or sets the selected item in the list box.
    /// Notifies the owner dialog box when the selection changes.
    /// </summary>
    public string Selection
    {
        get => _selection;
        set
        {
            _selection = value;
            Owner.Changed(this);
        }
    }
}