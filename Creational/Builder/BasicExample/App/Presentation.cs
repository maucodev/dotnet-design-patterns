using System.Collections.Generic;
using Builder.BasicExample.Abstractions;

namespace Builder.BasicExample.App;

/// <summary>
/// Represents a presentation composed of slides.
/// </summary>
public class Presentation
{
    private readonly List<Slide> _slides = [];

    /// <summary>
    /// Adds a slide to the presentation.
    /// </summary>
    /// <param name="slide">The slide to add to the presentation.</param>
    public void AddSlide(Slide slide)
    {
        _slides.Add(slide);
    }

    /// <summary>
    /// Exports the presentation using the specified presentation builder.
    /// </summary>
    /// <param name="builder">The builder responsible for exporting the slides.</param>
    public void Export(IPresentationBuilder builder)
    {
        foreach (var slide in _slides)
        {
            builder.AddSlide(slide);
        }
    }
}