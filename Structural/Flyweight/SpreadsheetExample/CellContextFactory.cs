using System;
using System.Collections.Generic;

namespace Flyweight.SpreadsheetExample;

/// <summary>
/// A factory for creating and managing cell contexts.
/// </summary>
public class CellContextFactory
{
    private readonly Dictionary<int, CellContext> _contexts = new();

    /// <summary>
    /// Gets a <see cref="CellContext"/> with the specified font family, font size, and bold attribute.
    /// If a matching context already exists, it is returned; otherwise, a new context is created.
    /// </summary>
    /// <param name="fontFamily">The font family.</param>
    /// <param name="fontSize">The font size.</param>
    /// <param name="isBold">Whether the font is bold.</param>
    /// <returns>A <see cref="CellContext"/> instance.</returns>
    public CellContext GetCellContext(string fontFamily, int fontSize, bool isBold)
    {
        var hash = HashCode.Combine(fontFamily, fontSize, isBold);

        if (_contexts.TryGetValue(hash, out var value))
        {
            return value;
        }

        value = new CellContext(fontFamily, fontSize, isBold);

        _contexts.Add(hash, value);

        return value;
    }
}