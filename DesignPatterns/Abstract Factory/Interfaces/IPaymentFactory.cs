namespace DesignPatterns
{
    // Abstract Factory
    public interface IPaymentFactory
    {
        IPaymentValidator CreateValidator();
        IPaymentProcessor CreateProcessor();
    }

}
