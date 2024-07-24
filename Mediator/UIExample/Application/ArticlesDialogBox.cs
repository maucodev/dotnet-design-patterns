using System;
using Mediator.UIExample.Framework;

namespace Mediator.UIExample.Application;

/// <summary>
/// Represents a dialog box that coordinates the interaction between various UI controls.
/// Implements the Mediator pattern to handle communication between controls.
/// </summary>
public class ArticlesDialogBox : DialogBox
{
    private readonly ListBox _articlesListBox;
    private readonly TextBox _titleTextBox;
    private readonly Button _saveButton;

    /// <summary>
    /// Initializes a new instance of the <see cref="ArticlesDialogBox"/> class.
    /// Sets up the ListBox, TextBox, and Button controls.
    /// </summary>
    public ArticlesDialogBox()
    {
        _articlesListBox = new ListBox(this);
        _titleTextBox = new TextBox(this);
        _saveButton = new Button(this);
    }

    /// <summary>
    /// Simulates user interaction with the dialog box.
    /// </summary>
    public void SimulateUserInteraction()
    {
        _articlesListBox.Selection = "ArticleOne";

        Console.WriteLine($"TextBox: {_titleTextBox.Content}");
        Console.WriteLine($"Button: {_saveButton.IsEnabled}");

        _titleTextBox.Content = string.Empty;

        Console.WriteLine();
        Console.WriteLine($"TextBox: {_titleTextBox.Content}");
        Console.WriteLine($"Button: {_saveButton.IsEnabled}");
    }

    /// <inheritdoc/>
    public override void Changed(UIControl control)
    {
        // With this implementation, the problem arises that as the number of controls grows,
        // more control logic needs to be implemented. The way to solve this problem is by
        // implementing the Mediator pattern, using the Observer pattern. This is demonstrated
        // in the UIObserverExample code.

        if (control == _articlesListBox)
        {
            ArticleSelected();
        }
        else if (control == _titleTextBox)
        {
            TitleChanged();
        }
    }

    private void ArticleSelected()
    {
        _titleTextBox.Content = _articlesListBox.Selection;
        _saveButton.IsEnabled = true;
    }

    private void TitleChanged()
    {
        var isEmpty = string.IsNullOrEmpty(_titleTextBox.Content);
        _saveButton.IsEnabled = !isEmpty;
    }
}