using System;
using Factory.BasicExample;
using Factory.SchedulerExample.Event;
using Factory.SchedulerExample.Scheduler;

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

            //
            // Scheduler Example
            //

            var gregorianScheduler = new Scheduler();
            var arabianScheduler = new ArabianScheduler();

            gregorianScheduler.Schedule(new Event());
            arabianScheduler.Schedule(new Event());

            Console.ReadLine();
        }
    }
}
