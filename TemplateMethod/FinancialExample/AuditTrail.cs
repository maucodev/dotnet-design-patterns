using System;

namespace TemplateMethod.FinancialExample;

/// <summary>
/// Represents an audit trail that records actions.
/// </summary>
public class AuditTrail
{
    /// <summary>
    /// Records an audit trail entry.
    /// </summary>
    public void Record()
    {
        Console.WriteLine("Audit");
    }
}