using System.Collections.Generic;

namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents an HTML document composed of multiple HTML nodes.
/// </summary>
public class HtmlDocument
{
    private readonly List<IHtmlNode> _nodes = [];

    /// <summary>
    /// Adds an HTML node to the document.
    /// </summary>
    /// <param name="node">The HTML node to add.</param>
    public void Add(IHtmlNode node)
    {
        _nodes.Add(node);
    }

    /// <summary>
    /// Executes a specified operation on all nodes in the document.
    /// </summary>
    /// <param name="operation">The operation to execute.</param>
    public void Execute(IOperation operation)
    {
        foreach (var htmlNode in _nodes)
        {
            htmlNode.Execute(operation);
        }
    }
}