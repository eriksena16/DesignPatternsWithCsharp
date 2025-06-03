namespace DesignPatterns
{
    // Concrete Factories
    public class PixPaymentFactory : IPaymentFactory
    {
        public IPaymentValidator CreateValidator() => new PixValidator();
        public IPaymentProcessor CreateProcessor() => new PixProcessor();
    }

}
