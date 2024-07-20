namespace TemplateMethod.FinancialExample;

/// <summary>
/// Represents an abstract task that includes an audit trail.
/// </summary>
public abstract class Task
{
    private readonly AuditTrail _auditTrail;

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class with a new <see cref="AuditTrail"/>.
    /// </summary>
    protected Task()
    {
        _auditTrail = new AuditTrail();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class with the specified <see cref="AuditTrail"/>.
    /// </summary>
    /// <param name="auditTrail">The audit trail to use.</param>
    protected Task(AuditTrail auditTrail)
    {
        _auditTrail = auditTrail;
    }

    /// <summary>
    /// Executes the task, including recording an audit trail.
    /// </summary>
    public void Execute()
    {
        _auditTrail.Record();

        DoExecute();
    }

    /// <summary>
    /// Executes the task-specific logic. This method must be implemented by derived classes.
    /// </summary>
    protected abstract void DoExecute();
}