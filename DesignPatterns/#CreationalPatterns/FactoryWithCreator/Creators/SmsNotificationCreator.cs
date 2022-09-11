using DesignPatterns.CreationalPatterns.FactoryWithCreator.Types;

namespace DesignPatterns.CreationalPatterns.FactoryWithCreator.Creators;

public class SmsNotificationCreator : Creator
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}
