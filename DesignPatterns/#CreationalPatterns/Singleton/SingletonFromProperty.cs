public class SingletonFromProperty
{
    private static SingletonFromProperty? instance;

    private static object _lock = new();

    // Constructor is 'protected'
    protected SingletonFromProperty()
    {
    }

    public static SingletonFromProperty? Instance
    {
        get
        {
            if(instance == null)
            {
                lock(_lock)
                {
                    instance = new SingletonFromProperty();
                }
            }

            return instance;
        }
    }
}