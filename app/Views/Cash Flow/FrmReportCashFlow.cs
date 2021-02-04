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
        OutgoingCashFlow outgoingCashFlow = new OutgoingCashFlow();

        public FrmReportCashFlow()
        {
            InitializeComponent();
            string mouthAndYearNow = DateTime.Now.ToShortDateString().Substring(3, 7);
            int idCashFlowCurrent = FrmGymControl.Instance._IdCashFlow;
            LoadInitialFieldsCashFlowAndBank(idCashFlowCurrent, mouthAndYearNow);
        }

        public FrmReportCashFlow(int idCash, string entryDate)
        {
            InitializeComponent();
            LoadInitialFieldsCashFlowAndBank(idCash, entryDate.Substring(3, 7));
        }

        private void LoadInitialFieldsCashFlowAndBank(int idCashFlowCurrent, string mouthAndYear)
        {
            try
            {
                var dataCashFlow = cash.SearchID(idCashFlowCurrent);

                int idCashPrevious = cash.GetMaxCashFlowIdDatePrevious(idCashFlowCurrent);

                // BOX
                txtBoxBalancePrevious.Text = idCashPrevious > 0 ? $"R$ {icomingCashFlow.GetSumAllValueEntryMoney(idCashPrevious, mouthAndYear)}" : "R$ 0,00";

                txtBoxEntry.Text = $"R$ {icomingCashFlow.GetSumValueEntryMoney(idCashFlowCurrent)}";
                txtBoxExit.Text = $"R$ {dataCashFlow.Rows[0]["output_value_total"]}";
                txtBalanceCurrent.Text = $"R$ {(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxEntry.Text)) - decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxExit.Text)))}";
                txtBoxClosure.Text = $"R$ {(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxBalancePrevious.Text)) + decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxEntry.Text)) - decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxExit.Text)))}";

                LoadDgvBoxIcoming(icomingCashFlow.GetDataIcomingIdCash(idCashFlowCurrent));
                LoadDgvBoxOutgoing(outgoingCashFlow.GetDataOutgoingIdCash(idCashFlowCurrent));

                // BANK

                txtBankEntry.Text = $"R$ {icomingCashFlow.GetSumValueEntryCard(idCashFlowCurrent)}";
                txtBankBalancePrevious.Text = idCashPrevious > 0 ? $"R$ {icomingCashFlow.GetSumAllValueEntryCard(idCashPrevious, mouthAndYear)}" : "R$ 0,00";
                txtBankBalanceCurrent.Text = txtBankEntry.Text;
                txtBankClosure.Text = $"R$ {(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBankBalancePrevious.Text)) + decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBankEntry.Text)))}";

                lblBalanceBankWhithBox.Text = $"R$ {(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBankClosure.Text)) + decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtBoxClosure.Text)))}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgvBoxOutgoing(DataTable dataOutgoingCashFlow)
        {
            foreach (DataRow dr in dataOutgoingCashFlow.Rows)
            {
                int countRow = dgvDataBox.Rows.Add();
                dgvDataBox.Rows[countRow].Cells["date"].Value = dr["exit_date"].ToString();
                dgvDataBox.Rows[countRow].Cells["description"].Value = dr["description_exit"].ToString();
                dgvDataBox.Rows[countRow].Cells["valueEntry"].Value = " --- ";
                dgvDataBox.Rows[countRow].Cells["valueExit"].Value = $"R$ {dr["value_output"]}";

                dgvDataBox.Rows[countRow].MinimumHeight = 40;
            }

            dgvDataBox.ClearSelection();
        }

        private void LoadDgvBoxIcoming(DataTable dataIcomingCashFlow)
        {
            foreach (DataRow dr in dataIcomingCashFlow.Rows)
            {

                if (decimal.Parse(dr["value_money"].ToString()) > 0.00M)
                {
                    int countRow = dgvDataBox.Rows.Add();
                    dgvDataBox.Rows[countRow].Cells["date"].Value = dr["entry_date"].ToString();
                    dgvDataBox.Rows[countRow].Cells["description"].Value = dr["description_icoming"].ToString();
                    dgvDataBox.Rows[countRow].Cells["valueEntry"].Value = $"R$ {dr["value_money"]}";
                    dgvDataBox.Rows[countRow].Cells["valueExit"].Value = " --- ";

                    dgvDataBox.Rows[countRow].MinimumHeight = 40;
                    dgvDataBox.ClearSelection();
                }
                if (decimal.Parse(dr["value_card"].ToString()) > 0.00M)
                {
                    int countRow = dgvDataBank.Rows.Add();
                    dgvDataBank.Rows[countRow].Cells["bankDateEntry"].Value = dr["entry_date"].ToString();
                    dgvDataBank.Rows[countRow].Cells["bankDescription"].Value = dr["description_icoming"].ToString();
                    dgvDataBank.Rows[countRow].Cells["valueBankEntry"].Value = $"R$ {dr["value_card"]}";
                    dgvDataBank.Rows[countRow].Cells["valueBankExit"].Value = " --- ";

                    dgvDataBank.Rows[countRow].MinimumHeight = 40;
                    dgvDataBank.ClearSelection();
                }
            }

        }

        private void dgvDataBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataBox.ClearSelection();
            }
        }

        private void dgvDataBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataBox.ClearSelection();
            }
        }

        private void dgvDataBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataBank.ClearSelection();
            }
        }

        private void dgvDataBank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataBank.ClearSelection();
            }
        }
    }
}