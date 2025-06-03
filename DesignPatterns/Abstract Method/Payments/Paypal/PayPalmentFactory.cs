namespace DesignPatterns
{
    // Concrete Factories
    public class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentValidator CreateValidator() => new PayPalValidator();
        public IPaymentProcessor CreateProcessor() => new PayPalProcessor();
    }

}
