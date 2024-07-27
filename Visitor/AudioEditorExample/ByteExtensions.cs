using System;

namespace Visitor.AudioEditorExample;

/// <summary>
/// Provides extension methods for byte data types.
/// </summary>
public static class ByteExtensions
{
    /// <summary>
    /// Applies a filter to a byte segment and outputs the result.
    /// </summary>
    /// <param name="segment">The byte segment to which the filter will be applied.</param>
    /// <param name="filter">The filter to apply to the byte segment.</param>
    public static void Apply(this byte segment, IFilter filter)
    {
        Console.WriteLine($"{filter.Name} applied on segment {segment}");
    }
}