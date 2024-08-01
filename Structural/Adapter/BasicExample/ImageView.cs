namespace Adapter.BasicExample;

/// <summary>
/// Class that handles the display and manipulation of an image.
/// </summary>
public class ImageView
{
    private readonly Image _image;

    /// <summary>
    /// Initializes a new instance of the <see cref="ImageView"/> class with the specified image.
    /// </summary>
    /// <param name="image">The image to be displayed and manipulated.</param>
    public ImageView(Image image)
    {
        _image = image;
    }

    /// <summary>
    /// Applies the specified filter to the image.
    /// </summary>
    /// <param name="filter">The filter to apply to the image.</param>
    public void Apply(IFilter filter)
    {
        filter.Apply(_image);
    }
}