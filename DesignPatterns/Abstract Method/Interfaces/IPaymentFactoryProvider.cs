namespace DesignPatterns
{
    public interface IPaymentFactoryProvider
    {
        IPaymentFactory GetFactory(string type);
    }


}