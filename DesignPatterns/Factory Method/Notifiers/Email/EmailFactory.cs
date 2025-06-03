namespace DesignPatterns.Factory_Method
{
    // Concrete factories
    public class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification() => new EmailNotification();
    }

}
