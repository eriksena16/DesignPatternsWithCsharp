using DesignPatterns.Util;

namespace DesignPatterns
{
    public class PixProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing PIX payment...");
            Task.Delay(2000).Wait();

            var finalAmount = PaymentCalculator.ApplyPercentageDiscount(amount, 5); 

            Console.WriteLine("***********************************************");
            Console.WriteLine($"Purchase tolal amount: ${finalAmount}");
            Console.WriteLine($"Discount amount: ${(amount - finalAmount)}");
            Console.WriteLine("***********************************************");
        }
            
    }

}
