using System.Collections.Generic;

namespace Composite.TeamsExample;

/// <summary>
/// Represents a team composed of multiple resources that can be deployed together.
/// </summary>
public class Team : IResource
{
    private readonly List<IResource> _resources = [];

    /// <summary>
    /// Adds a resource to the team.
    /// </summary>
    /// <param name="resource">The resource to add.</param>
    public void Add(IResource resource)
    {
        _resources.Add(resource);
    }

    /// <inheritdoc />
    public void Deploy()
    {
        foreach (var resource in _resources)
        {
            resource.Deploy();
        }
    }
}