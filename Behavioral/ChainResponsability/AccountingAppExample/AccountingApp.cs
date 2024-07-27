namespace ChainResponsibility.AccountingAppExample;

/// <summary>
/// Represents an accounting application that processes files using a chain of handlers.
/// </summary>
public class AccountingApp
{
    /// <summary>
    /// Gets the initial handler in the chain.
    /// </summary>
    private Handler Handler { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountingApp"/> class.
    /// </summary>
    /// <param name="handler">The initial handler in the chain.</param>
    public AccountingApp(Handler handler)
    {
        Handler = handler;
    }

    /// <summary>
    /// Processes the given filename using the chain of handlers.
    /// </summary>
    /// <param name="filename">The filename to process.</param>
    public void Handle(string filename)
    {
        Handler.Handle(filename);
    }
}