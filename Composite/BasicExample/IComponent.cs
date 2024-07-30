namespace Composite.BasicExample;

/// <summary>
/// Defines the basic contract for a component.
/// </summary>
public interface IComponent
{
    /// <summary>
    /// Renders the component.
    /// </summary>
    void Render();

    /// <summary>
    /// Moves the component.
    /// </summary>
    void Move();
}