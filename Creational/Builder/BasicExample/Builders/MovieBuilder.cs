using Builder.BasicExample.Abstractions;
using Builder.BasicExample.App;

namespace Builder.BasicExample.Builders;

/// <summary>
/// A builder that constructs a movie from presentation slides.
/// </summary>
public class MovieBuilder : IPresentationBuilder
{
    private readonly Movie _movie = new();

    /// <inheritdoc />
    public void AddSlide(Slide slide)
    {
        _movie.AddFrame(slide.Text, 3);
    }

    /// <summary>
    /// Gets the constructed movie.
    /// </summary>
    /// <returns>The constructed <see cref="Movie"/>.</returns>
    public Movie GetMovie()
    {
        return _movie;
    }
}