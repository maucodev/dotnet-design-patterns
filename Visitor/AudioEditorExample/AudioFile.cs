using System.Collections.Generic;

namespace Visitor.AudioEditorExample;

/// <summary>
/// Represents an audio file composed of byte segments.
/// </summary>
public class AudioFile
{
    private readonly List<byte> _segments = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioFile"/> class with predefined segments.
    /// </summary>
    public AudioFile()
    {
        _segments.AddRange([46, 75, 83]);
    }

    /// <summary>
    /// Applies the specified filter to all byte segments in the audio file.
    /// </summary>
    /// <param name="filter">The filter to apply to the byte segments.</param>
    public void ApplyFilter(IFilter filter)
    {
        foreach (var segment in _segments)
        {
            segment.Apply(filter);
        }
    }
}