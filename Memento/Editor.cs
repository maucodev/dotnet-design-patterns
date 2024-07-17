namespace Memento;

/// <summary>
/// The 'Originator' class, which creates a memento containing a snapshot of its current state 
/// and uses the memento to restore its state.
/// </summary>
public class Editor
{
    /// <summary>
    /// Gets or sets the content of the editor.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Creates a new memento containing the current state of the editor.
    /// </summary>
    /// <returns>A <see cref="EditorState"/> representing the current state.</returns>
    public EditorState CreateState()
    {
        return new EditorState(Content);
    }

    /// <summary>
    /// Restores the editor's state from the specified memento.
    /// </summary>
    /// <param name="state">The <see cref="EditorState"/> to restore.</param>
    public void Restore(EditorState state)
    {
        Content = state.Content;
    }
}