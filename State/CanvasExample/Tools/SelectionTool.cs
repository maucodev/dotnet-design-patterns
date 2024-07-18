using System;

namespace State.CanvasExample.Tools;

/// <summary>
/// Represents the tool for selection operations.
/// </summary>
public class SelectionTool : ITool
{
    /// <inheritdoc/>
    public void MouseDown()
    {
        Console.WriteLine("Selection icon");
    }

    /// <inheritdoc/>
    public void MouseUp()
    {
        Console.WriteLine("Draw dashed rectangle");
    }
}