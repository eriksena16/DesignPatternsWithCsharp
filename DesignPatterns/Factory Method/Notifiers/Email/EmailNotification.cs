namespace DesignPatterns.Factory_Method
{
    // Concrete products
    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Email: {message}");
    }

}
