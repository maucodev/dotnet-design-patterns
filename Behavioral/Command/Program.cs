using System;
using Command.CompositeCommandsExample;
using Command.CustomerExample.Framework;
using Command.CustomerExample.Implementation;
using Command.UndoableCommandsExample;
using Command.VideoEditorExample;

namespace Command
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Customer Example
            //

            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command)
            {
                Label = "Add customer"
            };

            button.Click();

            Console.ReadLine();

            //
            // Composite Command Example
            //

            var composite = new CompositeCommand();

            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();

            Console.ReadLine();

            //
            // Undoable Command Example
            //

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

            //
            // Video Editor Example
            //

            var videoHistory = new VideoHistory();
            var video = new Video();
            var labelCommand = new LabelCommand(video, videoHistory);
            var contrastCommand = new ContrastCommand(video, videoHistory);

            labelCommand.Execute();
            contrastCommand.Execute();
            Console.WriteLine(video);
            labelCommand.UnExecute();
            contrastCommand.UnExecute();
            Console.WriteLine(video);

            Console.ReadLine();
        }
    }
}
