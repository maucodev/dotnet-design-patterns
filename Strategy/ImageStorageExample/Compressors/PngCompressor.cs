using System;

namespace Strategy.ImageStorageExample.Compressors;

/// <summary>
/// A concrete implementation of the ICompressor interface that compresses an image using PNG compression.
/// </summary>
public class PngCompressor : ICompressor
{
    /// <inheritdoc/>
    public void Compress(string fileName)
    {
        Console.WriteLine("Compressing using PNG");
    }
}