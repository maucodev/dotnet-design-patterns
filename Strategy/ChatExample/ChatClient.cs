using Strategy.ChatExample.EncryptionAlgorithms;

namespace Strategy.ChatExample;

/// <summary>
/// Represents a chat client that uses an encryption algorithm to send messages.
/// </summary>
public class ChatClient
{
    private readonly IEncryptionAlgorithm _encryptionAlgorithm;

    /// <summary>
    /// Initializes a new instance of the ChatClient class.
    /// </summary>
    /// <param name="encryptionAlgorithm"><see cref="IEncryptionAlgorithm"/>.</param>
    public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
    {
        _encryptionAlgorithm = encryptionAlgorithm;
    }

    /// <summary>
    /// Sends a message using the specified encryption algorithm.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        _encryptionAlgorithm.Encrypt(message);
    }
}