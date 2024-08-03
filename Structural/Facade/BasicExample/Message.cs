namespace Facade.BasicExample;

/// <summary>
/// Represents a message to be sent via the notification server.
/// </summary>
public class Message
{
    /// <summary>
    /// Gets the content of the message.
    /// </summary>
    public string Content { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Message"/> class.
    /// </summary>
    /// <param name="content">The content of the message.</param>
    public Message(string content)
    {
        Content = content;
    }
}