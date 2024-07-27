namespace Mediator.UIExample.Framework;

/// <summary>
/// Represents an abstract dialog box that coordinates the interaction between various UI controls.
/// </summary>
public abstract class DialogBox
{
    /// <summary>
    /// Called when a control in the dialog box changes.
    /// Coordinates the interaction between controls based on the changed control.
    /// </summary>
    /// <param name="control">The control that has changed.</param>
    public abstract void Changed(UIControl control);
}