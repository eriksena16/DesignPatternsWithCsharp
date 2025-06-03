namespace DesignPatterns
{
    // Concrete products for Debit Card
    public class DebitCardValidation : IPaymentValidator
    {
        public bool Validate(decimal value) => value > 0M && value >= 60M;
    }

}
