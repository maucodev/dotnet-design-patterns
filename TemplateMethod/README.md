# Template Method Pattern

### Summary

The Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a method, deferring some steps to subclasses. It allows subclasses to redefine certain steps of an algorithm without changing its structure.

### Components

- **Abstract Class**: Defines the template method and the abstract steps.
- **Concrete Class**: Implements the abstract steps defined in the Abstract Class.
- **Helper Class**: Provides additional functionality used by the Abstract Class.

## Overview

The following example demonstrates the Template Method Pattern in the context of financial tasks with an audit trail.

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
