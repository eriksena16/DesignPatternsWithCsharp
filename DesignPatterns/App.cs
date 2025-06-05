using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesignPatterns
{
    public static class App
    {
        public static readonly IHost Host = BuildHost();

        private static IHost BuildHost() =>
            HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddScoped<PixPaymentFactory>();
                    services.AddScoped<DebitCardPaymentFactory>();
                    services.AddScoped<CreditCardPaymentFactory>();
                    services.AddScoped<BoletoPaymentFactory>();
                    services.AddScoped<PayPalPaymentFactory>();

                    services.AddSingleton<IPaymentFactoryProvider, PaymentFactoryProvider>();
                    services.AddSingleton<INotificationFactoryProvider, NotificationFactoryProvider>();

                    services.AddTransient<PaymentService>();
                    services.AddTransient<NotificationService>();
                })
                .Build();

        private static IHostBuilder HostBuilder() =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder();
    }
}
