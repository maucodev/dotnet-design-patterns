namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents an HTML heading node.
/// </summary>
public class HeadingNode : IHtmlNode
{
    /// <inheritdoc />
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}