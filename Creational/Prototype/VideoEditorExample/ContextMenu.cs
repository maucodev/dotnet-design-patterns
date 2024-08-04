namespace Prototype.VideoEditorExample;

/// <summary>
/// Represents a context menu that can duplicate components and add them to a timeline.
/// </summary>
public class ContextMenu
{
    private readonly Timeline _timeline;

    /// <summary>
    /// Initializes a new instance of the <see cref="ContextMenu"/> class with the specified timeline.
    /// </summary>
    /// <param name="timeline">The timeline to which duplicated components will be added.</param>
    public ContextMenu(Timeline timeline)
    {
        _timeline = timeline;
    }

    /// <summary>
    /// Duplicates the specified component by creating a clone of it and adding it to the timeline.
    /// </summary>
    /// <param name="component">The component to duplicate.</param>
    public void Duplicate(IComponent component)
    {
        var result = component.Clone();

        _timeline.Add(result);
    }
}