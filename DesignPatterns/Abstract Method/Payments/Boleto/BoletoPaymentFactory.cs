namespace DesignPatterns
{
    public class BoletoPaymentFactory : IPaymentFactory
    {
        public IPaymentValidator CreateValidator() => new BoletoValidator();
        public IPaymentProcessor CreateProcessor() => new BoletoProcessor();
    }

}
