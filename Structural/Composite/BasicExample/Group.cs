using System.Collections.Generic;

namespace Composite.BasicExample;

/// <summary>
/// Represents a group of components that can be managed together.
/// </summary>
public class Group : IComponent
{
    private readonly List<IComponent> _components = [];

    /// <summary>
    /// Adds a component to the group.
    /// </summary>
    /// <param name="component">The component to add.</param>
    public void Add(IComponent component)
    {
        _components.Add(component);
    }

    /// <inheritdoc />
    public void Render()
    {
        foreach (var component in _components)
        {
            component.Render();
        }
    }

    /// <inheritdoc />
    public void Move()
    {
        foreach (var component in _components)
        {
            component.Move();
        }
    }
}