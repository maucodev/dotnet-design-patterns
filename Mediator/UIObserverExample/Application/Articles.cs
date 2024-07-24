using System;
using Mediator.UIObserverExample.Framework;
using Mediator.UIObserverExample.Observer;

namespace Mediator.UIObserverExample.Application;

/// <summary>
/// Represents the articles UI component that contains a list box, text box, and button.
/// Manages the interaction between these controls using event handlers.
/// </summary>
public class Articles
{
    private readonly ListBox _articlesListBox = new();
    private readonly TextBox _titleTextBox = new();
    private readonly Button _saveButton = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Articles"/> class.
    /// Sets up event handlers for the list box and text box controls.
    /// </summary>
    public Articles()
    {
        var articlesEventHandler = new ArticlesEventHandler(_articlesListBox, _titleTextBox, _saveButton);
        var titleEventHandler = new TitleEventHandler(_titleTextBox, _saveButton);

        _articlesListBox.AddEventHandler(articlesEventHandler);
        _titleTextBox.AddEventHandler(titleEventHandler);
    }

    /// <summary>
    /// Simulates user interaction with the articles component.
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
}