namespace Strategy.ImageStorageExample.Filters;

/// <summary>
/// Defines a method to apply a filter to an image.
/// </summary>
public interface IFilter
{
    /// <summary>
    /// Applies a filter to the specified image file.
    /// </summary>
    /// <param name="fileName">The name of the file to apply the filter to.</param>
    void Apply(string fileName);
}