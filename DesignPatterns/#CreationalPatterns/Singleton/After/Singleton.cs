namespace DesignPatterns.CreationalPatterns.Sigleton.After;

public class Singleton
{
    private static Singleton? instance;

    private static object _lock = new();

    // Constructor is 'protected'
    protected Singleton()
    {
    }
    
    public static Singleton Instance()
    {
        // Uses lazy initialization.
        if (instance == null)
        {
            // Threadsafe instantiation
            lock(_lock)
            {
                instance = new Singleton();
            }
        }

        return instance;
    }
}
