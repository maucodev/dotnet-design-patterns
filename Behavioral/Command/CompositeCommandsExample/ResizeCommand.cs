using System;

namespace Command.CompositeCommandsExample;

/// <summary>
/// Represents a command for resizing, implementing the ICommand interface.
/// </summary>
public class ResizeCommand : ICommand
{
    /// <inheritdoc/>
    public void Execute()
    {
        Console.WriteLine("Resize");
    }
}