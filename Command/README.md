# Command Pattern

1. [Summary](#summary)
2. [Components](#components)
3. [Overview](#overview)
4. [Examples](#examples)
   1. [Customer Example](#customer-example)
      1. [Components](#components-1)
      2. [Classes](#classes)
         1. [ICommand (Command Interface)](#icommand-command-interface)
         2. [Button (Invoker)](#button-invoker)
         3. [CustomerService (Receiver)](#customerservice-receiver)
         4. [AddCustomerCommand (Concrete Command)](#addcustomercommand-concrete-command)
   2. [Composite Commands Example](#composite-commands-example)
      1. [Components](#components-2)
      2. [Classes](#classes-1)
         1. [ICommand (Command Interface)](#icommand-command-interface-1)
         2. [ResizeCommand (Concrete Command)](#resizecommand-concrete-command)
         3. [BlackAndWhiteCommand (Concrete Command)](#blackandwhitecommand-concrete-command)
         4. [CompositeCommand (Composite Command)](#compositecommand-composite-command)

### Summary

The Command Pattern is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you parameterize methods with different requests, delay or queue a request's execution, and support undoable operations.

### Components

- **Invoker**: Responsible for initiating requests.
- **Receiver**: Knows how to perform the operations associated with carrying out a request.
- **Command Interface**: Declares an interface for executing operations.
- **Concrete Command**: Defines a binding between a Receiver object and an action. Implements Execute by invoking the corresponding operations on Receiver.

## Overview

The following example demonstrates the Command Pattern in the context of customer management.

## Examples

### Customer Example

#### Components

- **Invoker**: `Button`
- **Receiver**: `CustomerService`
- **Command Interface**: `ICommand`
- **Concrete Command**: `AddCustomerCommand`

#### Classes

##### ICommand (Command Interface)

Defines a command interface with an `Execute` method.

- `Execute()`: Executes the command.

##### Button (Invoker)

Represents a button that acts as an invoker in the Command Pattern.

- `Label`: Gets or sets the label of the button.
- `Click()`: Simulates a button click, causing the command to be executed.

##### CustomerService (Receiver)

Represents a customer service that acts as a receiver in the Command Pattern.

- `AddCustomer()`: Adds a customer to the database.

##### AddCustomerCommand (Concrete Command)

Represents a command for adding a customer, which is a concrete command in the Command Pattern.

- `Execute()`: Executes the command to add a customer by calling `AddCustomer` on `CustomerService`.

### Composite Commands Example

#### Components

- **Command Interface**: `ICommand`
- **Concrete Commands**: `ResizeCommand`, `BlackAndWhiteCommand`
- **Composite Command**: `CompositeCommand`

#### Classes

##### ICommand (Command Interface)

Defines a command interface with an `Execute` method.

- `Execute()`: Executes the command.

##### ResizeCommand (Concrete Command)

Represents a command for resizing, implementing the `ICommand` interface.

- `Execute()`: Executes the command to resize.

##### BlackAndWhiteCommand (Concrete Command)

Represents a command for applying a black and white filter, implementing the `ICommand` interface.

- `Execute()`: Executes the command to apply the black and white filter.

##### CompositeCommand (Composite Command)

Represents a composite command that can store and execute multiple commands.

- `Add(ICommand command)`: Adds a command to the composite command.
- `Execute()`: Executes all commands stored in the composite command.