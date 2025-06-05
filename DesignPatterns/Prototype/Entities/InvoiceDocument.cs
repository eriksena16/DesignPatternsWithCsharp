using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype.Entities
{
    public class InvoiceDocument : IPrototype<InvoiceDocument>
    {
        public int InvoiceNumber { get; set; }
        public decimal Amount { get; set; }

        public InvoiceDocument(int invoiceNumber, decimal amount)
        {
            InvoiceNumber = invoiceNumber;
            Amount = amount;
        }

        public InvoiceDocument Clone()
        {
            return new InvoiceDocument(InvoiceNumber, Amount);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[Invoice] Number: {InvoiceNumber}, Amount: {Amount:C}");
        }
    }

}
