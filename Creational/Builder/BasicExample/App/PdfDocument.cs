using System;

namespace Builder.BasicExample.App;

/// <summary>
/// Represents a PDF document that can be constructed by adding pages.
/// </summary>
public class PdfDocument
{
    /// <summary>
    /// Adds a page to the PDF document.
    /// </summary>
    /// <param name="text">The text content of the page.</param>
    public void AddPage(string text)
    {
        Console.WriteLine($"Adding a page to the PDF: {text}");
    }
}