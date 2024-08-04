namespace Prototype.VideoEditorExample;

/// <summary>
/// Represents a clip component that implements the <see cref="IComponent"/> interface.
/// </summary>
public class ClipComponent : IComponent
{
    /// <inheritdoc />
    public IComponent Clone()
    {
        return new ClipComponent();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "Clip";
    }
}