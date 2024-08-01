namespace Decorator.EditorExample;

/// <summary>
/// Abstract base class representing an artefact in a project.
/// </summary>
public abstract class AbstractArtefact
{
    /// <summary>
    /// Renders the artefact as a string representation.
    /// </summary>
    /// <returns>A string representing the artefact.</returns>
    public abstract string Render();
}