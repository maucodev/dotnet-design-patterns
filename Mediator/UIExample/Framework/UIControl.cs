namespace Mediator.UIExample.Framework;

/// <summary>
/// Represents a generic UI control in the dialog box.
/// </summary>
public class UIControl
{
    protected readonly DialogBox Owner;

    /// <summary>
    /// Initializes a new instance of the <see cref="UIControl"/> class with the specified owner dialog box.
    /// </summary>
    /// <param name="owner">The owner dialog box.</param>
    protected UIControl(DialogBox owner)
    {
        Owner = owner;
    }
}