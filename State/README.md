# State Pattern

### Summary

The State Pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes. It helps in managing state-specific behavior and makes the code more maintainable by encapsulating the state logic within state objects.

### Components

- **Context**: The object whose behavior varies based on its state. It maintains a reference to a state object and delegates state-specific behavior to this state object.
- **State**: An interface that declares the state-specific behavior. Concrete state classes implement this interface and define the behavior for a particular state.
- **ConcreteState**: Concrete implementations of the state interface. Each class encapsulates the behavior associated with a particular state of the context.

## Overview

The following examples demonstrate the State Pattern in different contexts.

## Examples

### CanvasExample

#### Components

- **Context**: `Canvas`
- **State**: `ITool`
- **ConcreteState**: `SelectionTool`, `EraserTool`, `BrushTool`

#### Classes

##### Canvas (Context)

The `Canvas` class maintains a reference to the current tool (`ITool`). It delegates the mouse events to the current tool, which defines the behavior for these events.

##### ITool (State)

The `ITool` interface declares the methods `MouseDown` and `MouseUp` that concrete state classes must implement to define the behavior for mouse events.

##### SelectionTool, EraserTool, BrushTool (ConcreteState)

- `SelectionTool`: Defines behavior for the selection tool, such as displaying the selection icon and drawing a dashed rectangle.
- `EraserTool`: Defines behavior for the eraser tool, such as displaying the eraser icon and erasing content.
- `BrushTool`: Defines behavior for the brush tool, such as displaying the brush icon and drawing a line.

### DirectionServiceExample

#### Components

- **Context**: `DirectionService`
- **State**: `ITravelMode`
- **ConcreteState**: `DrivingTravelMode`, `BicyclingTravelMode`, `TransitTravelMode`, `WalkingTravelMode`

#### Classes

##### DirectionService (Context)

The `DirectionService` class maintains a reference to the current travel mode (`ITravelMode`). It delegates the direction and ETA calculations to the current travel mode, which defines the behavior for these operations.

##### ITravelMode (State)

The `ITravelMode` interface declares the methods `GetEta` and `GetDirection` that concrete state classes must implement to define the behavior for direction and ETA calculations.

##### DrivingTravelMode, BicyclingTravelMode, TransitTravelMode, WalkingTravelMode (ConcreteState)

- `DrivingTravelMode`: Defines behavior for the driving travel mode, such as calculating driving ETA and direction.
- `BicyclingTravelMode`: Defines behavior for the bicycling travel mode, such as calculating bicycling ETA and direction.
- `TransitTravelMode`: Defines behavior for the transit travel mode, such as calculating transit ETA and direction.
- `WalkingTravelMode`: Defines behavior for the walking travel mode, such as calculating walking ETA and direction.
