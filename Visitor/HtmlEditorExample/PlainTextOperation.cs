using System;

namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents a specific operation that extracts plain text from HTML nodes.
/// </summary>
public class PlainTextOperation : IOperation
{
    /// <inheritdoc />
    public void Apply(HeadingNode heading)
    {
        Console.WriteLine("Text from heading");
    }

    /// <inheritdoc />
    public void Apply(AnchorNode anchor)
    {
        Console.WriteLine("Text from anchor");
    }
}