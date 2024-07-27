using System.Collections.Generic;

namespace Command.UndoableCommandsExample;

/// <summary>
/// Manages a history of undoable commands.
/// </summary>
public class History
{
    private readonly Queue<IUndoableCommand> _undoableCommands = [];

    /// <summary>
    /// Gets the number of undoable commands in the history.
    /// </summary>
    public int Size => _undoableCommands.Count;

    /// <summary>
    /// Adds a command to the history.
    /// </summary>
    /// <param name="command">The command to add.</param>
    public void Push(IUndoableCommand command)
    {
        _undoableCommands.Enqueue(command);
    }

    /// <summary>
    /// Removes and returns the oldest command from the history.
    /// </summary>
    /// <returns>The oldest command.</returns>
    public IUndoableCommand Pop()
    {
        return _undoableCommands.Dequeue();
    }
}