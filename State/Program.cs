using System;
using State.CanvasExample;
using State.CanvasExample.Tools;
using State.DirectionExample;
using State.DirectionExample.TravelModes;

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

            Console.Clear();

            var directionService = new DirectionService();

            directionService.TravelMode = new BicyclingTravelModel();
            directionService.GetEta();
            directionService.GetDirection();

            Console.ReadLine();
        }
    }
}