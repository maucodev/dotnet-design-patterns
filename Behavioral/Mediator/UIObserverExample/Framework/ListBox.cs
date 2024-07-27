namespace Mediator.UIObserverExample.Framework;

/// <summary>
/// Represents a list box UI control.
/// </summary>
public class ListBox : UIControl
{
    private string _selection;

    /// <summary>
    /// Gets or sets the selected item in the list box.
    /// Notifies event handlers when the selection changes.
    /// </summary>
    public string Selection
    {
        get => _selection;
        set
        {
            _selection = value;
            NotifyEventHandlers();
        }
    }
}