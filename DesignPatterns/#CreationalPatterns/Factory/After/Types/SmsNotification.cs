namespace DesignPatterns.CreationalPatterns.Factory.After.Types;

public class SmsNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("Notified via SMS notification.");
    }
}
