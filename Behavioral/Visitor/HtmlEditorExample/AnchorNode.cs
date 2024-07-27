namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents an HTML anchor node.
/// </summary>
public class AnchorNode : IHtmlNode
{
    /// <inheritdoc />
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}