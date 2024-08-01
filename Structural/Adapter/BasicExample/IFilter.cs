namespace Adapter.BasicExample;

/// <summary>
/// Interface representing a filter that can be applied to an image.
/// </summary>
public interface IFilter
{
    /// <summary>
    /// Applies the filter to the given image.
    /// </summary>
    /// <param name="image">The image to apply the filter to.</param>
    public void Apply(Image image);
}