using System;
using Facade.BasicExample;

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
        }
    }
}
