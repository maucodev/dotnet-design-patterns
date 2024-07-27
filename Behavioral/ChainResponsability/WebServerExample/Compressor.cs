using System;

namespace ChainResponsibility.WebServerExample;

/// <summary>
/// A handler that performs compression.
/// </summary>
public class Compressor : Handler
{
    /// <inheritdoc />
    public Compressor(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Compress");
        return false;
    }
}