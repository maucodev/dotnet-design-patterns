namespace Prototype.VideoEditorExample;

/// <summary>
/// Represents a text component that implements the <see cref="IComponent"/> interface.
/// </summary>
public class TextComponent : IComponent
{
    /// <summary>
    /// Gets or sets the content of the text component.
    /// </summary>
    public string Content { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextComponent"/> class with the specified content.
    /// </summary>
    /// <param name="content">The content of the text component.</param>
    public TextComponent(string content)
    {
        Content = content;
    }

    /// <inheritdoc />
    public IComponent Clone()
    {
        return new TextComponent(Content);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "Text";
    }
}