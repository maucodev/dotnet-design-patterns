using System;

namespace Flyweight.SpreadsheetExample;

/// <summary>
/// Represents a spreadsheet containing cells.
/// </summary>
public class SpreadSheet
{
    private const int MaxRows = 3;
    private const int MaxCols = 3;
    private readonly Cell[,] _cells = new Cell[MaxRows, MaxCols];
    private readonly CellContextFactory _contextFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="SpreadSheet"/> class with the specified cell context factory.
    /// </summary>
    /// <param name="contextFactory">The cell context factory.</param>
    public SpreadSheet(CellContextFactory contextFactory)
    {
        _contextFactory = contextFactory;

        GenerateCells();
    }

    /// <summary>
    /// Sets the content of the specified cell.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="col">The column index of the cell.</param>
    /// <param name="content">The content to set.</param>
    public void SetContent(int row, int col, string content)
    {
        EnsureCellExists(row, col);

        _cells[row, col].Content = content;
    }

    /// <summary>
    /// Sets the font family of the specified cell.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="col">The column index of the cell.</param>
    /// <param name="fontFamily">The font family to set.</param>
    public void SetFontFamily(int row, int col, string fontFamily)
    {
        EnsureCellExists(row, col);

        var cell = _cells[row, col];
        var currentContext = cell.CellContext;
        var context = _contextFactory.GetCellContext(fontFamily, currentContext.FontSize, currentContext.IsBold);

        _cells[row, col].CellContext = context;
    }

    /// <summary>
    /// Ensures that the specified cell exists within the valid range of the spreadsheet.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="col">The column index of the cell.</param>
    private void EnsureCellExists(int row, int col)
    {
        if (row is < 0 or >= MaxRows)
        {
            throw new InvalidOperationException();
        }

        if (col is < 0 or >= MaxCols)
        {
            throw new InvalidOperationException();
        }
    }

    /// <summary>
    /// Generates the cells of the spreadsheet with the default context.
    /// </summary>
    private void GenerateCells()
    {
        for (var row = 0; row < MaxRows; row++)
        {
            for (var col = 0; col < MaxCols; col++)
            {
                _cells[row, col] = new Cell(row, col, GetDefaultContext());
            }
        }
    }

    /// <summary>
    /// Gets the default cell context.
    /// </summary>
    /// <returns>A <see cref="CellContext"/> with default values.</returns>
    private CellContext GetDefaultContext()
    {
        return new CellContext("Times New Roman", 12, false);
    }

    /// <summary>
    /// Renders the spreadsheet by outputting each cell's content to the console.
    /// </summary>
    public void Render()
    {
        for (var row = 0; row < MaxRows; row++)
        {
            for (var col = 0; col < MaxCols; col++)
            {
                _cells[row, col].Render();
            }
        }
    }
}