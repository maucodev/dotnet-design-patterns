namespace Decorator.BasicExample;

/// <summary>
/// Decorator class that compresses data before writing it to the underlying stream.
/// </summary>
public class CompressedCloudStream : IStream
{
    private readonly IStream _stream;

    /// <summary>
    /// Initializes a new instance of the <see cref="CompressedCloudStream"/> class with the specified stream.
    /// </summary>
    /// <param name="stream">The underlying stream to decorate.</param>
    public CompressedCloudStream(IStream stream)
    {
        _stream = stream;
    }

    /// <inheritdoc />
    public void Write(string data)
    {
        var compressed = Compress(data);
        _stream.Write(compressed);
    }

    /// <summary>
    /// Compresses the data.
    /// </summary>
    /// <param name="data">The data to be compressed.</param>
    /// <returns>The compressed data.</returns>
    private string Compress(string data)
    {
        return data[..5];
    }
}