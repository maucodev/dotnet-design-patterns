namespace ChainResponsibility.WebServerExample;

/// <summary>
/// Represents a handler in the chain of responsibility.
/// </summary>
public abstract class Handler
{
    /// <summary>
    /// Gets the next handler in the chain.
    /// </summary>
    private Handler Next { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Handler"/> class.
    /// </summary>
    /// <param name="next">The next handler in the chain.</param>
    protected Handler(Handler next)
    {
        Next = next;
    }

    /// <summary>
    /// Handles the given HTTP request.
    /// </summary>
    /// <param name="request">The HTTP request to handle.</param>
    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
        {
            return;
        }

        Next?.Handle(request);
    }

    /// <summary>
    /// Defines the specific handling logic in the derived classes.
    /// </summary>
    /// <param name="request">The HTTP request to process.</param>
    /// <returns>True if the request was handled; otherwise, false.</returns>
    protected abstract bool DoHandle(HttpRequest request);
}