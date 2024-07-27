namespace ChainResponsibility.WebServerExample;

/// <summary>
/// Represents a web server that processes HTTP requests using a chain of handlers.
/// </summary>
public class WebServer
{
    /// <summary>
    /// Gets the initial handler in the chain.
    /// </summary>
    private Handler Handler { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebServer"/> class.
    /// </summary>
    /// <param name="handler">The initial handler in the chain.</param>
    public WebServer(Handler handler)
    {
        Handler = handler;
    }

    /// <summary>
    /// Processes the given HTTP request using the chain of handlers.
    /// </summary>
    /// <param name="request">The HTTP request to process.</param>
    public void Handle(HttpRequest request)
    {
        Handler.Handle(request);
    }
}