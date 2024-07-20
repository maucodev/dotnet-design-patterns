namespace Command.UndoableCommandsExample;

/// <summary>
/// Command for making text bold in an HTML document.
/// </summary>
public class BoldCommand : IUndoableCommand
{
    private string _prevContent;
    private readonly HtmlDocument _document;
    private readonly History _history;

    /// <summary>
    /// Initializes a new instance of the <see cref="BoldCommand"/> class.
    /// </summary>
    /// <param name="document">The HTML document to modify.</param>
    /// <param name="history">The history of undoable commands.</param>
    public BoldCommand(HtmlDocument document, History history)
    {
        this._document = document;
        this._history = history;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        _prevContent = _document.Content;
        _document.MakeBold();
        _history.Push(this);
    }

    /// <inheritdoc/>
    public void UnExecute()
    {
        _document.Content = _prevContent;
    }
}