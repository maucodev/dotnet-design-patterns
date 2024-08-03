using System;
using Flyweight.MapsExample;
using Flyweight.SpreadsheetExample;

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

            //
            // Spreadsheet Example
            //

            var contextFactory = new CellContextFactory();
            var sheet = new SpreadSheet(contextFactory);

            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            
            sheet.Render();

            Console.ReadLine();
        }
    }
}
