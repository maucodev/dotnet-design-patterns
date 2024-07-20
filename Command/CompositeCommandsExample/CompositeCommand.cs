using System.Collections.Generic;

namespace Command.CompositeCommandsExample;

/// <summary>
/// Represents a composite command that can store and execute multiple commands.
/// </summary>
public class CompositeCommand : ICommand
{
    private readonly List<ICommand> _commands = [];

    /// <summary>
    /// Adds a command to the composite command.
    /// </summary>
    /// <param name="command">The command to add.</param>
    public void Add(ICommand command)
    {
        _commands.Add(command);
    }

    /// <inheritdoc/>
    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}