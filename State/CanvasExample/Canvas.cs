namespace State.CanvasExample;

/// <summary>
/// Represents the canvas that uses various tools for drawing.
/// </summary>
public class Canvas
{
    /// <summary>
    /// Gets or sets the current tool used on the canvas.
    /// </summary>
    public ITool CurrentTool { get; set; }

    /// <summary>
    /// Invokes the MouseDown method of the current tool.
    /// </summary>
    public void MouseDown()
    {
        CurrentTool.MouseDown();
    }

    /// <summary>
    /// Invokes the MouseUp method of the current tool.
    /// </summary>
    public void MouseUp()
    {
        CurrentTool.MouseUp();
    }
}