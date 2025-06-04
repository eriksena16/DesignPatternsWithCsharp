namespace DesignPatterns
{
    public class NotificationService
    {
        private readonly INotificationFactoryProvider _factoryProvider;

        public NotificationService(INotificationFactoryProvider notificationFactory)
        {
            _factoryProvider = notificationFactory;
        }

        public void Send(string type, string message)
        {
            var factory = _factoryProvider.GetFactory(type);
            var notifier = factory.CreateNotification();

            Console.WriteLine($"Send message...");
            Task.Delay(2000).Wait();
            notifier.Send(message);
        }
    }
}
