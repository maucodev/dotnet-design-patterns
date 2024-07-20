using System;
using Command.CompositeCommandsExample;
using Command.CustomerExample.Framework;
using Command.CustomerExample.Implementation;
using Command.UndoableCommandsExample;

namespace Command
{
    internal abstract class Program
    {
        private static void Main()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command)
            {
                Label = "Add customer"
            };

            button.Click();

            Console.ReadLine();

            var composite = new CompositeCommand();

            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();

            Console.ReadLine();

            var history = new History();
            var document = new HtmlDocument();
            var boldCommand = new BoldCommand(document, history);
            var undoBoldCommand = new UndoCommand(history);

            document.Content = "maucodev";

            boldCommand.Execute();

            Console.WriteLine(document.Content);

            undoBoldCommand.Execute();

            Console.WriteLine(document.Content);

            Console.ReadLine();
        }
    }
}
