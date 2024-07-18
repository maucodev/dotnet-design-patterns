using System;
using State.CanvasExample;
using State.CanvasExample.Tools;

namespace State
{
    internal static class Program
    {
        private static void Main()
        {
            var canvas = new Canvas();

            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            Console.WriteLine();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();

            Console.WriteLine();

            canvas.CurrentTool = new EraserTool();
            canvas.MouseDown();
            canvas.MouseUp();

            Console.ReadLine();
        }
    }
}