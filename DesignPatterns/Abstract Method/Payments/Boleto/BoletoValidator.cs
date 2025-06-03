namespace DesignPatterns
{
    // Concrete products for Boleto
    public class BoletoValidator : IPaymentValidator
    {
        public bool Validate(decimal value) => value >= 50;
    }

}
