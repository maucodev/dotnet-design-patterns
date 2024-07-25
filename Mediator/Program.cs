using System;
using Mediator.SignUpDialogExample.Application;
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

            //
            // SignUp Dialog Example
            //

            var signUpDialog = new SignUpDialogBox();

            signUpDialog.SimulateUserInteraction();

            Console.ReadLine();
        }
    }
}
