namespace Memento;

/// <summary>
/// The 'Originator' class, which creates a memento containing a snapshot of its current state 
/// and uses the memento to restore its state.
/// </summary>
public class Document
{
    /// <summary>
    /// Gets or sets the content of the document.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Gets or sets the font name of the document.
    /// </summary>
    public string FontName { get; set; }

    /// <summary>
    /// Gets or sets the font size of the document.
    /// </summary>
    public int FontSize { get; set; }

    /// <summary>
    /// Creates a new memento containing the current state of the editor.
    /// </summary>
    /// <returns>A <see cref="DocumentState"/> representing the current state.</returns>
    public DocumentState CreateState()
    {
        return new DocumentState(Content, FontName, FontSize);
    }

    /// <summary>
    /// Restores the editor's state from the specified memento.
    /// </summary>
    /// <param name="state">The <see cref="DocumentState"/> to restore.</param>
    public void Restore(DocumentState state)
    {
        if (state is null)
        {
            return;
        }

        Content = state.Content;
        FontName = state.FontName;
        FontSize = state.FontSize;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"{Content ?? "NULL"} - {FontName ?? "NULL"} - {FontSize}";
    }
}