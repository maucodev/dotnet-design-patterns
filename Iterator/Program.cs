using System;
using Iterator.BrowseExample;
using Iterator.ProductsExample;

namespace Iterator
{
    internal static class Program
    {
        private static void Main()
        {
            var history = new BrowseHistory();

            history.Push("a");
            history.Push("b");
            history.Push("c");

            var historyIterator = history.CreateIterator();

            while (historyIterator.HasNext())
            {
                Console.WriteLine(historyIterator.Current());
                historyIterator.Next();
            }

            var products = new ProductCollection();

            products.Add(new Product(1, "iPhone"));
            products.Add(new Product(2, "Galaxy"));
            products.Add(new Product(3, "MAGIC"));

            var productsIterator = products.CreateIterator();

            while (productsIterator.HasNext())
            {
                Console.WriteLine(productsIterator.Current());
                productsIterator.Next();
            }

            Console.ReadLine();
        }
    }
}
