namespace Memento;

/// <summary>
/// The 'Memento' class, which stores the state of the originator.
/// </summary>
public class DocumentState(string content, string fontName, int fontSize)
{
    /// <summary>
    /// Gets the content stored in the memento.
    /// </summary>
    public string Content { get; } = content;

    /// <summary>
    /// Gets the font name stored in the memento.
    /// </summary>
    public string FontName { get; } = fontName;

    /// <summary>
    /// Gets the font size stored in the memento.
    /// </summary>
    public int FontSize { get; } = fontSize;
}