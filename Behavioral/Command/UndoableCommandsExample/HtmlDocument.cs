namespace Command.UndoableCommandsExample;

/// <summary>
/// Represents an HTML document with editable content.
/// </summary>
public class HtmlDocument
{
    /// <summary>
    /// Gets or sets the content of the document.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Makes the content bold by wrapping it with bold tags.
    /// </summary>
    public void MakeBold()
    {
        Content = "<b>" + Content + "</b>";
    }
}