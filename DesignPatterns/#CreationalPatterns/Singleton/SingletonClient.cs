public static class SingletonClient
{
    public static void ExecutePattern()
    {
        var s1 = Singleton.Instance();
        var s2 = Singleton.Instance();
        
        var s3 = SingletonFromProperty.Instance;
        var s4 = SingletonFromProperty.Instance;

        // Test for same instance
        if (s1 == s2 && s3 == s4)
        {
            Console.WriteLine("Objects are the same instance");
        }
    }
}