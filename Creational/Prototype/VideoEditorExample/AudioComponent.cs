namespace Prototype.VideoEditorExample;

/// <summary>
/// Represents an audio component that implements the <see cref="IComponent"/> interface.
/// </summary>
public class AudioComponent : IComponent
{
    /// <inheritdoc />
    public IComponent Clone()
    {
        return new AudioComponent();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return "Audio";
    }
}