using System;
using Mediator.UIExample.Application;
using Mediator.UIObserverExample.Application;

namespace Mediator
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            //
            // UI Example
            //

            var dialog = new ArticlesDialogBox();

            dialog.SimulateUserInteraction();

            Console.ReadLine();

            //
            // UI Observer Example
            //

            var articles = new Articles();

            articles.SimulateUserInteraction();

            Console.ReadLine();
        }
    }
}
