using System;

namespace TemplateMethod.FinancialExample;

/// <summary>
/// Represents a task for transferring money.
/// </summary>
public class TransferMoneyTask : Task
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransferMoneyTask"/> class with the specified <see cref="AuditTrail"/>.
    /// </summary>
    /// <param name="auditTrail">The audit trail to use.</param>
    public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
    {
    }

    /// <inheritdoc/>
    protected override void DoExecute()
    {
        Console.WriteLine("Transfer money");
    }
}