# Observer Pattern

1. [Summary](#summary)
2. [Components](#components)
3. [Overview](#overview)
4. [Examples](#examples)
   1. [Data Update Example](#data-update-example)
      1. [Components](#components-1)
      2. [Classes](#classes)
         1. [IObserver (Observer Interface)](#iobserver-observer-interface)
         2. [Subject (Subject)](#subject-subject)
         3. [Chart (Concrete Observer)](#chart-concrete-observer)
         4. [DataSource (Concrete Subject)](#datasource-concrete-subject)
         5. [SpreadSheet (Concrete Observer)](#spreadsheet-concrete-observer)

### Summary

The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency between objects. When one object changes state, all its dependents are notified and updated automatically. It is mainly used to implement distributed event-handling systems.

### Components

- **Observer**: An interface for objects that should be notified of changes in a subject.
- **Concrete Observer**: An implementation of the Observer interface that reacts to updates.
- **Subject**: An interface or abstract class for an object that maintains a list of observers and notifies them of changes.
- **Concrete Subject**: An implementation of the Subject that stores state and notifies observers of changes to the state.

## Overview

The following example demonstrates the Observer Pattern in the context of data updates.

## Examples

### Spread Sheets Example

#### Components

- **Observer**: `IObserver`
- **Concrete Observer**: `Chart`, `SpreadSheet`
- **Subject**: `Subject`
- **Concrete Subject**: `DataSource`

#### Classes

##### IObserver (Observer Interface)

Defines an interface for observers that need to be notified of changes.

- `Update(int value)`: Called when the subject's state changes. The new value of the subject is passed as an argument.

##### Subject (Subject)

Represents the subject that maintains a list of observers and notifies them of changes.

- `AddObserver(IObserver observer)`: Adds an observer to the list.
- `RemoveObserver(IObserver observer)`: Removes an observer from the list.
- `NotifyObservers(int value)`: Notifies all observers of a change in state. The new value is passed as an argument.

##### Chart (Concrete Observer)

Represents an observer that displays updates on a chart.

- `Update(int value)`: Called when the subject's state changes. Displays the new value on the chart.

##### DataSource (Concrete Subject)

Represents the subject that holds a value and notifies observers of changes to the value.

- `Value`: Gets or sets the value of the data source. When the value is set, observers are notified of the change.

##### SpreadSheet (Concrete Observer)

Represents an observer that displays updates on a spreadsheet.

- `Update(int value)`: Called when the subject's state changes. Displays the new value on the spreadsheet.
