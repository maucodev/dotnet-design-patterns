using System;
using Prototype.BasicExample;
using Prototype.VideoEditorExample;
using ContextMenu = Prototype.BasicExample.ContextMenu;

namespace Prototype
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var circleOne = new Circle(5);
            var contextMenu = new ContextMenu();

            circleOne.Render();
            
            contextMenu.Duplicate(circleOne);

            Console.ReadLine();

            //
            // Video Editor Example
            //

            var timeline = new Timeline();
            var text = new TextComponent("Hello");
            var menu = new VideoEditorExample.ContextMenu(timeline);

            timeline.Add(text);

            menu.Duplicate(text);

            Console.WriteLine(timeline.ToString());

            Console.ReadLine();
        }
    }
}
