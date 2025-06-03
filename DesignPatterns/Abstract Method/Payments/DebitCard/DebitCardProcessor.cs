using DesignPatterns.Util;

namespace DesignPatterns
{
    public class DebitCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Debit Card payment...");

            Task.Delay(2000).Wait(); // Simulate processing delay
            var finalAmount = PaymentCalculator.ApplyTransactionFee(amount, 1); // 1% tax for debit card

            Console.WriteLine("***********************************************");
            Console.WriteLine($"Purchase tolal amount: $ {finalAmount.ToString("F2")}");
            Console.WriteLine("***********************************************");
        }

    }
}