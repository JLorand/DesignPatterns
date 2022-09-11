using DesignPatterns.CreationalPatterns.Factory.Before.Types;

namespace DesignPatterns.CreationalPatterns.Factory.Before;

public class Client
{
    static void Execute()
    {
        // Some logic before creating concrete types
        
        var notificationType = GetNotificationType();
        INotification notification;        
        switch(notificationType)
        {
            case NotificationType.Push:
                notification = new PushNotification();
                break;
            case NotificationType.Sms:
                notification = new SmsNotification();
                break;
            default:
                throw new ArgumentException($"Invalid Notification Type: ({notificationType})");
        }
        
        // Some logic after concrete types created
    }

    private static NotificationType GetNotificationType()
    {
        var values = Enum.GetValues(typeof(NotificationType));
        Random random = new Random();
        return (NotificationType)values.GetValue(random.Next(values.Length));
    }
}