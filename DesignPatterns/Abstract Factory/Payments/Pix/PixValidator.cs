namespace DesignPatterns
{
    // Concrete products for PIX
    public class PixValidator : IPaymentValidator
    {
        public bool Validate(decimal value) => value > 0M;
    }

}
