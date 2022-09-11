using DesignPatterns.CreationalPatterns.FactoryWithCreator.Types;
using DesignPatterns.CreationalPatterns.FactoryWithCreator.Creators;

namespace DesignPatterns.CreationalPatterns.FactoryWithCreator;

public class NotificationFactory
{
    private readonly PushNotificationCreator pushNotificationCreator;
    private readonly SmsNotificationCreator smsNotificationCreator;

    public NotificationFactory()
    {
        this.pushNotificationCreator = new PushNotificationCreator();
        this.smsNotificationCreator = new SmsNotificationCreator();
    }

    public INotification CreateNotification(NotificationType notificationType)
    {
        switch(notificationType)
        {
            case NotificationType.Push:
                return pushNotificationCreator.CreateNotification();
            case NotificationType.Sms:
                return smsNotificationCreator.CreateNotification();
            default:
                throw new ArgumentException($"Invalid Notification Type: ({notificationType})");
        }
    }
}