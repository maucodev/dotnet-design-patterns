using Builder.BasicExample.Abstractions;
using Builder.BasicExample.App;

namespace Builder.BasicExample.Builders;

/// <summary>
/// A builder that constructs a PDF document from presentation slides.
/// </summary>
public class PdfDocumentBuilder : IPresentationBuilder
{
    private readonly PdfDocument _document = new();

    /// <inheritdoc />
    public void AddSlide(Slide slide)
    {
        _document.AddPage(slide.Text);
    }

    /// <summary>
    /// Gets the constructed PDF document.
    /// </summary>
    /// <returns>The constructed <see cref="PdfDocument"/>.</returns>
    public PdfDocument GetPdfDocument()
    {
        return _document;
    }
}