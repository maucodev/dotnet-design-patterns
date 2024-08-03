using System;

namespace Flyweight.SpreadsheetExample;

/// <summary>
/// Represents a cell in a spreadsheet.
/// </summary>
public class Cell
{
    private readonly int _row;
    private readonly int _column;

    /// <summary>
    /// Gets or sets the content of the cell.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Gets or sets the context of the cell.
    /// </summary>
    public CellContext CellContext { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Cell"/> class with the specified row, column, and cell context.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="column">The column index of the cell.</param>
    /// <param name="cellContext">The context of the cell.</param>
    public Cell(int row, int column, CellContext cellContext)
    {
        _row = row;
        _column = column;
        CellContext = cellContext;
    }

    /// <summary>
    /// Renders the cell by outputting its row, column, content, and font family to the console.
    /// </summary>
    public void Render()
    {
        Console.WriteLine($"({_row}, {_column}): {Content} [{CellContext.FontFamily}]");
    }
}