namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents a node in an HTML document.
/// </summary>
public interface IHtmlNode
{
    /// <summary>
    /// Executes an operation on the HTML node.
    /// </summary>
    /// <param name="operation">The operation to execute on the node.</param>
    public void Execute(IOperation operation);
}