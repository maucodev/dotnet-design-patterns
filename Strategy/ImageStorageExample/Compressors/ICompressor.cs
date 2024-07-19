namespace Strategy.ImageStorageExample.Compressors;

/// <summary>
/// Defines a method to compress an image file.
/// </summary>
public interface ICompressor
{
    /// <summary>
    /// Compresses the specified image file.
    /// </summary>
    /// <param name="fileName">The name of the file to compress.</param>
    void Compress(string fileName);
}