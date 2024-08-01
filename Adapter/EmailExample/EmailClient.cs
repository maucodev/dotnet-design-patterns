using System.Collections.Generic;

namespace Adapter.EmailExample;

/// <summary>
/// Represents an email client that can work with multiple email providers.
/// </summary>
public class EmailClient
{
    private readonly List<IEmailProvider> _providers = [];

    /// <summary>
    /// Adds an email provider to the list of providers used by the client.
    /// </summary>
    /// <param name="provider">The email provider to add.</param>
    public void AddProvider(IEmailProvider provider)
    {
        _providers.Add(provider);
    }

    /// <summary>
    /// Downloads emails from all added providers.
    /// </summary>
    public void DownloadEmails()
    {
        foreach (var emailProvider in _providers)
        {
            emailProvider.DownloadEmails();
        }
    }
}