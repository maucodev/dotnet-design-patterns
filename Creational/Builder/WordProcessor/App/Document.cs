using System;
using System.Collections.Generic;
using Builder.WordProcessor.Abstractions;

namespace Builder.WordProcessor.App;

/// <summary>
/// Represents a document composed of various elements.
/// </summary>
public class Document
{
    private readonly List<IElement> _elements = [];

    /// <summary>
    /// Adds an element to the document.
    /// </summary>
    /// <param name="element">The element to add.</param>
    public void Add(IElement element)
    {
        _elements.Add(element);
    }

    /// <summary>
    /// Exports the document using the specified document builder.
    /// </summary>
    /// <param name="builder">The builder responsible for exporting the document elements.</param>
    /// <param name="filename">The name of the file to export.</param>
    public void Export(IDocumentBuilder builder, string filename)
    {
        foreach (var element in _elements)
        {
            switch (element)
            {
                case Text text:
                    builder.AddText(text);
                    break;
                case Image image:
                    builder.AddImage(image);
                    break;
            }
        }

        Console.WriteLine($"Exporting to {filename}: {builder.GetResult()}");
    }
}