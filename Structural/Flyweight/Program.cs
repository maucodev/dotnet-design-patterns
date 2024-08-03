using System;
using Flyweight.MapsExample;

namespace Flyweight
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Maps Example
            //

            var pointIconFactory = new PointIconFactory();
            var pointService = new PointService(pointIconFactory);

            foreach (var point in pointService.GetPoints())
            {
                point.Draw();
            }

            Console.ReadLine();
        }
    }
}
