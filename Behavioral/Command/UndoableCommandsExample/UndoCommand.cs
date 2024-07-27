namespace Command.UndoableCommandsExample;

/// <summary>
/// Command for undoing the last executed command.
/// </summary>
public class UndoCommand : ICommand
{
    private readonly History _history;

    /// <summary>
    /// Initializes a new instance of the <see cref="UndoCommand"/> class.
    /// </summary>
    /// <param name="history">The history of undoable commands.</param>
    public UndoCommand(History history)
    {
        _history = history;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        if (_history.Size > 0)
        {
            _history.Pop().UnExecute();
        }
    }
}