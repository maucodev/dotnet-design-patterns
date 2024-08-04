using System.Collections.Generic;
using System.Text;

namespace Prototype.VideoEditorExample;

/// <summary>
/// Represents a timeline that can contain multiple components.
/// </summary>
public class Timeline
{
    private readonly List<IComponent> _components = [];

    /// <summary>
    /// Adds a component to the timeline.
    /// </summary>
    /// <param name="component">The component to add.</param>
    public void Add(IComponent component)
    {
        _components.Add(component);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        var result = new StringBuilder();

        foreach (var component in _components)
        {
            result.Append(component);
            result.AppendLine();
        }

        return result.ToString();
    }
}