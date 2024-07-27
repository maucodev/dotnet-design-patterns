namespace Mediator.UIObserverExample.Observer;

/// <summary>
/// Handles events related to the articles list box, title text box, and save button.
/// Updates the title text box content and enables the save button when an article is selected.
/// </summary>
public class ArticlesEventHandler : IEventHandler
{
    private readonly Framework.ListBox _articlesListBox;
    private readonly Framework.TextBox _titleTextBox;
    private readonly Framework.Button _saveButton;

    /// <summary>
    /// Initializes a new instance of the <see cref="ArticlesEventHandler"/> class.
    /// </summary>
    /// <param name="articlesListBox">The articles list box control.</param>
    /// <param name="titleTextBox">The title text box control.</param>
    /// <param name="saveButton">The save button control.</param>
    public ArticlesEventHandler(
        Framework.ListBox articlesListBox, 
        Framework.TextBox titleTextBox, 
        Framework.Button saveButton)
    {
        _articlesListBox = articlesListBox;
        _titleTextBox = titleTextBox;
        _saveButton = saveButton;
    }

    /// <inheritdoc/>
    public void Handle()
    {
        _titleTextBox.Content = _articlesListBox.Selection;
        _saveButton.IsEnabled = true;
    }
}