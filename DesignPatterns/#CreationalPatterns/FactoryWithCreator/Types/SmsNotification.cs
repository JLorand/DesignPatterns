namespace DesignPatterns.CreationalPatterns.FactoryWithCreator.Types;

public class SmsNotification : INotification
{
    public void Notify()
    {
        System.Console.WriteLine("Notified via SMS notification.");
    }
}
