using System.Collections.Generic;

namespace Singleton.BasicExample;

/// <summary>
/// Represents a configuration manager that stores and retrieves settings.
/// This class follows the Singleton Pattern.
/// </summary>
public class ConfigManager
{
    private readonly Dictionary<string, object> _settings = [];
    public static readonly ConfigManager Instance = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigManager"/> class.
    /// </summary>
    private ConfigManager()
    {
    }

    /// <summary>
    /// Sets a configuration setting.
    /// </summary>
    /// <param name="key">The key identifying the setting.</param>
    /// <param name="value">The value of the setting.</param>
    public void Set(string key, object value)
    {
        _settings.Add(key, value);
    }

    /// <summary>
    /// Gets the value of a configuration setting.
    /// </summary>
    /// <param name="key">The key identifying the setting.</param>
    /// <returns>The value of the setting.</returns>
    public object Get(string key)
    {
        return _settings[key];
    }
}