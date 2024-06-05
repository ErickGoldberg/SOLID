namespace SOLID.ISP
{
    public class PdfReport : IPdfReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating PDF report...");
        }

        public void ExportToPdf()
        {
            Console.WriteLine("Exporting report to PDF...");
        }
    }

    public class ExcelReport : IExcelReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Excel report...");
        }

        public void ExportToExcel()
        {
            Console.WriteLine("Exporting report to Excel...");
        }
    }

}
