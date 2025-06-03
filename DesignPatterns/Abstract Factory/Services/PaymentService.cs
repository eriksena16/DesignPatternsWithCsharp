namespace DesignPatterns
{
    public class PaymentService
    {
        private readonly IPaymentFactoryProvider _factoryProvider;

        public PaymentService(IPaymentFactoryProvider factoryProvider)
        {
            _factoryProvider = factoryProvider;
        }

        public void Process(string type, decimal value)
        {
            var factory = _factoryProvider.GetFactory(type);
            var validator = factory.CreateValidator();
            var processor = factory.CreateProcessor();

            Console.WriteLine($"Validate and processing {GetPaymentDescription(type)}...");
            Task.Delay(2000).Wait();

            if (validator.Validate(value))
                processor.ProcessPayment(value);
            else
                Console.WriteLine("Validation failed.");
        }
        public static string GetPaymentDescription(string paymentType)
        {
            return paymentType switch
            {
                "1" => "Payment Type: 1 - CreditCard (Tax 5%)",
                "2" => "Payment Type: 2 - DebitCard (Tax 1%)",
                "3" => "Payment Type: 3 - Pix (Discount 5%)",
                "4" => "Payment Type: 4 - Boleto",
                "5" => "Payment Type: 5 - PayPal (Fee 4%)",
                "0" => "Returning to menu...",
                _ => "Invalid choice, please try again."
            };
        }

    }

}