namespace DesignPatterns
{
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentValidator CreateValidator() => new CreditCardValidation();
        public IPaymentProcessor CreateProcessor() => new CreditCardProcessor();
    }

}
