namespace Command.VideoEditorExample;

/// <summary>
/// Command to change the contrast level of a video.
/// </summary>
public class ContrastCommand : IUndoableCommand
{
    private float _prevContrast;
    private readonly Video _video;
    private readonly VideoHistory _history;

    /// <summary>
    /// Initializes a new instance of the <see cref="ContrastCommand"/> class.
    /// </summary>
    /// <param name="video">The video to change the contrast for.</param>
    /// <param name="history">The history to store the command.</param>
    public ContrastCommand(Video video, VideoHistory history)
    {
        _video = video;
        _history = history;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        _prevContrast = _video.Contrast;
        _video.Contrast = 120;
        _history.Push(this);
    }

    /// <inheritdoc/>
    public void UnExecute()
    {
        _video.Contrast = _prevContrast;
    }
}