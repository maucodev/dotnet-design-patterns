using System;
using System.Linq;

namespace ChainResponsibility.AccountingAppExample;

/// <summary>
/// A handler that processes Number files.
/// </summary>
public class NumberReaderHandler : Handler
{
    /// <inheritdoc />
    public NumberReaderHandler(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(string filename)
    {
        if (filename.Split(".").Last() == "numbers")
        {
            Console.WriteLine($"Handling {filename} on Number");
        }

        return false;
    }
}