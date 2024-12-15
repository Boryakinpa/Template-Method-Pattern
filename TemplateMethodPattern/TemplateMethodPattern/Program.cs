using TemplateMethodPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ReportGenerator studentReportGenerator = new StudentReportGenerator();
        ReportGenerator courseReportGenerator = new CourseReportGenerator();

        studentReportGenerator.GenerateReport();
        Console.WriteLine();
        courseReportGenerator.GenerateReport();
    }
}