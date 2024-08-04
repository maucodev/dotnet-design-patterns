using System;
using System.Collections.Generic;

namespace Singleton.LoggerExample;

/// <summary>
/// Represents a logger that writes messages to a specified file.
/// This class follows the Singleton Pattern with multiple instances identified by filenames.
/// </summary>
public class Logger
{
    private readonly string _filename;
    private static readonly Dictionary<string, Logger> Instances = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="Logger"/> class with the specified filename.
    /// </summary>
    /// <param name="filename">The name of the file to which log messages will be written.</param>
    public Logger(string filename)
    {
        _filename = filename;
    }

    /// <summary>
    /// Writes a message to the log.
    /// </summary>
    /// <param name="message">The message to write to the log.</param>
    public void Write(string message)
    {
        Console.WriteLine($"Writing: {message}");
    }

    /// <summary>
    /// Gets the instance of <see cref="Logger"/> associated with the specified filename.
    /// If an instance for the filename does not exist, it creates a new one.
    /// </summary>
    /// <param name="filename">The filename identifying the logger instance.</param>
    /// <returns>The <see cref="Logger"/> instance associated with the specified filename.</returns>
    public static Logger GetInstance(string filename)
    {
        if (Instances.TryGetValue(filename, out var value))
        {
            return value;
        }

        Instances.Add(filename, new Logger(filename));

        return Instances[filename];
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"Logger for: {_filename}";
    }
}