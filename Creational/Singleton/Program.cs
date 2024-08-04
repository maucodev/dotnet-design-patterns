using System;
using Singleton.BasicExample;
using Singleton.LoggerExample;

namespace Singleton
{
    internal abstract class Program
    {
        public static void Main()
        {
            //
            // Basic Example
            //

            var configManager = ConfigManager.Instance;

            configManager.Set("maintenance", true);

            Console.WriteLine(configManager.Get("maintenance").ToString());

            Console.ReadLine();

            //
            // Logger Example
            //

            var loggerOne = Logger.GetInstance("fileOne.txt");
            var loggerTwo = Logger.GetInstance("fileOne.txt");
            var loggerThree = Logger.GetInstance("fileThree.txt");

            Console.WriteLine(loggerOne == loggerTwo);

            Console.WriteLine(loggerOne == loggerThree);

            Console.ReadLine();
        }
    }
}
