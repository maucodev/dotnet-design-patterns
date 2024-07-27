using System;

namespace Memento
{
    internal static class Program
    {
        private static void Main()
        {
            var document = new Document();
            var history = new History();

            document.Content = "Title";
            history.Push(document.CreateState());

            document.FontName = "Aptos Display";
            history.Push(document.CreateState());

            document.FontSize = 14;
            history.Push(document.CreateState());

            Console.WriteLine("\nCurrent document...");
            Console.WriteLine(document);

            document.Restore(history.Pop());
            document.Restore(history.Pop());

            Console.WriteLine("\nUndo document...");
            Console.WriteLine(document);

            document.Restore(history.Pop());

            Console.WriteLine("\nUndo document...");
            Console.WriteLine(document);

            Console.ReadLine();
        }
    }
}
