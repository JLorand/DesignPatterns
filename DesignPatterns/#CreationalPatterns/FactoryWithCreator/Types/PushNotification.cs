namespace DesignPatterns.CreationalPatterns.FactoryWithCreator.Types;

public class PushNotification : INotification
{
    public void Notify()
    {
        System.Console.WriteLine("Notified via PUSH notification.");
    }
}
