namespace DesignPatterns.CreationalPatterns.Sigleton.Before;

public static class Client
{
    public static void Execute()
    {
        var s1 = new RandomClass();
        var s2 = new RandomClass();

        // Test for same instance
        if (s1 == s2)
        {
            Console.WriteLine("Objects are the same instance");
        }
        else
        {
            Console.WriteLine("Objects are not the same instance");
        }
    }
}