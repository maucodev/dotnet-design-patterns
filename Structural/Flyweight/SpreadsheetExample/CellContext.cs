using System;

namespace Flyweight.SpreadsheetExample;

/// <summary>
/// Represents the context of a cell, which includes font family, font size, and bold attribute.
/// </summary>
public class CellContext
{
    /// <summary>
    /// Gets the font family of the cell context.
    /// </summary>
    public string FontFamily { get; }

    /// <summary>
    /// Gets the font size of the cell context.
    /// </summary>
    public int FontSize { get; }

    /// <summary>
    /// Gets a value indicating whether the font is bold.
    /// </summary>
    public bool IsBold { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CellContext"/> class with the specified font family, font size, and bold attribute.
    /// </summary>
    /// <param name="fontFamily">The font family.</param>
    /// <param name="fontSize">The font size.</param>
    /// <param name="isBold">Whether the font is bold.</param>
    public CellContext(string fontFamily, int fontSize, bool isBold)
    {
        FontFamily = fontFamily;
        FontSize = fontSize;
        IsBold = isBold;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(FontFamily, FontSize, IsBold);
    }
}