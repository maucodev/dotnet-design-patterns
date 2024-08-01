namespace Decorator.EditorExample;

/// <summary>
/// Decorator class that adds an "Error" label to the artefact.
/// </summary>
public class ErrorDecorator : AbstractArtefact
{
    private readonly AbstractArtefact _artefact;

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorDecorator"/> class with the specified artefact.
    /// </summary>
    /// <param name="artefact">The artefact to decorate.</param>
    public ErrorDecorator(AbstractArtefact artefact)
    {
        _artefact = artefact;
    }

    /// <inheritdoc />
    public override string Render()
    {
        return $"{_artefact.Render()} [Error]";
    }
}