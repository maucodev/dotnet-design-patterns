namespace Command;

/// <summary>
/// Represents a command that can be executed and undone.
/// </summary>
public interface IUndoableCommand : ICommand
{
    /// <summary>
    /// Undoes the command.
    /// </summary>
    public void UnExecute();
}