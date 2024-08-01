namespace Decorator.EditorExample;

/// <summary>
/// Represents a basic artefact in a project.
/// </summary>
public class Artefact : AbstractArtefact
{
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of the <see cref="Artefact"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the artefact.</param>
    public Artefact(string name)
    {
        _name = name;
    }

    /// <inheritdoc />
    public override string Render()
    {
        return _name;
    }
}