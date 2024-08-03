using System;
using System.Collections.Generic;

namespace Facade.SocialMediaManagementExample;

/// <summary>
/// Provides functionality to interact with Twitter.
/// </summary>
public class TwitterClient
{
    /// <summary>
    /// Gets the recent tweets using the specified access token.
    /// </summary>
    /// <param name="accessToken">The access token.</param>
    /// <returns>A list of recent tweets.</returns>
    public List<Tweet> GetRecentTweets(string accessToken)
    {
        Console.WriteLine("Getting recent tweets");

        return [];
    }
}