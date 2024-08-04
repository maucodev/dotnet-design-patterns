using System;

namespace Prototype.BasicExample;

/// <summary>
/// Represents a context menu.
/// </summary>
public class ContextMenu
{
    /// <summary>
    /// Duplicates the specified component by creating a clone of it.
    /// </summary>
    /// <param name="component">The component to duplicate.</param>
    public void Duplicate(IComponent component)
    {
        Console.WriteLine("Duplicating a component");

        _ = component.Clone();
    }
}