using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmMonthlyPayment : Form
    {
        Bussiness.Payment payment = new Bussiness.Payment();
        int idPlan;
        public FrmMonthlyPayment()
        {
            InitializeComponent();
        }

        public FrmMonthlyPayment(int idPlan)
        {
            InitializeComponent();
            LoadDataCashPayment(idPlan);
            CheckedDueDate();
        }

        private void CheckedDueDate()
        {
            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                DateTime dueDate = Convert.ToDateTime(row.Cells["duedate"].Value.ToString());

                if (DateTime.Now > dueDate && row.Cells["situation"].Value.ToString().ToLower() == "a receber")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            }
        }

        private void LoadDataCashPayment(int idPlan)
        {
            dgvDataPlan.Rows.Clear();

            this.idPlan = idPlan;
            var dataCashPayment = payment.SearchCashPaymentPlanMoney(idPlan);

            foreach (DataRow dr in dataCashPayment.Rows)
            {
                int countRow = dgvDataPlan.Rows.Add();

                txtName.Text = dr["name"].ToString();
                txtIdStudent.Text = dr["idStudent"].ToString();

                dgvDataPlan.Rows[countRow].Cells["receive"].Value = Properties.Resources.icons8_get_revenue_32px;
                dgvDataPlan.Rows[countRow].Cells["idCash"].Value = dr["idCash"].ToString();
                dgvDataPlan.Rows[countRow].Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px;
                dgvDataPlan.Rows[countRow].Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px;
                dgvDataPlan.Rows[countRow].Cells["id"].Value = dr["idCash"].ToString();
                dgvDataPlan.Rows[countRow].Cells["valueTotal"].Value = $"R$ {dr["value_total"]}";
                dgvDataPlan.Rows[countRow].Cells["valueDiscount"].Value = $"R$ {dr["value_discount"]}";

                if (string.IsNullOrEmpty(dr["payday"].ToString()))
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "A RECEBER";
                else
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "PAGO";

                dgvDataPlan.Rows[countRow].Cells["duedate"].Value = dr["duedate"].ToString();
                dgvDataPlan.Rows[countRow].Cells["payday"].Value = dr["payday"].ToString();
                dgvDataPlan.Rows[countRow].Cells["paymentTime"].Value = dr["payment_time"].ToString();

                dgvDataPlan.Rows[countRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmPayments(), this);
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();
            }
        }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();
                if (dgvDataPlan.CurrentCell.ColumnIndex == 0 && dgvDataPlan.CurrentRow.Cells["situation"].Value.ToString().ToLower() == "a receber")
                {
                    var effectPayment = new FrmEffectPayment(int.Parse(dgvDataPlan.CurrentRow.Cells["idCash"].Value.ToString()));
                    effectPayment.ShowDialog();
                    if (effectPayment.paymentEffected)
                    {
                        LoadDataCashPayment(idPlan);
                    }
                }
                else if (dgvDataPlan.CurrentCell.ColumnIndex == 0 && dgvDataPlan.CurrentRow.Cells["situation"].Value.ToString().ToLower() == "pago")
                {
                    MessageBox.Show("Esta mensalidade já foi paga!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
