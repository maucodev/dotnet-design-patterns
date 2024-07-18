using System;

namespace State.CanvasExample.Tools;

/// <summary>
/// Represents the tool for brush operations.
/// </summary>
public class BrushTool : ITool
{
    /// <inheritdoc/>
    public void MouseDown()
    {
        Console.WriteLine("Brush icon");
    }

    /// <inheritdoc/>
    public void MouseUp()
    {
        Console.WriteLine("Draw a line");
    }
}