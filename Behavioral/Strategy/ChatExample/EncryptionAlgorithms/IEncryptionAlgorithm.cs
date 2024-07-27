namespace Strategy.ChatExample.EncryptionAlgorithms;

/// <summary>
/// Defines a method to encrypt a message.
/// </summary>
public interface IEncryptionAlgorithm
{
    /// <summary>
    /// Encrypts the specified message.
    /// </summary>
    /// <param name="message">The message to encrypt.</param>
    void Encrypt(string message);
}