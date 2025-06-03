namespace DesignPatterns
{
    // Concrete products for PayPal
    public class PayPalValidator : IPaymentValidator
    {
        public bool Validate(decimal value) => value > 0M;
    }

}
