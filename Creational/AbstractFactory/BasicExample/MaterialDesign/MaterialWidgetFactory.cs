using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.MaterialDesign;

/// <summary>
/// A factory for creating Material Design widgets.
/// </summary>
public class MaterialWidgetFactory : IWidgetFactory
{
    /// <inheritdoc />
    public IButton CreateButton()
    {
        return new MaterialButton();
    }

    /// <inheritdoc />
    public ITextBox CreateTextBox()
    {
        return new MaterialTextBox();
    }
}