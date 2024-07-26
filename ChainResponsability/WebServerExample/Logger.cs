using System;

namespace ChainResponsibility.WebServerExample;

/// <summary>
/// A handler that logs the request.
/// </summary>
public class Logger : Handler
{
    /// <inheritdoc />
    public Logger(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Log");
        return false;
    }
}