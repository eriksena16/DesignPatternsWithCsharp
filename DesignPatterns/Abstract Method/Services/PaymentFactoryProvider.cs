using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    public class PaymentFactoryProvider : IPaymentFactoryProvider
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<string, Type> _factoryMap = new()
        {
            ["1"] = typeof(CreditCardPaymentFactory),
            ["2"] = typeof(DebitCardPaymentFactory),
            ["3"] = typeof(PixPaymentFactory),
            ["4"] = typeof(BoletoPaymentFactory)
        };

        public PaymentFactoryProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPaymentFactory GetFactory(string type)
        {
            if (_factoryMap.TryGetValue(type, out var factoryType))
            {
                return (IPaymentFactory)_serviceProvider.GetRequiredService(factoryType);
            }

            throw new NotSupportedException($"Payment Type '{type}' not supported.");
        }
    }



}