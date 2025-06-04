namespace DesignPatterns.Builder
{
    public class Report
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public bool IncludeCharts { get; set; }

        public void Display()
        {
            Console.WriteLine($"--- {Title} ---");
            Console.WriteLine(Header);
            if (IncludeCharts)
            {
                Console.WriteLine("[Charts Included]");
            }
            Console.WriteLine(Footer);
            Console.WriteLine("------------------");
        }
    }

}
