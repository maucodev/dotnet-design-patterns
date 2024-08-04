namespace Prototype.BasicExample;

/// <summary>
/// Represents a component.
/// </summary>
public interface IComponent
{
    /// <summary>
    /// Renders the component.
    /// </summary>
    public void Render();

    /// <summary>
    /// Clones the component.
    /// </summary>
    /// <returns>A new instance of <see cref="IComponent"/> that is a copy of the current instance.</returns>
    public IComponent Clone();
}