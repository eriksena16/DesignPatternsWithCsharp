using DesignPatterns.Util;

namespace DesignPatterns
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Credit Card payment...");
            Task.Delay(2000).Wait(); // Simulate processing delay

            var finalAmount = PaymentCalculator.ApplyTransactionFee(amount, 5); // 5% tax for credit card

            Console.WriteLine("***********************************************");
            Console.WriteLine($"Purchase tolal amount: $ {finalAmount.ToString("F2")}");
            Console.WriteLine("***********************************************");
        }

    }
}