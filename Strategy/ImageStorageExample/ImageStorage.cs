using Strategy.ImageStorageExample.Compressors;
using Strategy.ImageStorageExample.Filters;

namespace Strategy.ImageStorageExample;

/// <summary>
/// Represents an image storage that can use different compression and filter strategies.
/// </summary>
public class ImageStorage
{
    /// <summary>
    /// Stores the image with the specified compression and filter strategies.
    /// </summary>
    /// <param name="fileName">The name of the file to store.</param>
    /// <param name="compressor">The compression strategy to use.</param>
    /// <param name="filter">The filter strategy to use.</param>
    public void Store(string fileName, ICompressor compressor, IFilter filter)
    {
        compressor.Compress(fileName);

        filter.Apply(fileName);
    }
}