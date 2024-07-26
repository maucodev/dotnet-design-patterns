using System;

namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents a specific operation that highlights HTML nodes.
/// </summary>
public class HighlightOperation : IOperation
{
    /// <inheritdoc />
    public void Apply(HeadingNode heading)
    {
        Console.WriteLine("Highlight heading");
    }

    /// <inheritdoc />
    public void Apply(AnchorNode anchor)
    {
        Console.WriteLine("Highlight anchor");
    }
}