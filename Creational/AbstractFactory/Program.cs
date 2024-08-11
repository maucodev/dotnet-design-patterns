using System;
using AbstractFactory.BasicExample.Ant;
using AbstractFactory.BasicExample.App;
using AbstractFactory.BasicExample.MaterialDesign;
using AbstractFactory.WeightLossApp.App;
using AbstractFactory.WeightLossApp.BuildMusclePlan;
using AbstractFactory.WeightLossApp.WeightLossPlan;

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

            //
            // Weight Loss App Example
            //

            var homePage = new HomePage();

            homePage.SetGoal(new WeightLossFactory());

            homePage.SetGoal(new BuildMuscleFactory());

            Console.ReadLine();
        }
    }
}
