using System;
using Adapter.BasicExample;
using Adapter.BasicExample.ThirdFilters;
using Adapter.EmailExample;
using Adapter.EmailExample.ThirdProviders;

namespace Adapter
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var image = new Image();
            var imageView = new ImageView(image);

            imageView.Apply(new VividFilter());

            imageView.Apply(new CaramelAdapter(new Caramel()));

            Console.ReadLine();

            //
            // Email Example
            //

            var emailClient = new EmailClient();

            emailClient.AddProvider(new GmailAdapter(new GmailClient()));

            emailClient.DownloadEmails();

            Console.ReadLine();
        }
    }
}
