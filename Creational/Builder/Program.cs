using System;
using Builder.BasicExample.App;
using Builder.BasicExample.Builders;
using Builder.WordProcessor.App;
using Builder.WordProcessor.Builders;

namespace Builder
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            var presentation = new Presentation();
            var pdfBuilder = new PdfDocumentBuilder();
            var movieBuilder = new MovieBuilder();

            presentation.AddSlide(new Slide("SlideOne"));
            presentation.AddSlide(new Slide("SlideTwo"));

            presentation.Export(pdfBuilder);
            _ = pdfBuilder.GetPdfDocument();

            presentation.Export(movieBuilder);
            _ = movieBuilder.GetMovie();

            Console.ReadLine();

            //
            // Word Processor Example
            //

            var document = new Document();

            document.Add(new Text("Hello"));
            document.Add(new Image("icon.png"));

            document.Export(new HtmlDocumentBuilder(), "page.html");

            document.Export(new TextDocumentBuilder(), "plain.txt");

            Console.ReadLine();
        }
    }
}
