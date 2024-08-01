namespace Adapter.EmailExample;

/// <summary>
/// Interface representing an email provider that can download emails.
/// </summary>
public interface IEmailProvider
{
    /// <summary>
    /// Downloads emails from the provider.
    /// </summary>
    public void DownloadEmails();
}