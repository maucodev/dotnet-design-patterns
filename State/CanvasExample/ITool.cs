namespace State.CanvasExample;

public interface ITool
{
    /// <summary>
    /// Executes the action to be performed when the mouse button is pressed down.
    /// </summary>
    public void MouseDown();

    /// <summary>
    /// Executes the action to be performed when the mouse button is released.
    /// </summary>
    public void MouseUp();
}