using System;

namespace State.CanvasExample.Tools;

/// <summary>
/// Represents the tool for erasing operations.
/// </summary>
public class EraserTool : ITool
{
    /// <inheritdoc/>
    public void MouseDown()
    {
        Console.WriteLine("Eraser icon");
    }

    /// <inheritdoc/>
    public void MouseUp()
    {
        Console.WriteLine("Erase something");
    }
}