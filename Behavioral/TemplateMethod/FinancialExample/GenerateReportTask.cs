using System;

namespace TemplateMethod.FinancialExample;

/// <summary>
/// Represents a task for generating a report.
/// </summary>
public class GenerateReportTask : Task
{
    /// <inheritdoc/>
    protected override void DoExecute()
    {
        Console.WriteLine("Generate report");
    }
}