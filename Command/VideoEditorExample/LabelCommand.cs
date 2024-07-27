namespace Command.VideoEditorExample;

/// <summary>
/// Command to change the label of a video.
/// </summary>
public class LabelCommand : IUndoableCommand
{
    private string _prevLabel;
    private readonly Video _video;
    private readonly VideoHistory _history;

    /// <summary>
    /// Initializes a new instance of the <see cref="LabelCommand"/> class.
    /// </summary>
    /// <param name="video">The video to change the label for.</param>
    /// <param name="history">The history to store the command.</param>
    public LabelCommand(Video video, VideoHistory history)
    {
        _video = video;
        _history = history;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        _prevLabel = _video.Label;
        _video.Label = "Testing video";
        _history.Push(this);
    }

    /// <inheritdoc/>
    public void UnExecute()
    {
        _video.Label = _prevLabel;
    }
}