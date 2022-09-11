namespace DesignPatterns.CreationalPatterns.Factory.Before.Types;

public class SmsNotification : INotification
{
    public void Notify()
    {
        System.Console.WriteLine("Notified via SMS notification.");
    }
}
