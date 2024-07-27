using System;
using System.Linq;

namespace ChainResponsibility.AccountingAppExample;

/// <summary>
/// A handler that processes QuickBook files.
/// </summary>
public class QuickBookReaderHandler : Handler
{
    /// <inheritdoc />
    public QuickBookReaderHandler(Handler next) : base(next)
    {
    }

    /// <inheritdoc />
    protected override bool DoHandle(string filename)
    {
        if (filename.Split(".").Last() == "qbw")
        {
            Console.WriteLine($"Handling {filename} on QuickBook");
        }

        return false;
    }
}