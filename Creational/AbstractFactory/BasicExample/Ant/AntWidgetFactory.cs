using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.Ant;

/// <summary>
/// A factory for creating Ant Design widgets.
/// </summary>
public class AntWidgetFactory : IWidgetFactory
{
    /// <inheritdoc />
    public IButton CreateButton()
    {
        return new AntButton();
    }

    /// <inheritdoc />
    public ITextBox CreateTextBox()
    {
        return new AntTextBox();
    }
}