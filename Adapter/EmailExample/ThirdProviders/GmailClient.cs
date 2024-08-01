using System;

namespace Adapter.EmailExample.ThirdProviders;

/// <summary>
/// Represents a client for interacting with Gmail.
/// </summary>
public class GmailClient
{
    /// <summary>
    /// Connects to the Gmail server.
    /// </summary>
    public void Connect()
    {
        Console.WriteLine("Connecting to Gmail");
    }

    /// <summary>
    /// Retrieves emails from Gmail.
    /// </summary>
    public void GetEmails()
    {
        Console.WriteLine("Downloading emails from Gmail");
    }

    /// <summary>
    /// Disconnects from the Gmail server.
    /// </summary>
    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from Gmail");
    }
}