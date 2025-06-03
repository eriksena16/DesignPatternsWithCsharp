using DesignPatterns.Util;

namespace DesignPatterns
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing PayPal payment...");
            Task.Delay(2000).Wait();

            var finalAmount = PaymentCalculator.ApplyTransactionFee(amount, 4); 

            Console.WriteLine("***********************************************");
            Console.WriteLine($"Purchase tolal amount: ${finalAmount}");
            Console.WriteLine($"Fee amount: ${amount - finalAmount}");
            Console.WriteLine("***********************************************");
        }
            
    }

}
