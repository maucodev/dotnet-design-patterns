namespace Decorator.BasicExample;

/// <summary>
/// Decorator class that encrypts data before writing it to the underlying stream.
/// </summary>
public class EncryptedCloudStream : IStream
{
    private readonly IStream _stream;

    /// <summary>
    /// Initializes a new instance of the <see cref="EncryptedCloudStream"/> class with the specified stream.
    /// </summary>
    /// <param name="stream">The underlying stream to decorate.</param>
    public EncryptedCloudStream(IStream stream)
    {
        _stream = stream;
    }

    /// <inheritdoc />
    public void Write(string data)
    {
        var encrypted = Encrypt(data);
        _stream.Write(encrypted);
    }

    /// <summary>
    /// Encrypts the data.
    /// </summary>
    /// <param name="data">The data to be encrypted.</param>
    /// <returns>The encrypted data.</returns>
    private string Encrypt(string data)
    {
        return $"***{data}***";
    }
}