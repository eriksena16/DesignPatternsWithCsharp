namespace DesignPatterns
{
    // Concrete products for Credit Card
    public class CreditCardValidation : IPaymentValidator
    {
        public bool Validate(decimal value) => value >= 100M;
    }

}
