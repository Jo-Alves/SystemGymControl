using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmPlan : Form
    {
        Plan plan = new Plan();
        SituationsPlan situationsPlan = new SituationsPlan();

        public FrmPlan()
        {
            InitializeComponent();
            LoadDataPackages();
            UpdateTimeInactivated();
        }

        // atualiza a coluna da tabela timeInactivated incrementado se o plano estiver inativado
        private void UpdateTimeInactivated()
        {
            TimeSpan time;

            foreach(DataGridViewRow dgv in dgvDataPlan.Rows)
            {
                if(dgv.Cells["situation"].Value.ToString() == "Inativo")
                {
                    dgvDataPlan.Columns["dateTerminalPlanExtended"].Visible = true;
                    dgvDataPlan.Columns["timeInactivated"].Visible = true;
                    dgvDataPlan.Columns["deactivationDate"].Visible = true;
                    int idSituation = int.Parse(dgv.Cells["idSituationPlan"].Value.ToString());

                    var dateTerminal = Convert.ToDateTime(dgv.Cells["dateTerminalPlan"].Value.ToString());
                    var deactivationDate = Convert.ToDateTime(dgv.Cells["deactivationDate"].Value.ToString());

                    /*
                        * subtrai a data de atual com a data da desativação do plano para
                        * pegar a diferença das datas e aumentar o prazo do término
                     */
                    time = DateTime.Now.Subtract(deactivationDate);

                    situationsPlan._timeInactivated = time.Days;
                    plan._dateTerminalPlanExtended = dateTerminal.AddDays(time.Days).ToShortDateString();
                    situationsPlan.updateTimeInactivated(idSituation);

                    plan.UpdateTerminalPlanExtended(int.Parse(dgv.Cells["idPlan"].Value.ToString()));

                    dgv.Cells["dateTerminalPlanExtended"].Value = plan._dateTerminalPlanExtended;
                   if (time.Days == 1)
                    {
                        dgv.Cells["timeInactivated"].Value = $"{time.Days} dia";
                    }
                   else
                        dgv.Cells["timeInactivated"].Value = $"{time.Days} dias";
                }
            }
        }

        private void LoadDataPackages()
        {
            dgvDataPlan.Rows.Clear();

            DataTable dataPlan;

            if (string.IsNullOrEmpty(txtSearch.Text))
                dataPlan = plan.SearchAll();
            else
                dataPlan = plan.SearchPlanNameStudent(txtSearch.Text);

            foreach (DataRow dr in dataPlan.Rows)
            {
                int addRow = dgvDataPlan.Rows.Add();
                dgvDataPlan.Rows[addRow].Cells["showDetails"].Value = Properties.Resources.icons8_details_32px;
                dgvDataPlan.Rows[addRow].Cells["idPlan"].Value = dr["idPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["datePurchasePlan"].Value = dr["date_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["timePurchasePlan"].Value = dr["time_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idStudent"].Value = dr["idStudent"].ToString();
                dgvDataPlan.Rows[addRow].Cells["name"].Value = dr["name"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idModality"].Value = dr["idModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionModality"].Value = dr["descriptionModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItemsPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["valuePlan"].Value = $"R$ {dr["valueItemsPackage"].ToString()}";
                dgvDataPlan.Rows[addRow].Cells["idFormOfPayment"].Value = dr["idFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["dateTerminalPlan"].Value = dr["date_terminal_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionFormOfPayment"].Value = dr["descriptionFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["IdPackage"].Value = dr["IdPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionPackage"].Value = dr["descriptionPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idSituationPlan"].Value = dr["idSituationPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["situation"].Value = dr["situation"].ToString();
                dgvDataPlan.Rows[addRow].Cells["deactivationDate"].Value = dr["deactivation_date"].ToString();
                dgvDataPlan.Rows[addRow].Cells["timeInactivated"].Value = dr["time_inactivated"].ToString();
                dgvDataPlan.Rows[addRow].Cells["dateTerminalPlanExtended"].Value = dr["date_terminal_plan_extended"].ToString();
                dgvDataPlan.Rows[addRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
        }

        //int idItems;

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvDataPlan.CurrentCell.ColumnIndex == 0)
                {
                    int idPlan = int.Parse(dgvDataPlan.CurrentRow.Cells["idPlan"].Value.ToString());
                    int idStudent = int.Parse(dgvDataPlan.CurrentRow.Cells["idStudent"].Value.ToString());
                    OpenForm.ShowForm(new FrmDetailsPlan(idPlan, idStudent), this);
                }

                dgvDataPlan.ClearSelection();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataPackages();
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                dgvDataPlan.ClearSelection();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            if (new Bussiness.Package().SearchAll().Rows.Count > 0)
                OpenForm.ShowForm(new FrmPurchasePlan(), this);
            else
                MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
