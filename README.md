# Design Patterns Project

This repository contains the implementation of various design patterns in C#, organized into separate projects. The goal of this project is to reinforce the understanding and application of essential design patterns by implementing them from scratch.

## Project Structure

The solution is organized into different categories of design patterns, each with its own project. This modular approach allows for better organization and easier management of the codebase.

### Behavioral Patterns

These patterns are concerned with algorithms and the assignment of responsibilities between objects.

- **Chain of Responsibility**: Allows a request to be passed along a chain of handlers, where each handler decides either to process the request or pass it to the next handler in the chain.
- **Command**: Encapsulates a request as an object, thereby allowing users to parameterize clients with different requests, queue or log requests, and support undoable operations.
- **Iterator**: Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
- **Mediator**: Defines an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly.
- **Memento**: Allows the capture and externalization of an object's internal state so that the object can be restored to this state later, without violating encapsulation.
- **Observer**: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- **State**: Allows an object to alter its behavior when its internal state changes, appearing as though the object has changed its class.
- **Strategy**: Defines a family of algorithms, encapsulates each one, and makes them interchangeable. The strategy pattern lets the algorithm vary independently from the clients that use it.
- **Template Method**: Defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.
- **Visitor**: Allows adding further operations to objects without having to modify them.

### Creational Patterns

These patterns deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.

- **Abstract Factory**: Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- **Builder**: Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
- **Factory**: Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.
- **Prototype**: Specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype.
- **Singleton**: Ensures a class has only one instance, and provides a global point of access to it.

### Structural Patterns

These patterns are concerned with how classes and objects are composed to form larger structures.

- **Adapter**: Allows incompatible interfaces to work together by wrapping an existing class with a new interface.
- **Bridge**: Decouples an abstraction from its implementation, allowing the two to vary independently.
- **Composite**: Composes objects into tree structures to represent part-whole hierarchies, allowing clients to treat individual objects and compositions of objects uniformly.
- **Decorator**: Allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class.
- **Facade**: Provides a simplified interface to a complex subsystem.
- **Flyweight**: Reduces the cost of creating and manipulating a large number of similar objects by sharing common parts of the state between multiple objects.
- **Proxy**: Provides a surrogate or placeholder for another object to control access to it.

## Prerequisites

To run and modify this project, you will need:

- **Visual Studio 2022** or later
- **.NET 8 SDK** or later

Ensure that you have the required tools and SDKs installed to build and run the projects within this solution.

## Getting Started

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/maucodev/dotnet-design-patterns.git
    ```

2. Open the solution in Visual Studio:

    ```bash
    cd dotnet-design-patterns
    start DesignPatterns.sln
    ```

3. Build the solution:

    - In Visual Studio, go to **Build** > **Build Solution** or press `Ctrl + Shift + B`.

4. Run the projects:

    - Right-click on the desired project in the **Solution Explorer** and select **Set as StartUp Project**.
    - Press `F5` to run the project.

## Learning Path

This project is inspired by the course **"The Ultimate Design Patterns"** by Mosh Hamedani. The codebase is designed to complement the lessons from the course, with a focus on hands-on practice and deeper understanding.

For more information about the course, visit [The Ultimate Design Patterns](https://codewithmosh.com/p/design-patterns).

## Contributing

Contributions to this project are welcome. If you find a bug, have an idea for a new feature, or want to improve the existing code, feel free to submit a pull request.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature/your-feature`).
6. Open a pull request.

## Acknowledgments

- **Mosh Hamedani** - For the course that inspired this project, [The Ultimate Design Patterns](https://codewithmosh.com/p/design-patterns).
