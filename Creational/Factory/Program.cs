using System;
using Factory.BasicExample;

namespace Factory
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            new ProductsController().ListProducts();

            Console.ReadLine();
        }
    }
}
