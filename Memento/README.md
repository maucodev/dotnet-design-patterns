# Memento Pattern

### Summary

The Memento Pattern is a behavioral design pattern that allows an object to save and restore its state without exposing its implementation details. It is particularly useful for implementing undo mechanisms.

### Components

- **Originator**: The object whose state needs to be saved and restored. It creates a memento containing a snapshot of its current state.
- **Memento**: A value object that acts as a snapshot of the originator's state. It is immutable once created.
- **Caretaker**: Manages the mementos' storage. It keeps track of multiple memento objects but does not modify or inspect their contents.

## Overview

These classes represent the Memento Pattern with `Document` as the Originator, `DocumentState` as the Memento, and `History` as the Caretaker.

- The Originator (`Document`) can create a Memento (`DocumentState`) that captures its current state and can restore its state from a Memento.
- The Caretaker (`History`) is responsible for storing and protecting the Mementos without modifying their content.

## Classes

### Document (Originator)

The `Document` class creates a memento containing a snapshot of its current state and uses the memento to restore its state.

### DocumentState (Memento)

The `DocumentState` class stores the state of the originator.

### History (Caretaker)

The `History` class is responsible for keeping the mementos.