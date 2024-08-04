namespace AbstractFactory.BasicExample.Widgets;

/// <summary>
/// Represents a factory for creating widgets.
/// </summary>
public interface IWidgetFactory
{
    /// <summary>
    /// Creates a button widget.
    /// </summary>
    /// <returns>An instance of <see cref="IButton"/>.</returns>
    public IButton CreateButton();

    /// <summary>
    /// Creates a text box widget.
    /// </summary>
    /// <returns>An instance of <see cref="ITextBox"/>.</returns>
    public ITextBox CreateTextBox();
}