namespace ChainResponsibility.AccountingAppExample;

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
    /// Handles the filename.
    /// </summary>
    /// <param name="filename">The filename to handle.</param>
    public void Handle(string filename)
    {
        if (DoHandle(filename))
        {
            return;
        }

        Next?.Handle(filename);
    }

    /// <summary>
    /// Defines the specific handling logic in the derived classes.
    /// </summary>
    /// <param name="filename">The filename to handle.</param>
    /// <returns>True if the request was handled; otherwise, false.</returns>
    protected abstract bool DoHandle(string filename);
}