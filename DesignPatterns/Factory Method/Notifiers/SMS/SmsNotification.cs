namespace DesignPatterns.Factory_Method
{
    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"SMS: {message}");
    }

}
