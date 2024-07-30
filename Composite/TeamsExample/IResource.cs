namespace Composite.TeamsExample;

/// <summary>
/// Defines the basic contract for a resource that can be deployed.
/// </summary>
public interface IResource
{
    public void Deploy();
}