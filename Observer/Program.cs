using System;
using Observer.SpreadSheetsExample;

namespace Observer
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // SpreadSheets
            //

            var dataSource = new DataSource();
            var sheetOne = new SpreadSheet();
            var sheetTwo = new SpreadSheet();
            var chart = new Chart();

            dataSource.AddObserver(sheetOne);
            dataSource.AddObserver(sheetTwo);
            dataSource.AddObserver(chart);

            dataSource.Value = 1250;

            Console.ReadLine();
        }
    }
}
