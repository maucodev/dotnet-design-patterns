using System;

namespace Builder.BasicExample.App;

/// <summary>
/// Represents a movie that can be constructed by adding frames.
/// </summary>
public class Movie
{
    /// <summary>
    /// Adds a frame to the movie.
    /// </summary>
    /// <param name="text">The text content of the frame.</param>
    /// <param name="duration">The duration of the frame in seconds.</param>
    public void AddFrame(string text, int duration)
    {
        Console.WriteLine($"Adding a frame: {text} - {duration}");
    }
}