# Mediator Pattern

1. [Summary](#summary)
2. [Components](#components)
3. [Overview](#overview)
4. [Examples](#examples)
   1. [UI Example](#ui-example)
      1. [Components](#components-1)
      2. [Classes](#classes)
         1. [DialogBox (Mediator)](#dialogbox-mediator)
         2. [ArticlesDialogBox (Concrete Mediator)](#articlesdialogbox-concrete-mediator)
         3. [UIControl (Colleague)](#uicontrol-colleague)
         4. [TextBox (Concrete Colleague)](#textbox-concrete-colleague)
         5. [ListBox (Concrete Colleague)](#listbox-concrete-colleague)
         6. [Button (Concrete Colleague)](#button-concrete-colleague)
   2. [UI Observer Example](#ui-observer-example)
      1. [Components](#components-2)
      2. [Classes](#classes-1)
         1. [UIControl (Colleague)](#uicontrol-colleague-1)
         2. [TextBox (Concrete Colleague)](#textbox-concrete-colleague-1)
         3. [ListBox (Concrete Colleague)](#listbox-concrete-colleague-1)
         4. [Button (Concrete Colleague)](#button-concrete-colleague-1)
         5. [IEventHandler (EventHandler)](#ieventhandler-eventhandler)
         6. [TitleEventHandler (Concrete EventHandler)](#titleeventhandler-concrete-eventhandler)
         7. [ArticlesEventHandler (Concrete EventHandler)](#articleseventhandler-concrete-eventhandler)
         8. [Articles (Client)](#articles-client)
   3. [SignUp Dialog Example](#signup-dialog-example)
      1. [Components](#components-3)
      2. [Classes](#classes-2)
         1. [SignUpDialogBox (Mediator)](#signupdialogbox-mediator)
         2. [ControlEventHandler (Concrete EventHandler)](#controleventhandler-concrete-eventhandler)
         3. [UIControl (Colleague)](#uicontrol-colleague-2)
         4. [TextBox (Concrete Colleague)](#textbox-concrete-colleague-2)
         5. [CheckBox (Concrete Colleague)](#checkbox-concrete-colleague)
         6. [Button (Concrete Colleague)](#button-concrete-colleague-2)

### Summary

The Mediator Pattern is a behavioral design pattern that allows objects to communicate with each other without needing to know each other's details. The pattern defines an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly.

### Components

- **Mediator**: Defines an interface for communicating with Colleague objects.
- **Concrete Mediator**: Implements the Mediator interface and coordinates communication between Colleague objects.
- **Colleague**: Defines an interface for Colleague objects.
- **Concrete Colleague**: Implements the Colleague interface and communicates with other Colleagues through the Mediator.

## Overview

The following examples demonstrate the Mediator Pattern in the context of a UI application.

## Examples

### UI Example

#### Components

- **Mediator**: `DialogBox`
- **Concrete Mediator**: `ArticlesDialogBox`
- **Colleague**: `UIControl`
- **Concrete Colleagues**: `TextBox`, `ListBox`, `Button`

#### Classes

##### DialogBox (Mediator)

Defines an interface for communicating with colleague objects.

- `Changed(UIControl control)`: Notifies the mediator that a colleague has changed.

##### ArticlesDialogBox (Concrete Mediator)

Implements the `DialogBox` interface and coordinates communication between colleague objects.

- `SimulateUserInteraction()`: Simulates user interaction with the dialog box.
- `Changed(UIControl control)`: Handles changes in colleague objects and updates other colleagues accordingly.
- `ArticleSelected()`: Handles the selection of an article.
- `TitleChanged()`: Handles changes in the title text box.

##### UIControl (Colleague)

Defines a base class for UI controls that interact with a mediator.

- `UIControl(DialogBox owner)`: Initializes a new instance of the `UIControl` class.
- `DialogBox _owner`: The mediator that coordinates communication.

##### TextBox (Concrete Colleague)

Represents a text box UI control.

- `string Content { get; set; }`: Gets or sets the content of the text box and notifies the mediator of changes.

##### ListBox (Concrete Colleague)

Represents a list box UI control.

- `string Selection { get; set; }`: Gets or sets the selected item in the list box and notifies the mediator of changes.

##### Button (Concrete Colleague)

Represents a button UI control.

- `bool IsEnabled { get; set; }`: Gets or sets a value indicating whether the button is enabled and notifies the mediator of changes.

### UI Observer Example

#### Components

- **Colleague**: `UIControl`
- **Concrete Colleagues**: `TextBox`, `ListBox`, `Button`
- **EventHandler**: `IEventHandler`
- **Concrete EventHandlers**: `TitleEventHandler`, `ArticlesEventHandler`
- **Client**: `Articles`

#### Classes

##### UIControl (Colleague)

Represents a base class for UI controls that manage a list of event handlers.

- `AddEventHandler(IEventHandler eventHandler)`: Adds an event handler to the control.
- `NotifyEventHandlers()`: Notifies all event handlers when an event occurs.

##### TextBox (Concrete Colleague)

Represents a text box UI control.

- `string Content { get; set; }`: Gets or sets the content of the text box and notifies event handlers of changes.

##### ListBox (Concrete Colleague)

Represents a list box UI control.

- `string Selection { get; set; }`: Gets or sets the selected item in the list box and notifies event handlers of changes.

##### Button (Concrete Colleague)

Represents a button UI control.

- `bool IsEnabled { get; set; }`: Gets or sets a value indicating whether the button is enabled and notifies event handlers of changes.

##### IEventHandler (EventHandler)

Defines an interface for handling events.

- `Handle()`: Handles the event.

##### TitleEventHandler (Concrete EventHandler)

Handles events related to the title text box and save button.

- `Handle()`: Enables or disables the save button based on the content of the text box.

##### ArticlesEventHandler (Concrete EventHandler)

Handles events related to the articles list box, title text box, and save button.

- `Handle()`: Updates the title text box content and enables the save button when an article is selected.

##### Articles (Client)

Represents the articles UI component that contains a list box, text box, and button.

- `Articles()`: Initializes a new instance of the `Articles` class and sets up event handlers for the list box and text box controls.
- `SimulateUserInteraction()`: Simulates user interaction with the articles component.

### SignUp Dialog Example

#### Components

- **Mediator**: `SignUpDialogBox`
- **Concrete EventHandler**: `ControlEventHandler`
- **Colleague**: `UIControl`
- **Concrete Colleagues**: `TextBox`, `CheckBox`, `Button`

#### Classes

##### SignUpDialogBox (Mediator)

Manages the interaction between various UI controls in a sign-up dialog box.

- `SignUpDialogBox()`: Initializes the dialog box and sets up event handlers for the controls.
- `SimulateUserInteraction()`: Simulates user interaction with the dialog box to demonstrate the Mediator pattern.

##### ControlEventHandler (Concrete EventHandler)

Handles events for various UI controls in the sign-up dialog.

- `ControlEventHandler(TextBox usernameTextBox, TextBox passwordTextBox, CheckBox agreeCheckbox, Button signUpButton)`: Initializes the event handler with the necessary controls.
- `Handle()`: Enables or disables the sign-up button based on the state of the text boxes and the checkbox.

##### UIControl (Colleague)

Represents a base class for UI controls that manage a list of event handlers.

- `AddEventHandler(IEventHandler eventHandler)`: Adds an event handler to the control.
- `NotifyEventHandlers()`: Notifies all event handlers when an event occurs.

##### TextBox (Concrete Colleague)

Represents a text box UI control.

- `string Content { get; set; }`: Gets or sets the content of the text box and notifies event handlers of changes.

##### CheckBox (Concrete Colleague)

Represents a checkbox UI control.

- `bool IsEnabled { get; set; }`: Gets or sets a value indicating whether the checkbox is enabled and notifies event handlers of changes.

##### Button (Concrete Colleague)

Represents a button UI control.

- `bool IsEnabled { get; set; }`: Gets or sets a value indicating whether the button is enabled and notifies event handlers of changes.
