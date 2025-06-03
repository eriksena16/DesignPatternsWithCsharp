using DesignPatterns.Factory_Method;

namespace DesignPatterns
{

    public class NotificationFactoryProvider : INotificationFactoryProvider
    {
        public NotificationFactory GetFactory(string type)
        {
            return type switch
            {
                "1" => new EmailFactory(),
                "2" => new SmsFactory(),
                _ => throw new ArgumentException("notification type invalid.")
            };

        }
    }

}