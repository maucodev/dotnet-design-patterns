namespace Visitor.HtmlEditorExample;

/// <summary>
/// Represents an operation that can be applied to HTML nodes.
/// </summary>
public interface IOperation
{
    /// <summary>
    /// Applies the operation to a <see cref="HeadingNode"/>.
    /// </summary>
    /// <param name="heading">The heading node to which the operation is applied.</param>
    public void Apply(HeadingNode heading);

    /// <summary>
    /// Applies the operation to a <see cref="AnchorNode"/>.
    /// </summary>
    /// <param name="anchor">The anchor node to which the operation is applied.</param>
    public void Apply(AnchorNode anchor);
}