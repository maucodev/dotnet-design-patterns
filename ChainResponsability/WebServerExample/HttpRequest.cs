namespace ChainResponsibility.WebServerExample;

/// <summary>
/// Represents an HTTP request with username and password.
/// </summary>
public class HttpRequest
{
    /// <summary>
    /// Gets the username associated with the request.
    /// </summary>
    public string Username { get; }

    /// <summary>
    /// Gets the password associated with the request.
    /// </summary>
    public string Password { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpRequest"/> class.
    /// </summary>
    /// <param name="username">The username for the request.</param>
    /// <param name="password">The password for the request.</param>
    public HttpRequest(string username, string password)
    {
        Username = username;
        Password = password;
    }
}