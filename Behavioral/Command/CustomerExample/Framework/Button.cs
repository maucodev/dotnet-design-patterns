namespace Command.CustomerExample.Framework;

/// <summary>
/// Represents a button that acts as an invoker in the Command Pattern.
/// </summary>
public class Button
{
    private readonly ICommand _command;

    /// <summary>
    /// Gets or sets the label of the button.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Button"/> class with the specified command.
    /// </summary>
    /// <param name="command">The command to be executed when the button is clicked.</param>
    public Button(ICommand command)
    {
        _command = command;
    }

    /// <summary>
    /// Simulates a button click, causing the command to be executed.
    /// </summary>
    public void Click()
    {
        _command.Execute();
    }
}