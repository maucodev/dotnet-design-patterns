namespace Command.CustomerExample.Framework;

/// <summary>
/// Defines a command interface with an Execute method.
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Executes the command.
    /// </summary>
    public void Execute();
}