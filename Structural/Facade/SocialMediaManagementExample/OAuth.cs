namespace Facade.SocialMediaManagementExample;

/// <summary>
/// Provides OAuth authentication functionality.
/// </summary>
public class OAuth
{
    /// <summary>
    /// Requests a token using the application's key and secret.
    /// </summary>
    /// <param name="appKey">The application key.</param>
    /// <param name="appSecret">The application secret.</param>
    /// <returns>The request token.</returns>
    public string RequestToken(string appKey, string appSecret)
    {
        return "Request Token";
    }

    /// <summary>
    /// Obtains an access token using the request token.
    /// </summary>
    /// <param name="requestToken">The request token.</param>
    /// <returns>The access token.</returns>
    public string GetAccessToken(string requestToken)
    {
        return "Access Token";
    }
}