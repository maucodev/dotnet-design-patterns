using System;

namespace Facade.BasicExample;

/// <summary>
/// Represents a notification server.
/// </summary>
public class NotificationServer
{
    /// <summary>
    /// Connects to the notification server.
    /// </summary>
    /// <param name="ipAddress">The IP address of the server.</param>
    /// <returns>A new <see cref="Connection"/> object.</returns>
    public Connection Connect(string ipAddress)
    {
        Console.WriteLine($"Connecting to {ipAddress}");

        return new Connection();
    }

    /// <summary>
    /// Authenticates with the notification server.
    /// </summary>
    /// <param name="appId">The application ID.</param>
    /// <param name="key">The private key.</param>
    /// <returns>A new <see cref="AuthToken"/> object.</returns>
    public AuthToken Authenticate(string appId, string key)
    {
        Console.WriteLine($"Authenticating {appId} - {key}");

        return new AuthToken();
    }

    /// <summary>
    /// Sends a message to a specified target.
    /// </summary>
    /// <param name="authToken">The authentication token.</param>
    /// <param name="message">The message to be sent.</param>
    /// <param name="target">The target recipient of the message.</param>
    public void Send(AuthToken authToken, Message message, string target)
    {
        Console.WriteLine($"Sending message: {authToken} - {message.Content} - {target}");
    }
}