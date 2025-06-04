namespace DesignPatterns.Builder
{
    public class ReportBuilder
{
    private readonly Report _report = new();

    public ReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public ReportBuilder WithHeader(string header)
    {
        _report.Header = header;
        return this;
    }

    public ReportBuilder WithFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public ReportBuilder WithCharts()
    {
        _report.IncludeCharts = true;
        return this;
    }

    public Report Build()
    {
        
        return _report;
    }
}

}
