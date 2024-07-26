using System;
using System.Linq;

namespace ChainResponsibility.AccountingAppExample;

/// <summary>
/// A handler that processes Excel files.
/// </summary>
public class ExcelReaderHandler : Handler
{
    /// <inheritdoc />
    public ExcelReaderHandler(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(string filename)
    {
        if (filename.Split(".").Last() == "xls")
        {
            Console.WriteLine($"Handling {filename} on Excel");
        }

        return false;
    }
}