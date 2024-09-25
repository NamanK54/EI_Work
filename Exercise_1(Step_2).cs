class Program
{
    static void Main(string[] args)
    {
        // First, we get the instance of the ConfigurationManager and display the settings.
        var configManager1 = ConfigurationManager.Instance;
        configManager1.DisplaySettings();

        // Now, let's update the settings using the first instance.
        configManager1.UpdateSettings("NewValue1", "NewValue2");
        configManager1.DisplaySettings();

        // Get another reference to the Singleton instance.
        var configManager2 = ConfigurationManager.Instance;

        // Check if the settings updated by configManager1 are reflected in configManager2.
        configManager2.DisplaySettings();

        // Finally, let's confirm that both instances are actually the same.
        if (configManager1 == configManager2)
        {
            Console.WriteLine("Both instances are the same. Singleton works!");
        }
        else
        {
            Console.WriteLine("Instances are different. Singleton failed.");
        }
    }
}