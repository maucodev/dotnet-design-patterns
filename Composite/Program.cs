using System;
using Composite.BasicExample;

namespace Composite
{
    public abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var groupOne = new Group();
            var groupTwo = new Group();
            var groupThree = new Group();

            groupOne.Add(new Shape());
            groupOne.Add(new Shape());

            groupTwo.Add(new Shape());
            groupTwo.Add(new Shape());

            groupThree.Add(groupOne);
            groupThree.Add(groupTwo);
            groupThree.Render();
            groupThree.Move();
            
            Console.ReadLine();
        }
    }
}
