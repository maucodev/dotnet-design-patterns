namespace Builder.BasicExample.App;

/// <summary>
/// Represents a slide in a presentation.
/// </summary>
public class Slide
{
    /// <summary>
    /// Gets the text content of the slide.
    /// </summary>
    public string Text { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Slide"/> class with the specified text.
    /// </summary>
    /// <param name="text">The text content of the slide.</param>
    public Slide(string text)
    {
        Text = text;
    }
}