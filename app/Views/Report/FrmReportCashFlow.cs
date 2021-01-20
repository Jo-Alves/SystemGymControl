using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportCashFlow : Form
    {
        CashFlow cash = new CashFlow();
        IcomingCashFlow icomingCashFlow = new IcomingCashFlow();

        public FrmReportCashFlow()
        {
            InitializeComponent();
            LoadInitialFields();
        }

        private void LoadInitialFields()
        {
            try
            {
                int idCashFlowCurrent = FrmGymControl.Instance._IdCashFlow;

                var dataCashFlow = cash.SearchID(idCashFlowCurrent);

                int idCashPrevious = cash.GetMaxCashFlowIdDatePrevious(cash.GetMaxCashFlowID());

                // BOX

                txtBoxBalancePrevious.Text = idCashPrevious > 0 ? $"R$ {cash.SearchID(idCashPrevious).Rows[0]["cash_value_total"]}" : "R$ 0,00";

                txtBoxEntry.Text = $"R$ {icomingCashFlow.GetSumValueEntryMoney(idCashFlowCurrent)}";
                txtBoxExit.Text = $"R$ {dataCashFlow.Rows[0]["output_value_total"]}";
                txtBalanceCurrent.Text = $"R$ {(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxEntry.Text)) - decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxExit.Text)))}";

                // BANK

                txtBankEntry.Text = $"R$ {icomingCashFlow.GetSumValueEntryCard(idCashFlowCurrent)}";

                LoadDgvBox(icomingCashFlow.GetDataIcomingIdCash(idCashFlowCurrent));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgvBox(DataTable dataCashFlow)
        {
            foreach(DataRow dr in dataCashFlow.Rows)
            {
                int countRow = dgvDataBox.Rows.Add();
                dgvDataBox.Rows[countRow].Cells["date"].Value = dr["entry_date"].ToString();
                dgvDataBox.Rows[countRow].Cells["description"].Value = dr["description_icoming"].ToString();
                dgvDataBox.Rows[countRow].Cells["valueEntry"].Value = $"R$ {dr["value_money"]}";
                dgvDataBox.Rows[countRow].Cells["valueExit"].Value = " --- ";

                dgvDataBox.Rows[countRow].MinimumHeight = 45;
            }

            dgvDataBox.ClearSelection();
        }
    }
}