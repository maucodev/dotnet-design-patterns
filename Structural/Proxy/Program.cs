using System;
using Proxy.EbookExample;
using Proxy.ObjectRelationalMapperExample;

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

            //
            // Object Relational Mapper Example
            //

            var dbContext = new DbContext();
            var productOne = dbContext.GetProduct(1);
            var productTwo = dbContext.GetProduct(2);

            productOne.SetName("Laptop");
            dbContext.SaveChanges();

            productOne.SetName("Laptop ABC");
            dbContext.SaveChanges();

            productOne.SetName("Laptop ABC");
            productOne.SetName("Laptop ABC");
            productOne.SetName("Laptop ABC");
            productTwo.SetName("Laptop ABC");
            productTwo.SetName("Laptop ABC");
            productTwo.SetName("Laptop ABC");
            dbContext.SaveChanges();

            Console.ReadLine();
        }
    }
}
