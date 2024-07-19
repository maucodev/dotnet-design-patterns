using System;

namespace Strategy.ChatExample.EncryptionAlgorithms;

/// <summary>
/// A concrete implementation of the IEncryptionAlgorithm interface that uses the AES algorithm.
/// </summary>
public class AesEncryptionAlgorithm : IEncryptionAlgorithm
{
    /// <inheritdoc/>
    public void Encrypt(string message)
    {
        Console.WriteLine("Encrypting using AES algorithm");
    }
}