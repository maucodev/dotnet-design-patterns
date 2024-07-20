using System;
using Command.CustomerExample.Framework;
using Command.CustomerExample.Implementation;

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
        }
    }
}
