using Mediator.SignUpDialogExample.Framework;

namespace Mediator.SignUpDialogExample.Observer;

/// <summary>
/// Handles events for various UI controls in the sign-up dialog.
/// </summary>
public class ControlEventHandler : IEventHandler
{
    private readonly TextBox _usernameTextBox;
    private readonly TextBox _passwordTextBox;
    private readonly CheckBox _agreeCheckbox;
    private readonly Button _signUpButton;

    public ControlEventHandler(
        TextBox usernameTextBox, 
        TextBox passwordTextBox, 
        CheckBox agreeCheckbox, 
        Button signUpButton)
    {
        _usernameTextBox = usernameTextBox;
        _passwordTextBox = passwordTextBox;
        _agreeCheckbox = agreeCheckbox;
        _signUpButton = signUpButton;
    }

    /// <inheritdoc/>
    public void Handle()
    {
        if (string.IsNullOrEmpty(_usernameTextBox.Content) ||
            string.IsNullOrEmpty(_passwordTextBox.Content) ||
            _agreeCheckbox.IsEnabled == false)
        {
            _signUpButton.IsEnabled = false;
        }
        else
        {
            _signUpButton.IsEnabled = true;
        }
    }
}