using System;

namespace Facade.BasicExample;

/// <summary>
/// Represents a connection to the notification server.
/// </summary>
public class Connection
{
    /// <summary>
    /// Disconnects from the server.
    /// </summary>
    public void Disconnect()
    {
        Console.WriteLine("Disconnected!");
    }
}