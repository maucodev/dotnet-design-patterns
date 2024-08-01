using Adapter.EmailExample.ThirdProviders;

namespace Adapter.EmailExample;

/// <summary>
/// Adapter class that allows a Gmail client to be used as an <see cref="IEmailProvider"/>.
/// </summary>
public class GmailAdapter : IEmailProvider
{
    private readonly GmailClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="GmailAdapter"/> class with the specified Gmail client.
    /// </summary>
    /// <param name="client">The Gmail client to adapt.</param>
    public GmailAdapter(GmailClient client)
    {
        _client = client;
    }

    /// <inheritdoc />
    public void DownloadEmails()
    {
        _client.Connect();
        _client.GetEmails();
        _client.Disconnect();
    }
}