using System;
using AbstractFactory.BasicExample.Ant;
using AbstractFactory.BasicExample.App;
using AbstractFactory.BasicExample.MaterialDesign;

namespace AbstractFactory
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            new ContactForm().Render(new MaterialWidgetFactory());

            new ContactForm().Render(new AntWidgetFactory());

            Console.ReadLine();
        }
    }
}
