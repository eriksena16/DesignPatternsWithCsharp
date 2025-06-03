namespace DesignPatterns
{
    // Abstract products
    public interface IPaymentValidator
    {
        bool Validate(decimal value);
    }

}
