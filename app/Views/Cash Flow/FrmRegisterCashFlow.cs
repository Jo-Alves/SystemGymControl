using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmRegisterCashFlow : Form
    {
        CashFlow cashFlow = new CashFlow();
        bool searchRegisterPeriod = false;

        public FrmRegisterCashFlow()
        {
            InitializeComponent();
            LoadDataCashFlow();
        }

        private void LoadDataCashFlow()
        {
            try
            {
                DataTable dataCash = null;
                if (rbSearchAllRegister.Checked)
                    dataCash = cashFlow.SearchRegisterAll();
                else if (searchRegisterPeriod)
                    dataCash = cashFlow.SearchPeriod(dtDateInitial.Text, dtDateFinally.Text);

                if (rbSearchAllRegister.Checked || searchRegisterPeriod)
                {
                    dgvDataRegisterCashFlow.Rows.Clear();
                    decimal sumValueTotalCaixaInformed = 0.00M, sumValueTotalEntry = 0.00M, sumValueTotalExit = 0.00M, sumValueTotalBalance = 0.00M;

                    if (dataCash.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há registro!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    foreach (DataRow dr in dataCash.Rows)
                    {
                        int countRow = dgvDataRegisterCashFlow.Rows.Add();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["showResgisterEntryExit"].Value = Properties.Resources.icons8_cash_register_32px;
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["openingDate"].Value = dr["opening_date"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["openingTime"].Value = dr["opening_time"].ToString();

                        dgvDataRegisterCashFlow.Rows[countRow].Cells["closingDate"].Value = dr["closing_date"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["closingTime"].Value = dr["closing_time"].ToString();

                        decimal valueEntry = decimal.Parse(dr["cash_value_total"].ToString());
                        decimal valueExit = decimal.Parse(dr["output_value_total"].ToString());

                        dgvDataRegisterCashFlow.Rows[countRow].Cells["cashValueTotal"].Value = $"R$ {valueEntry}";
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["outputValueTotal"].Value = $"R$ {valueExit}";

                        if (!string.IsNullOrEmpty(dgvDataRegisterCashFlow.Rows[countRow].Cells["closingDate"].Value.ToString()))
                        {
                            decimal valueBalance = 0;

                            if (!string.IsNullOrEmpty(dr["balance"].ToString()))
                            {
                                valueBalance = decimal.Parse(dr["balance"].ToString());

                                dgvDataRegisterCashFlow.Rows[countRow].Cells["balance"].Value = $"R$ {valueBalance}";
                            }

                            decimal valueCaixaInformed = valueEntry + valueBalance;
                            dgvDataRegisterCashFlow.Rows[countRow].Cells["valueInformed"].Value = $"R$ {valueCaixaInformed}";


                            sumValueTotalCaixaInformed += valueCaixaInformed;
                            sumValueTotalEntry += valueEntry;
                            sumValueTotalExit += valueExit;
                            sumValueTotalBalance += valueBalance;

                            lblValueTotalBoxInformed.Text = $"R$ {sumValueTotalCaixaInformed}";
                            lblValueTotalEntry.Text = $"R$ {sumValueTotalEntry}";
                            lblValueTotalExit.Text = $"R$ {sumValueTotalExit}";
                            lblBalances.Text = $"R$ {sumValueTotalBalance}";
                        }

                        dgvDataRegisterCashFlow.Rows[countRow].MinimumHeight = 45;
                    }

                    searchRegisterPeriod = false;
                }

                dgvDataRegisterCashFlow.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbSearchRegisterPeriod_CheckedChanged(object sender, EventArgs e)
        {
            dtDateFinally.Enabled = true;
            dtDateInitial.Enabled = true;
            btnSearchRegister.Enabled = true;
        }

        private void rbSearchAllRegister_CheckedChanged(object sender, EventArgs e)
        {
            dtDateFinally.Enabled = false;
            dtDateInitial.Enabled = false;
            btnSearchRegister.Enabled = false;
            LoadDataCashFlow();
        }

        private void btnSearchRegister_Click(object sender, EventArgs e)
        {
            searchRegisterPeriod = true;
            LoadDataCashFlow();
        }

        private void dgvDataRegisterCashFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataRegisterCashFlow.ClearSelection();
            }
        }

        private void dgvDataRegisterCashFlow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataRegisterCashFlow.ClearSelection();
            }
        }
    }
}
