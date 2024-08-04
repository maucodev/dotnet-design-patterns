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
            var contextMenu = new ContextMenu();

            circleOne.Render();
            
            contextMenu.Duplicate(circleOne);

            Console.ReadLine();

            //
            // Video Editor Example
            //

            Console.ReadLine();
        }
    }
}
