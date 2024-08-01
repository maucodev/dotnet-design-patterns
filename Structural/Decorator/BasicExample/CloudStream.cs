using System;

namespace Decorator.BasicExample;

/// <summary>
/// Represents a cloud-based stream that stores data.
/// </summary>
public class CloudStream : IStream
{
    /// <inheritdoc />
    public virtual void Write(string data)
    {
        Console.WriteLine($"Storing: {data}");
    }
}