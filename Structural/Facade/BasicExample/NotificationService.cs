namespace Facade.BasicExample;

/// <summary>
/// Facade for sending notifications.
/// </summary>
public class NotificationService
{
    /// <summary>
    /// Sends a notification message to a specified target.
    /// </summary>
    /// <param name="message">The message to be sent.</param>
    /// <param name="target">The target recipient of the message.</param>
    public void Send(string message, string target)
    {
        var server = new NotificationServer();
        var connection = server.Connect("127.0.0.1");
        var authToken = server.Authenticate("appId", "private-key");

        server.Send(authToken, new Message(message), target);

        connection.Disconnect();
    }
}