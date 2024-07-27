namespace Visitor.AudioEditorExample;

/// <summary>
/// Represents a noise reduction filter for audio processing.
/// </summary>
public class NoiseReductionFilter : IFilter
{
    /// <summary>
    /// Gets the name of the filter.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NoiseReductionFilter"/> class.
    /// </summary>
    public NoiseReductionFilter()
    {
        Name = "NoiseReductionFilter";
    }
}