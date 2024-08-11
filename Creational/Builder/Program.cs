using System;
using Builder.BasicExample.App;
using Builder.BasicExample.Builders;

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
        }
    }
}
