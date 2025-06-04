using DesignPatterns.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace DesignPatterns
{
    public static class MenuFacturyProvider
    {
        public static void ShowMenu()
        {
            Console.WriteLine("********* Design Patterns *********");
            Console.WriteLine("****** Menu 1 ******");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Builder");
            Console.WriteLine("0 - Exit");

            string menuOption = Console.ReadLine();
            if (string.IsNullOrEmpty(menuOption))
            {
                Console.WriteLine("Invalid option. Please try again.");
                return;
            }
            switch (menuOption)
            {
                case "1":
                    ShowMenuAbstract();
                    break;
                case "2":
                    ShowMenuFactory();
                    break;
                case "3":
                    ShowMenuBuilder();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    ShowMenu();
                    break;
            }
        }
        public static void ShowMenuFactory()
        {

            Console.WriteLine("****** 2 - Factory Method ******");
            Console.WriteLine("Type your menssage: Ex: Meeting at 6 PM");
            string message = Console.ReadLine();

            Console.WriteLine("Type Menssage:");
            Console.WriteLine("1 - Email");
            Console.WriteLine("2 - SMS");
            Console.WriteLine("0 - Back");

            string typeMessage = Console.ReadLine();

            if (typeMessage == "0") ShowMenu();

            var notificationService = App.Host.Services.GetRequiredService<NotificationService>();
            notificationService.Send(typeMessage, message);

            ShowMenuFactory();
        }
        public static void ShowMenuAbstract()
        {

            Console.WriteLine("****** 1 - Abstract Factory ******");
            Console.WriteLine("Type purchase amount: Ex 65.50");
            string purchaseamount = Console.ReadLine();

            Console.WriteLine("Type payment type:");
            Console.WriteLine("1 - CreditCard (Fee 5%)");
            Console.WriteLine("2 - DebitCard (Fee 1%)");
            Console.WriteLine("3 - Pix (Discount 5%)");
            Console.WriteLine("4 - Boleto");
            Console.WriteLine("5 - PayPal (Fee 4%)");
            Console.WriteLine("0 - Back");

            string paymentType = Console.ReadLine();

            if (paymentType == "0") ShowMenu();

            var paymentService = App.Host.Services.GetRequiredService<PaymentService>();
            paymentService.Process(paymentType, decimal.Parse(purchaseamount, CultureInfo.InvariantCulture));

            ShowMenuAbstract();
        }
        public static void ShowMenuBuilder()
        {
            Console.WriteLine("****** 3 - Builder ******");

            Console.WriteLine("Type Report:");
            Console.WriteLine("1 - Report");
            Console.WriteLine("0 - Back");

            string typeReport= Console.ReadLine();

            if (typeReport == "0") ShowMenu();

            Console.WriteLine("Type report title: Ex: Monthly Report");
            string title = Console.ReadLine();
            Console.WriteLine("Type report header: Ex: Header Information");
            string header = Console.ReadLine();
            Console.WriteLine("Type report footer: Ex: Footer Information");
            string footer = Console.ReadLine();
            Console.WriteLine("Include charts? (yes/no)");
            string includeCharts = Console.ReadLine()?.ToLower();

            var reportBuilder = new ReportBuilder()
                .WithTitle(title)
                .WithHeader(header)
                .WithFooter(footer);

            if (includeCharts == "yes")
                reportBuilder = reportBuilder.WithCharts();

            var report = reportBuilder.Build();

            report.Display();

            ShowMenuBuilder();
        }
    }
}
