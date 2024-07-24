namespace Mediator.UIObserverExample.Observer;

/// <summary>
/// Handles events related to the title text box and save button.
/// Enables or disables the save button based on the content of the text box.
/// </summary>
public class TitleEventHandler : IEventHandler
{
    private readonly Framework.TextBox _titleTextBox;
    private readonly Framework.Button _saveButton;

    /// <summary>
    /// Initializes a new instance of the <see cref="TitleEventHandler"/> class.
    /// </summary>
    /// <param name="titleTextBox">The title text box control.</param>
    /// <param name="saveButton">The save button control.</param>
    public TitleEventHandler(
        Framework.TextBox titleTextBox,
        Framework.Button saveButton)
    {
        _titleTextBox = titleTextBox;
        _saveButton = saveButton;
    }

    /// <inheritdoc/>
    public void Handle()
    {
        var isEmpty = string.IsNullOrEmpty(_titleTextBox.Content);
        _saveButton.IsEnabled = !isEmpty;
    }
}