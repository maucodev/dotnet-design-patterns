using Builder.BasicExample.App;

namespace Builder.BasicExample.Abstractions;

/// <summary>
/// Interface that defines a builder for creating presentations.
/// </summary>
public interface IPresentationBuilder
{
    /// <summary>
    /// Adds a slide to the presentation being built.
    /// </summary>
    /// <param name="slide">The slide to add.</param>
    public void AddSlide(Slide slide);
}