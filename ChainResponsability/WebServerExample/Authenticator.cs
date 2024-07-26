using System;

namespace ChainResponsibility.WebServerExample;

/// <summary>
/// A handler that performs authentication.
/// </summary>
public class Authenticator : Handler
{
    /// <inheritdoc />
    public Authenticator(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Authentication");

        // We need a false value for processing next handlers
        return !(request.Username == "admin" && 
                 request.Password == "admin");
    }
}