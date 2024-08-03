using System.Collections.Generic;

namespace Facade.SocialMediaManagementExample;

/// <summary>
/// Facade for interacting with Twitter.
/// </summary>
public class TwitterService
{
    private readonly string _appKey;
    private readonly string _appSecret;

    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterService"/> class.
    /// </summary>
    /// <param name="appKey">The application key.</param>
    /// <param name="appSecret">The application secret.</param>
    public TwitterService(string appKey, string appSecret)
    {
        _appKey = appKey;
        _appSecret = appSecret;
    }

    /// <summary>
    /// Gets the recent tweets.
    /// </summary>
    /// <returns>A list of recent tweets.</returns>
    public List<Tweet> GetRecentTweets()
    {
        var twitterClient = new TwitterClient();
        var accessToken = GetAccessToken();
        var tweets = twitterClient.GetRecentTweets(accessToken);

        return tweets;
    }

    /// <summary>
    /// Obtains an access token using OAuth.
    /// </summary>
    /// <returns>The access token.</returns>
    private string GetAccessToken()
    {
        var oauth = new OAuth();
        var requestToken = oauth.RequestToken(_appKey, _appSecret);

        return oauth.GetAccessToken(requestToken);
    }
}