using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmMonthlyPayment : Form
    {
        Bussiness.CashPayment cashPayment = new Bussiness.CashPayment();

        public FrmMonthlyPayment()
        {
            InitializeComponent();
        }

        public FrmMonthlyPayment(int idPlan)
        {
            InitializeComponent();
            LoadDataCashPayment(idPlan);
        }

        private void LoadDataCashPayment(int idPlan)
        {
            var dataCashPayment = cashPayment.SearchCashPaymentPlanMoney(idPlan);

            foreach (DataRow row in dataCashPayment.Rows)
            {
                int countRow = dgvDataPlan.Rows.Add();

                txtName.Text = row["name"].ToString();
                txtIdStudent.Text = row["idStudent"].ToString();

                dgvDataPlan.Rows[countRow].Cells["receive"].Value = Properties.Resources.icons8_get_revenue_32px;
                dgvDataPlan.Rows[countRow].Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px;
                dgvDataPlan.Rows[countRow].Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px;
                dgvDataPlan.Rows[countRow].Cells["id"].Value = row["idCash"].ToString();
                dgvDataPlan.Rows[countRow].Cells["valueTotal"].Value = $"R$ {row["value_total"]}";
                dgvDataPlan.Rows[countRow].Cells["valueDiscount"].Value = $"R$ {row["value_discount"]}";

                if (string.IsNullOrEmpty(row["payday"].ToString()))
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "A RECEBER";
                else
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "PAGO";
                
                dgvDataPlan.Rows[countRow].Cells["duedate"].Value = row["duedate"].ToString();
                dgvDataPlan.Rows[countRow].Cells["payday"].Value = row["payday"].ToString();
                dgvDataPlan.Rows[countRow].Cells["paymentTime"].Value = row["payment_time"].ToString();

                dgvDataPlan.Rows[countRow].MinimumHeight = 45;               
            }

            dgvDataPlan.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmPayment(), this);
        }
    }
}
