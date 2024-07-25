using System;
using Mediator.SignUpDialogExample.Framework;
using Mediator.SignUpDialogExample.Observer;

namespace Mediator.SignUpDialogExample.Application;

/// <summary>
/// Represents the dialog box for user sign up.
/// Manages the interaction between various UI controls using the Mediator and Observer patterns.
/// </summary>
public class SignUpDialogBox
{
    private readonly TextBox _usernameTextBox = new();
    private readonly TextBox _passwordTextBox = new();
    private readonly CheckBox _agreeCheckbox = new();
    private readonly Button _signUpButton = new();

    public SignUpDialogBox()
    {
        var controlEventHandler = new ControlEventHandler(
            _usernameTextBox,
            _passwordTextBox,
            _agreeCheckbox,
            _signUpButton);

        _usernameTextBox.AddEventHandler(controlEventHandler);
        _passwordTextBox.AddEventHandler(controlEventHandler);
        _agreeCheckbox.AddEventHandler(controlEventHandler);
    }

    /// <summary>
    /// Simulates user interaction with the dialog box.
    /// </summary>
    public void SimulateUserInteraction()
    {
        _usernameTextBox.Content = "maucodev";
        _passwordTextBox.Content = "Password";
        _agreeCheckbox.IsEnabled = true;

        Console.WriteLine($"The sign up button is: {_signUpButton.IsEnabled}");

        _usernameTextBox.Content = string.Empty;
        _passwordTextBox.Content = string.Empty;
        _agreeCheckbox.IsEnabled = false;

        Console.WriteLine($"The sign up button is: {_signUpButton.IsEnabled}");
    }
}