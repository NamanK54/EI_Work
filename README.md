# EI_Work
Accomplished Exercises

Problem Statement 

Imagine you're working on an application that needs to manage configuration settings, like API keys or database connection strings. You want to make sure there's only one place in the entire application where these settings are stored and accessed. To solve this, we'll use the Singleton pattern, which ensures that only one instance of a class exists and provides a global access point to that instance.

Step 1 : By implementing a basic Singleton. We'll make sure it's thread-safe and lazy-loaded, which means the instance will only be created when it's actually needed.

 
Step 2 : Testing the Singleton
After implementing the Singleton, we'll create a couple of references to the ConfigurationManager and see if they actually point to the same instance. We’ll also try updating the settings to ensure the Singleton behaves as expected.


Explanation

Lazy Initialization : We use Lazy<T> to ensure that our Singleton instance is created only when it's first accessed. This is a great way to save resources because we don't create the object until we actually need it. Plus, Lazy<T> takes care of thread safety for us.

Thread Safety : In a multi-threaded application, multiple threads might try to create the Singleton instance simultaneously. Using Lazy<T> helps us avoid issues like creating multiple instances in such scenarios. This ensures that no matter how many threads try to access the ConfigurationManager at once, they'll all get the same instance.

Dynamic Updates : We've added a method UpdateSettings that allows you to change the settings after the Singleton has been created. This is handy in situations where your configuration needs to be updated without restarting the entire application.

Step 3 : Code Execution

When you run this code, output shows that :-

Loading configuration settings...

Setting1 : Default1, Setting2 : Default2

Settings have been updated.

Setting1 : NewValue1, Setting2 : NewValue2

Both instances are the same. Singleton works!

The Singleton instance is created only once, as indicated by the "Loading configuration settings..." message appearing only once.

The updated settings are reflected across all references to the Singleton, proving that configManager1 and configManager2 are indeed the same instance.
