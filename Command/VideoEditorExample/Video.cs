namespace Command.VideoEditorExample;

/// <summary>
/// Represents a video with a label and contrast level.
/// </summary>
public class Video
{
    /// <summary>
    /// Gets or sets the label of the video.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Gets or sets the contrast level of the video.
    /// </summary>
    public float Contrast { get; set; }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"{Label ?? "NO TAG"} --> {Contrast}";
    }
}