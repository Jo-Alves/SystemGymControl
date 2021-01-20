using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportCashFlow : Form
    {
        CashFlow cash = new CashFlow();

        public FrmReportCashFlow()
        {
            InitializeComponent();
            LoadInitialFields();
        }

        private void LoadInitialFields()
        {
            int idCashPrevious = cash.GetMaxCashFlowIdDatePrevious(cash.GetMaxCashFlowID());
            txtBoxBalancePrevious.Text = $"R$ {cash.SearchID(idCashPrevious).Rows[0]["cash_value_total"]}";
        }
    }
}
