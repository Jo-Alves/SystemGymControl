using Bussiness;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmPaymentHistory : Form
    {
        Payment payment = new Payment();

        public FrmPaymentHistory()
        {
            InitializeComponent();
            LoadDataHistoryPayment();
        }

        private void LoadDataHistoryPayment()
        {
            dgvDataPayment.Rows.Clear();
            DataTable dataHistoryPayment = string.IsNullOrWhiteSpace(txtSearch.Text) ?
                payment.GetHistoryPaymentDifferencesMonthly() :
                payment.GetHistoryPaymentDifferencesMonthlySearchNameStudent(txtSearch.Text);

            foreach (DataRow dr in dataHistoryPayment.Rows)
            {
                int countRow = dgvDataPayment.Rows.Add();

                dgvDataPayment.Rows[countRow].Cells["receipt"].Value = Resources.icons8_receipt_32px;
                dgvDataPayment.Rows[countRow].Cells["name"].Value = dr["name"].ToString();
                dgvDataPayment.Rows[countRow].Cells["description"].Value = dr["description"].ToString();
                dgvDataPayment.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                dgvDataPayment.Rows[countRow].Cells["valueTotal"].Value = $"R$ {dr["value_total"]}";
                dgvDataPayment.Rows[countRow].Cells["valueDiscount"].Value = $"R$ {dr["value_discount"]}";
                dgvDataPayment.Rows[countRow].Cells["payday"].Value = dr["payday"].ToString();
                dgvDataPayment.Rows[countRow].Cells["paymentTime"].Value = dr["payment_time"].ToString();

                dgvDataPayment.Rows[countRow].MinimumHeight = 45;
            }

            dgvDataPayment.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmOptionsPayment(), this);
            FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataHistoryPayment();
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPayment.ClearSelection();
            }
        }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if(dgvDataPayment.CurrentCell.ColumnIndex == 0)
                {
                    int idPayment = Convert.ToInt32(dgvDataPayment.CurrentRow.Cells["id"].Value);
                    if (bool.Parse(Settings.Default["optionPreviewIsDirecty"].ToString()))
                    {
                        string path = Path.GetDirectoryName(Application.ExecutablePath);
                        string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Views\Report\Recibo de Pagamento.rdlc";

                        CreateReceipt.GenerateReceipt(idPayment, fullPath);
                    }
                    else
                        OpenForm.ShowForm(new FrmReportReceipt(idPayment, 0, 0, true), this);
                }
                dgvDataPayment.ClearSelection();
            }
        }
    }
}
