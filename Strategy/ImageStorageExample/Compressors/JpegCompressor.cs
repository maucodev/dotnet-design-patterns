using System;

namespace Strategy.ImageStorageExample.Compressors;

/// <summary>
/// A concrete implementation of the ICompressor interface that compresses an image using JPEG compression.
/// </summary>
public class JpegCompressor : ICompressor
{
    /// <inheritdoc/>
    public void Compress(string fileName)
    {
        Console.WriteLine("Compressing using JPEG");
    }
}