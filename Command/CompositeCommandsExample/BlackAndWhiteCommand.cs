using System;

namespace Command.CompositeCommandsExample;

/// <summary>
/// Represents a command for applying a black and white filter, implementing the ICommand interface.
/// </summary>
public class BlackAndWhiteCommand : ICommand
{
    /// <inheritdoc/>
    public void Execute()
    {
        Console.WriteLine("Black and White");
    }
}