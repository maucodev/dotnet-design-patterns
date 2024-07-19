using System;

namespace Strategy.ChatExample.EncryptionAlgorithms;

/// <summary>
/// A concrete implementation of the IEncryptionAlgorithm interface that uses the DES algorithm.
/// </summary>
public class DesEncryptionAlgorithm : IEncryptionAlgorithm
{
    /// <inheritdoc/>
    public void Encrypt(string message)
    {
        Console.WriteLine("Encrypting using DES algorithm");
    }
}