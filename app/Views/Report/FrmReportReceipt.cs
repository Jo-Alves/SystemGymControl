using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportReceipt : Form
    {
        int idPlan, idPackage;
        string modality, package;
        bool isHistoryPayment;


        public FrmReportReceipt()
        {
            InitializeComponent();
        }

        public FrmReportReceipt(int idPayment, int idPlan = 0, int idPackage = 0, bool isHistoryPayment = false)
        {
            InitializeComponent();

            this.idPlan = idPlan;
            this.idPackage = idPackage;
            this.isHistoryPayment = isHistoryPayment;

            this.rvReceipt.LocalReport.SetParameters(ParametersReport.SetParametersReport(new Payment().GetDataPayments(idPayment)));
            this.rvReceipt.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (idPlan > 0)
                OpenForm.ShowForm(new FrmMonthlyPayment(idPlan, package, modality, idPackage), this);
            else if (isHistoryPayment)
                OpenForm.ShowForm(new FrmPaymentHistory(), this);
            else
                OpenForm.ShowForm(new FrmPlans(), this);
        }
    }
}
