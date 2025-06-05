using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype.Entities
{
    public class ReportDocument : IPrototype<ReportDocument>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public ReportDocument(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public ReportDocument Clone()
        {
            // Shallow copy is fine here, but you could deep clone if needed
            return new ReportDocument(Title, Author);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[Report] Title: {Title}, Author: {Author}");
        }
    }

}
