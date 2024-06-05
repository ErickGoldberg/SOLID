namespace SOLID.ISP
{
    public interface IReport
    {
        void Generate();
    }

    public interface IPdfReport : IReport
    {
        void ExportToPdf();
    }

    public interface IExcelReport : IReport
    {
        void ExportToExcel();
    }

}
