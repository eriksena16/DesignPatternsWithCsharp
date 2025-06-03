using DesignPatterns.Util;

namespace DesignPatterns
{
    public class BoletoProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Boleto payment...");
            Task.Delay(1000).Wait(); // Simulate processing delay

            var finalAmount = PaymentCalculator.ApplyTransactionFee(amount, 0);

            Console.WriteLine("***********************************************");
            Console.WriteLine($"Purchase tolal amount: $ {finalAmount.ToString("F2")}");
            Console.WriteLine("***********************************************");
        }

    }
}