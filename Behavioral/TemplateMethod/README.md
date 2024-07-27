# Template Method Pattern

1. [Summary](#summary)
2. [Components](#components)
4. [Examples](#examples)
   1. [Financial Example](#financial-example)
      1. [Components](#components-1)
      2. [Classes](#classes)
         1. [Task (Abstract Class)](#task-abstract-class)
         2. [TransferMoneyTask (Concrete Class)](#transfermoneytask-concrete-class)
         3. [GenerateReportTask (Concrete Class)](#generatereporttask-concrete-class)
         4. [AuditTrail (Helper Class)](#audittrail-helper-class)
   2. [Window Example](#window-example)
      1. [Components](#components-2)
      2. [Classes](#classes-1)
         1. [Window (Abstract Class)](#window-abstract-class)
         2. [PaintWindow (Concrete Class)](#paintwindow-concrete-class)

## Summary

The Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a method, deferring some steps to subclasses. It allows subclasses to redefine certain steps of an algorithm without changing its structure.

## Components

- **Abstract Class**: Defines the template method and the abstract steps.
- **Concrete Class**: Implements the abstract steps defined in the Abstract Class.
- **Helper Class**: Provides additional functionality used by the Abstract Class.

## Examples

### Financial Example

#### Components

- **Abstract Class**: `Task`
- **Concrete Class**: `TransferMoneyTask`, `GenerateReportTask`
- **Helper Class**: `AuditTrail`

#### Classes

##### Task (Abstract Class)

The `Task` class defines the template method `Execute` which includes an audit trail record and a call to the abstract method `DoExecute`.

- `Execute()`: Executes the task, including recording an audit trail.
- `DoExecute()`: Abstract method for task-specific logic to be implemented by derived classes.

##### TransferMoneyTask (Concrete Class)

The `TransferMoneyTask` class implements the task-specific logic for transferring money.

- `DoExecute()`: Executes the task-specific logic for transferring money.

##### GenerateReportTask (Concrete Class)

The `GenerateReportTask` class implements the task-specific logic for generating a report.

- `DoExecute()`: Executes the task-specific logic for generating a report.

##### AuditTrail (Helper Class)

The `AuditTrail` class provides functionality to record an audit trail entry.

- `Record()`: Records an audit trail entry.

### Window Example

#### Components

- **Abstract Class**: `Window`
- **Concrete Class**: `PaintWindow`

#### Classes

##### Window (Abstract Class)

The `Window` class defines the template method `Close` which includes actions to be performed before and after removing the window from the screen.

- `Close()`: Closes the window by invoking the closing and closed actions.
- `OnClosing()`: Abstract method for actions when the window is closing, to be implemented by derived classes.
- `OnClosed()`: Abstract method for actions when the window has closed, to be implemented by derived classes.

##### PaintWindow (Concrete Class)

The `PaintWindow` class implements the task-specific logic for closing a paint window.

- `OnClosing()`: Executes actions to save changes when the window is closing.
- `OnClosed()`: Executes actions to confirm changes are safe when the window has closed.
