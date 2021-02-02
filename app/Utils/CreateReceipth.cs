using Bussiness;
using Microsoft.Reporting.WinForms;

namespace SystemGymControl
{
    class CreateReceipt
    {
        public static void GenerateReceipt(int idPayment, string fullPath)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = fullPath;
            localReport.SetParameters(ParametersReport.SetParametersReport(new Payment().GetDataPayments(idPayment)));
            localReport.PrintToPrinter();
        }
    }
}
