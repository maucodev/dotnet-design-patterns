using System;

namespace TemplateMethod.WindowExample;

/// <summary>
/// Represents an abstract window with a template method for closing the window.
/// </summary>
public abstract class Window
{
    /// <summary>
    /// Closes the window by invoking the closing and closed actions.
    /// </summary>
    public void Close()
    {
        OnClosing();

        Console.WriteLine("Removing the window from the screen");

        OnClosed();
    }

    /// <summary>
    /// Executes actions when the window is closing. Must be implemented by derived classes.
    /// </summary>
    protected abstract void OnClosing();

    /// <summary>
    /// Executes actions when the window has closed. Must be implemented by derived classes.
    /// </summary>
    protected abstract void OnClosed();
}