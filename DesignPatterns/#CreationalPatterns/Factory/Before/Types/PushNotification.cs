namespace DesignPatterns.CreationalPatterns.Factory.Before.Types;

public class PushNotification : INotification
{
    public void Notify()
    {
        System.Console.WriteLine("Notified via PUSH notification.");
    }
}
