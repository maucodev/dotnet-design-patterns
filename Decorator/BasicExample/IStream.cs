namespace Decorator.BasicExample;

/// <summary>
/// Interface representing a stream that can write data.
/// </summary>
public interface IStream
{
    /// <summary>
    /// Writes data to the stream.
    /// </summary>
    /// <param name="data">The data to be written to the stream.</param>
    public void Write(string data);
}