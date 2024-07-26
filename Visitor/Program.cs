using System;
using Visitor.HtmlEditorExample;

namespace Visitor
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // HTML Editor Example
            //

            var document = new HtmlDocument();

            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighlightOperation());

            document.Execute(new PlainTextOperation());

            Console.ReadLine();
        }
    }
}
