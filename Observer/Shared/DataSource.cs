namespace Observer.Shared;

/// <summary>
/// Represents the subject that holds a value and notifies observers of changes to the value.
/// </summary>
public class DataSource : Subject
{
    private int _value;

    /// <summary>
    /// Gets or sets the value of the data source.
    /// When the value is set, observers are notified of the change.
    /// </summary>
    public int Value
    {
        get => _value;
        set
        {
            _value = value;
            NotifyObservers(value);
        }
    }
}