# Strategy Pattern

### Summary

The Strategy Pattern is a behavioral design pattern that allows you to define a family of algorithms, encapsulate each one as a separate class, and make them interchangeable. This pattern lets the algorithm vary independently from clients that use it.

### Components

- **Strategy**: An interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a Concrete Strategy.
- **Concrete Strategy**: A class that implements the Strategy interface.
- **Context**: A class that maintains a reference to a Strategy object and can use it to call the algorithm defined by the Strategy.

## Overview

The following example demonstrates the Strategy Pattern in the context of image storage with different compression and filter strategies.

## Examples

### ImageStorageExample

#### Components

- **Strategy**: `ICompressor`, `IFilter`
- **Concrete Strategy**: `PngCompressor`, `JpegCompressor`, `HighContrastFilter`, `BlackAndWhiteFilter`
- **Context**: `ImageStorage`

#### Classes

##### ICompressor (Strategy)

The `ICompressor` interface declares a method for compressing an image file.

##### IFilter (Strategy)

The `IFilter` interface declares a method for applying a filter to an image file.

##### PngCompressor (Concrete Strategy)

- `Compress(string fileName)`: Compresses an image using PNG compression.

##### JpegCompressor (Concrete Strategy)

- `Compress(string fileName)`: Compresses an image using JPEG compression.

##### HighContrastFilter (Concrete Strategy)

- `Apply(string fileName)`: Applies a high-contrast filter to an image.

##### BlackAndWhiteFilter (Concrete Strategy)

- `Apply(string fileName)`: Applies a black-and-white filter to an image.

##### ImageStorage (Context)

The `ImageStorage` class maintains a reference to both a compression strategy and a filter strategy and uses them to store an image file.

- `Store(string fileName, ICompressor compressor, IFilter filter)`: Stores the image with the specified compression and filter strategies.
