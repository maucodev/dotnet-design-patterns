namespace Memento;

/// <summary>
/// The 'Memento' class, which stores the state of the originator.
/// </summary>
public class EditorState(string content)
{
    /// <summary>
    /// Gets the content stored in the memento.
    /// </summary>
    public string Content { get; } = content;
}