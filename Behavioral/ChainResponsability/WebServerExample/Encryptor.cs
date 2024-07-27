using System;

namespace ChainResponsibility.WebServerExample;

/// <summary>
/// A handler that performs encryption.
/// </summary>
public class Encryptor : Handler
{
    /// <inheritdoc />
    public Encryptor(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Encryption");
        return false;
    }
}