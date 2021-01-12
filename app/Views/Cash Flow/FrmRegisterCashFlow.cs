using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (rbSearchRegisterDiary.Checked)
                    dataCash = cashFlow.SearchID(FrmGymControl.Instance._IdCashFlow);
                else if (rbSearchAllRegister.Checked)
                    dataCash = cashFlow.SearchAll();
                else if (searchRegisterPeriod) 
                    dataCash = cashFlow.SearchPeriod(dtDateInitial.Text, dtDateFinally.Text);


                if (rbSearchAllRegister.Checked || rbSearchRegisterDiary.Checked || searchRegisterPeriod)
                {
                    dgvDataRegisterCashFlow.Rows.Clear();

                    foreach (DataRow dr in dataCash.Rows)
                    {
                        int countRow = dgvDataRegisterCashFlow.Rows.Add();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["openingDate"].Value = dr["opening_date"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["openingTime"].Value = dr["opening_time"].ToString();
                        
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["closingDate"].Value = dr["closing_date"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["closingTime"].Value = dr["closing_time"].ToString();
                        dgvDataRegisterCashFlow.Rows[countRow].Cells["outputValueTotal"].Value = $"R$ {dr["output_value_total"]}";

                        decimal valueEntry = decimal.Parse(dr["cash_value_total"].ToString());

                        dgvDataRegisterCashFlow.Rows[countRow].Cells["cashValueTotal"].Value = $"R$ {valueEntry}";


                        if (!string.IsNullOrEmpty(dgvDataRegisterCashFlow.Rows[countRow].Cells["closingDate"].Value.ToString()))
                        {
                            decimal valueBalance = 0;

                            if (!string.IsNullOrEmpty(dr["balance"].ToString()))
                            {
                                valueBalance = decimal.Parse(dr["balance"].ToString());

                                dgvDataRegisterCashFlow.Rows[countRow].Cells["balance"].Value = $"R$ {valueBalance}";
                            }

                            dgvDataRegisterCashFlow.Rows[countRow].Cells["valueInformed"].Value = $"R$ {(valueEntry + valueBalance)}";
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

        private void rbSearchRegisterDiary_CheckedChanged(object sender, EventArgs e)
        {
            dtDateFinally.Enabled = false;
            dtDateInitial.Enabled = false;
            btnSearchRegister.Enabled = false;

            LoadDataCashFlow();
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
            LoadDataCashFlow();
            searchRegisterPeriod = true;
        }
    }
}
