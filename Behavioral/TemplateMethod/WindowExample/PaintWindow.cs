using System;

namespace TemplateMethod.WindowExample;

/// <summary>
/// Represents a paint window.
/// </summary>
public class PaintWindow : Window
{
    /// <inheritdoc/>
    protected override void OnClosing()
    {
        Console.WriteLine("Saving changes");
    }

    /// <inheritdoc/>
    protected override void OnClosed()
    {
        Console.WriteLine("Window closed, the changes are safety");
    }
}