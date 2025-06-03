namespace DesignPatterns.Util
{
    public static class PaymentCalculator
    {
        public static decimal ApplyPercentageDiscount(decimal amount, decimal percent)
        => amount * (1 - percent / 100);
        public static decimal ApplyTransactionFee(decimal amount, decimal percent)
           => amount * (1 + percent / 100);

    }
}
