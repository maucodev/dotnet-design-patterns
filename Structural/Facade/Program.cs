using System;
using Facade.BasicExample;
using Facade.SocialMediaManagementExample;

namespace Facade
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var notificationService = new NotificationService();

            notificationService.Send("Hello", "iOS");

            Console.ReadLine();

            //
            // Social Media Management Example
            //

            var twitterService = new TwitterService("appKey", "appSecret");
            
            twitterService.GetRecentTweets();

            Console.ReadLine();
        }
    }
}
