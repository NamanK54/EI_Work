using System;

public class ConfigurationManager
{
    // This line creates the Singleton instance, but only when it's needed (lazy-loaded).
    // Lazy<T> is used here to ensure thread safety without any manual locks.
    private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    // The constructor is private to prevent direct instantiation.
    private ConfigurationManager()
    {
        // Simulate loading configuration settings from a file or environment variables.
        Console.WriteLine("Loading configuration settings...");
        Setting1 = "Default1";
        Setting2 = "Default2";
    }

    // This is the public property to access the Singleton instance.
    public static ConfigurationManager Instance
    {
        get
        {
            return _instance.Value;
        }
    }

    // Some settings that the Singleton will manage.
    public string Setting1 { get; private set; }
    public string Setting2 { get; private set; }

    // A method to display the current settings.
    public void DisplaySettings()
    {
        Console.WriteLine($"Setting1: {Setting1}, Setting2: {Setting2}");
    }

    // This method allows you to update the settings dynamically.
    public void UpdateSettings(string setting1, string setting2)
    {
        Setting1 = setting1;
        Setting2 = setting2;
        Console.WriteLine("Settings have been updated.");
    }
}