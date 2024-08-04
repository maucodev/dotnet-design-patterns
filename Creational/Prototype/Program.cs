using System;
using Prototype.BasicExample;

namespace Prototype
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var circleOne = new Circle(5);
            var circleTwo = circleOne.Clone();

            circleOne.Render();
            circleTwo.Render();

            Console.ReadLine();
        }
    }
}
