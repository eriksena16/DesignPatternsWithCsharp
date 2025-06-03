using DesignPatterns.Factory_Method;

namespace DesignPatterns
{
    public interface INotificationFactoryProvider
    {
        NotificationFactory GetFactory(string type);
    }


}