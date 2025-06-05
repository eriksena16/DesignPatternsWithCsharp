using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype.Entities
{
    public class Document : IPrototype<Document>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

        public Document(string title, string content, List<string> tags)
        {
            Title = title;
            Content = content;
            Tags = tags;
        }

        public Document Clone()
        {
            return new Document(Title, Content, new List<string>(Tags));
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
            Console.WriteLine();
        }
    }

}
