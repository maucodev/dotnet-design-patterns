namespace Decorator.EditorExample;

/// <summary>
/// Decorator class that adds a "Main" label to the artefact.
/// </summary>
public class MainDecorator : AbstractArtefact
{
    private readonly AbstractArtefact _artefact;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainDecorator"/> class with the specified artefact.
    /// </summary>
    /// <param name="artefact">The artefact to decorate.</param>
    public MainDecorator(AbstractArtefact artefact)
    {
        _artefact = artefact;
    }

    /// <inheritdoc />
    public override string Render()
    {
        return $"{_artefact.Render()} [Main]";
    }
}