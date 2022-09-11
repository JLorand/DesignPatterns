using DesignPatterns.CreationalPatterns.Factory.After.Types;

namespace DesignPatterns.CreationalPatterns.Factory.After.Factories;

public class NotificationFactory
{
    public INotification CreateNotification(NotificationType notificationType)
    {
        switch(notificationType)
        {
            case NotificationType.Push:
                return new PushNotification();
            case NotificationType.Sms:
                return new SmsNotification();
            default:
                throw new ArgumentException($"Invalid Notification Type: ({notificationType})");
        }
    }
}