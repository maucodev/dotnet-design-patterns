# Chain of Responsibility Pattern

## Introduction

The Chain of Responsibility pattern is a behavioral design pattern that allows a series of handler objects to process a request. Each handler can either handle the request or pass it along to the next handler in the chain. This pattern is useful for scenarios where multiple objects might need to process a request but the exact object that will handle it is not known until runtime.

Key benefits of the Chain of Responsibility pattern include:
- **Decoupling**: The sender of the request is decoupled from the receiver(s) that handle it.
- **Flexibility**: The chain can be dynamically modified by changing the sequence of handlers or adding/removing handlers.

## Index
1. [Web Server Example](#web-server-example)
2. [Accounting App Example](#accounting-app-example)

## Web Server Example

In this example, we implement a simple web server that processes HTTP requests using a chain of handlers. Each handler performs a specific task, such as authentication, logging, encryption, or compression.

### Classes
- **Handler**: Abstract base class for all handlers, defining the template method for handling requests.
- **HttpRequest**: Represents an HTTP request containing a username and password.
- **WebServer**: Coordinates the processing of requests using a chain of handlers.
- **Authenticator**: Handles authentication of requests.
- **Logger**: Logs request details.
- **Encryptor**: Encrypts the request.
- **Compressor**: Compresses the request data.

This design allows the server to process requests flexibly by passing them through a customizable chain of processing steps.

## Accounting App Example

In the Accounting App Example, the Chain of Responsibility pattern is used to process different types of accounting files. Each handler is responsible for a specific file format and processes the file if it matches the handler's expected format.

### Classes
- **Handler**: Abstract base class defining the template for file handling.
- **QuickBookReaderHandler**: Handles files specific to QuickBook (.qbw).
- **NumberReaderHandler**: Handles files specific to Apple's Numbers (.numbers).
- **ExcelReaderHandler**: Handles Excel files (.xls).
- **AccountingApp**: Processes files by passing them through a chain of handlers.

This implementation demonstrates how the Chain of Responsibility can be used to handle various file formats in an accounting application, allowing the system to be easily extended with new handlers for additional formats.
