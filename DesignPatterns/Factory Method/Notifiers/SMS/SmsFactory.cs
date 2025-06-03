namespace DesignPatterns.Factory_Method
{

    public class SmsFactory : NotificationFactory
    {
        public override INotification CreateNotification() => new SmsNotification();
    }

}
