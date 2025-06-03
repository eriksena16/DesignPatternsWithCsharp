namespace DesignPatterns
{
    public class DebitCardPaymentFactory : IPaymentFactory
    {
        public IPaymentValidator CreateValidator() => new DebitCardValidation();
        public IPaymentProcessor CreateProcessor() => new DebitCardProcessor();
    }

}
