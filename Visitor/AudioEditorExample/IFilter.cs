namespace Visitor.AudioEditorExample;

/// <summary>
/// Represents a generic filter that can be applied to audio segments.
/// </summary>
public interface IFilter
{
    /// <summary>
    /// Gets the name of the filter.
    /// </summary>
    string Name { get; }
}