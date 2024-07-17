# Memento Pattern

## Overview

These classes represent the Memento Pattern with `Editor` as the Originator, `EditorState` as the Memento, and `History` as the Caretaker.

- The Originator (`Editor`) can create a Memento (`EditorState`) that captures its current state and can restore its state from a Memento.
- The Caretaker (`History`) is responsible for storing and protecting the Mementos without modifying their content.

## Classes

### Editor (Originator)

The `Editor` class creates a memento containing a snapshot of its current state and uses the memento to restore its state.

### EditorState (Memento)

The `EditorState` class stores the state of the originator.

### History (Caretaker)

The `History` class is responsible for keeping the mementos.