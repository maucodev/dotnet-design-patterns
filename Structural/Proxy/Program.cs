using System;
using Proxy.EbookExample;

namespace Proxy
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // RealEbook Example
            //

            var library = new Library();
            string[] fileNames = ["a", "b", "c"];

            foreach (var fileName in fileNames)
            {
                library.Add(new LoggingEbookProxy(fileName));
            }

            library.Open("a");
            library.Open("b");
            library.Open("b");

            Console.ReadLine();
        }
    }
}
