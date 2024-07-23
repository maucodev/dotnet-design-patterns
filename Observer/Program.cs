using System;
using Observer.Shared;
using Observer.SpreadSheetsExample;
using Observer.StocksExample;

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

            Console.WriteLine();

            //
            // Stocks
            //

            var stocksDataSource = new DataSource();
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            stocksDataSource.AddObserver(statusBar);
            stocksDataSource.AddObserver(stockListView);

            stocksDataSource.Value = 1452;

            Console.ReadLine();
        }
    }
}
