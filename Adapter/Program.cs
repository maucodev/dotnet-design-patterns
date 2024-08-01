using System;
using Adapter.BasicExample;
using Adapter.BasicExample.ThirdFilters;

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
        }
    }
}
