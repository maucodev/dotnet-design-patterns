using System;
using Mediator.UIExample.Application;

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
        }
    }
}
