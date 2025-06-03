namespace DesignPatterns
{
    // Concrete products for Credit Card
    public class CreditCardValidation : IPaymentValidator
    {
        public bool Validate(decimal value) => value > 0M && value >= 100M;
    }

}
