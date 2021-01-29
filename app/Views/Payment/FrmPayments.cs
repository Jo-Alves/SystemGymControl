using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmPayments : Form
    {

        Bussiness.Plan plan = new Bussiness.Plan();

        public FrmPayments()
        {
            InitializeComponent();
            LoadDataPlan();
        }

        private void LoadDataPlan()
        {
            dgvDataPlan.Rows.Clear();

            DataTable dataPlan;

            if (string.IsNullOrEmpty(txtSearch.Text))
                dataPlan = plan.SearchAllWhereMoney();
            else
                dataPlan = plan.SearchPlanStudentWhereMoney(txtSearch.Text);

            foreach (DataRow dr in dataPlan.Rows)
            {
                int addRow = dgvDataPlan.Rows.Add();
                dgvDataPlan.Rows[addRow].Cells["pay"].Value = Properties.Resources.icons8_pay_32px;
                dgvDataPlan.Rows[addRow].Cells["idPlan"].Value = dr["idPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["datePurchasePlan"].Value = dr["date_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["timePurchasePlan"].Value = dr["time_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idStudent"].Value = dr["idStudent"].ToString();
                dgvDataPlan.Rows[addRow].Cells["name"].Value = dr["name"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idModality"].Value = dr["idModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionModality"].Value = dr["descriptionModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItemsPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["valuePlan"].Value = $"R$ {dr["valueItemsPackage"]}";
                dgvDataPlan.Rows[addRow].Cells["idFormOfPayment"].Value = dr["idFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["dateTerminalPlan"].Value = dr["date_terminal_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionFormOfPayment"].Value = dr["descriptionFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["IdPackage"].Value = dr["IdPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionPackage"].Value = dr["descriptionPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idSituationPlan"].Value = dr["idSituationPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["situation"].Value = dr["situation"].ToString();
                dgvDataPlan.Rows[addRow].Cells["deactivationDate"].Value = dr["deactivation_date"].ToString();
                dgvDataPlan.Rows[addRow].Cells["timeInactivated"].Value = dr["time_inactivated"].ToString();
                dgvDataPlan.Rows[addRow].Cells["dateTerminalPlanLast"].Value = dr["date_terminal_plan_last"].ToString();
                dgvDataPlan.Rows[addRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
            updateColorRowDataGridIfSituationPlanExpired();
        }

        private void updateColorRowDataGridIfSituationPlanExpired()
        {
            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                if (row.Cells["situation"].Value.ToString() == "Expirado")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
                    row.DefaultCellStyle.ForeColor = Color.White;

                    row.Cells["pay"].Value = Properties.Resources.icons8_pay_32px_2;
                }
            }
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

                if (dgvDataPlan.CurrentCell.ColumnIndex == 0)
                {
                    OpenForm.ShowForm(new FrmMonthlyPayment(int.Parse(dgvDataPlan.CurrentRow.Cells["idPlan"].Value.ToString()), dgvDataPlan.CurrentRow.Cells["descriptionPackage"].Value.ToString(), dgvDataPlan.CurrentRow.Cells["descriptionModality"].Value.ToString()), this);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            LoadDataPlan();
        }
    }
}