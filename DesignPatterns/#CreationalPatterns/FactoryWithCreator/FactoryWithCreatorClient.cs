namespace DesignPatterns.CreationalPatterns.FactoryWithCreator;

public partial class FactoryWithCreatorClient
{
    public static void ExecutePattern()
    {
        var notificationFactory = new NotificationFactory();
        var notification = notificationFactory.CreateNotification(GetNotificationType());
        notification.Notify();
    }

    private static NotificationType GetNotificationType()
    {
        var values = Enum.GetValues(typeof(NotificationType));
        Random random = new Random();
        return (NotificationType)values.GetValue(random.Next(values.Length));
    }
}