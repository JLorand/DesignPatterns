namespace DesignPatterns.CreationalPatterns.Factory.After.Types;

public class PushNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("Notified via PUSH notification.");
    }
}
