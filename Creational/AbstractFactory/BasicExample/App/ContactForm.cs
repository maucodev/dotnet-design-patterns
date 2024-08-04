using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.App;

/// <summary>
/// Represents a contact form that can render widgets.
/// </summary>
public class ContactForm
{
    /// <summary>
    /// Renders the contact form using the specified widget factory.
    /// </summary>
    /// <param name="widgetFactory">The widget factory to use for creating widgets.</param>
    public void Render(IWidgetFactory widgetFactory)
    {
        widgetFactory.CreateButton().Render();
        widgetFactory.CreateTextBox().Render();
    }
}