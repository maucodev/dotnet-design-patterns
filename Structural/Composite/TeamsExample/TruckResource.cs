using System;

namespace Composite.TeamsExample;

/// <summary>
/// Represents a truck resource that can be deployed.
/// </summary>
public class TruckResource : IResource
{
    /// <inheritdoc />
    public void Deploy()
    {
        Console.WriteLine("Deploying a truck");
    }
}