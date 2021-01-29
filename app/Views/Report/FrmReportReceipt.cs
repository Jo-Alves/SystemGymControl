using Bussiness;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmReportReceipt : Form
    {
        int idPlan;
        string modality, package;


        public FrmReportReceipt()
        {
            InitializeComponent();
        }

        public FrmReportReceipt(int idPayment, string modality, string package, string formPayment, string name, int daysDelay, DateTime datePayment, bool calculateInaterastAndPenalty, string total, DateTime duedate, int idPlan, string valuePackage)
        {
            InitializeComponent();

            this.idPlan = idPlan;
            this.modality = modality;
            this.package = package;

            var dataPayment = new Payment().SearchCashPaymentPlanIDCash(idPayment);
            this.rvReceipt.LocalReport.SetParameters(SetParametersReport(dataPayment, name, datePayment, formPayment, modality, package, daysDelay, calculateInaterastAndPenalty, total, duedate, valuePackage));
            this.rvReceipt.RefreshReport();

        }

        private ReportParameterCollection SetParametersReport(DataTable dataPayment, string name, DateTime datePayment, string formPayment, string modality, string package, int daysDelay, bool calculateInaterastAndPenalty, string total, DateTime duedate, string valuePackage)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("name", name));
            reportParameters.Add(new ReportParameter("date", datePayment.ToShortDateString()));
            reportParameters.Add(new ReportParameter("time", datePayment.ToLongTimeString()));
            reportParameters.Add(new ReportParameter("package", package));
            reportParameters.Add(new ReportParameter("modality", modality));
            reportParameters.Add(new ReportParameter("value", valuePackage));
            reportParameters.Add(new ReportParameter("discount", $"R$ {dataPayment.Rows[0]["value_discount"]}"));
            reportParameters.Add(new ReportParameter("interest", daysDelay > 0 && calculateInaterastAndPenalty ? $"R$ {dataPayment.Rows[0]["value_interest"]}" : "R$ 0,00"));
            reportParameters.Add(new ReportParameter("penalty", daysDelay > 0 && calculateInaterastAndPenalty ? $"R$ {dataPayment.Rows[0]["value_penalty"]}" : "R$ 0,00"));
            reportParameters.Add(new ReportParameter("total", total));
            reportParameters.Add(new ReportParameter("nPortions", "1"));
            reportParameters.Add(new ReportParameter("formPayment", formPayment));
            reportParameters.Add(new ReportParameter("duedate", duedate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("nameFantasy", Settings.Default["nameFantasy"].ToString()));
            reportParameters.Add(new ReportParameter("cnpj", Settings.Default["CNPJ"].ToString()));
            reportParameters.Add(new ReportParameter("phone", Settings.Default["phone"].ToString()));

            return reportParameters;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmMonthlyPayment(idPlan, package, modality), this);
        }
    }
}
