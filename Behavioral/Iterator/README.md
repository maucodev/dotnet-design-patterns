# Iterator Pattern

1. [Summary](#summary)
2. [Components](#components)
3. [Examples](#examples)
   1. [BrowseHistoryExample](#browsehistoryexample)
      - [Components](#components-1)
      - [Classes](#classes)
         - [IIterator<T> (Iterator)](#iiteratort-iterator)
         - [ListIterator<T> (Concrete Iterator)](#listiteratort-concrete-iterator)
         - [BrowseHistory (Aggregate)](#browsehistory-aggregate)
         - [BrowseHistory (Concrete Aggregate)](#browsehistory-concrete-aggregate)
   2. [ProductCollectionExample](#productcollectionexample)
      - [Components](#components-2)
      - [Classes](#classes-1)
         - [IIterator<T> (Iterator)](#iiteratort-iterator-1)
         - [ListIterator<T> (Concrete Iterator)](#listiteratort-concrete-iterator-1)
         - [Product (Concrete Aggregate)](#product-concrete-aggregate)
         - [ProductCollection (Aggregate)](#productcollection-aggregate)
         - [ProductCollection (Concrete Aggregate)](#productcollection-concrete-aggregate)

## Summary

The Iterator Pattern is a behavioral design pattern that provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It is used to traverse a container and access the container's elements.

## Components

- **Iterator (IIterator)**: An interface that defines methods for accessing elements in the aggregate.
- **Concrete Iterator (ListIterator)**: A concrete implementation of the iterator interface for a specific aggregate.

## Examples

### BrowseHistoryExample

#### Components

- **Iterator**: `IIterator<T>`
- **Concrete Iterator**: `ListIterator<T>`
- **Aggregate**: `BrowseHistory`
- **Concrete Aggregate**: `BrowseHistory`

#### Classes

##### IIterator<T> (Iterator)

The `IIterator<T>` interface declares methods for accessing and traversing elements.

##### ListIterator<T> (Concrete Iterator)

- `ListIterator<T>`: Implements the `IIterator<T>` interface to provide a way to iterate over a list.

##### BrowseHistory (Aggregate)

The `BrowseHistory` class maintains a list of URLs and provides a method to create an iterator for traversing the URLs.

### BrowseHistory (Concrete Aggregate)

- `Push(string url)`: Adds a new URL to the browsing history.
- `Pop()`: Removes the most recently added URL from the browsing history.
- `CreateIterator()`: Creates an iterator for the browsing history.

### ProductCollectionExample

#### Components

- **Iterator**: `IIterator<T>`
- **Concrete Iterator**: `ListIterator<T>`
- **Aggregate**: `ProductCollection`
- **Concrete Aggregate**: `ProductCollection`

#### Classes

##### IIterator<T> (Iterator)

The `IIterator<T>` interface declares methods for accessing and traversing elements.

##### ListIterator<T> (Concrete Iterator)

- `ListIterator<T>`: Implements the `IIterator<T>` interface to provide a way to iterate over a list.

##### Product (Concrete Aggregate)

The `Product` class represents a product with an ID and a name.

##### ProductCollection (Aggregate)

The `ProductCollection` class maintains a list of products and provides a method to create an iterator for traversing the products.

### ProductCollection (Concrete Aggregate)

- `Add(Product product)`: Adds a product to the collection.
- `CreateIterator()`: Creates an iterator for the product collection.
