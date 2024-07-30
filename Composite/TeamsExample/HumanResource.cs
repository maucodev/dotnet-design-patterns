using System;

namespace Composite.TeamsExample;

/// <summary>
/// Represents a human resource that can be deployed.
/// </summary>
public class HumanResource : IResource
{
    /// <inheritdoc />
    public void Deploy()
    {
        Console.WriteLine("Deploying a human");
    }
}