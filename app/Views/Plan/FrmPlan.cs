using Bussiness;
using System;
using System.Data;
using System.Drawing;
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
            LoadDataPlan();
            CancelAfterThirtyDayTerminalPlan();
        }

        private void CancelAfterThirtyDayTerminalPlan()
        {
            DateTime dateNow = DateTime.Now;
            TimeSpan timeSpan;
            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                DateTime dateTerminal = Convert.ToDateTime(row.Cells["dateTerminalPlan"].Value.ToString());
                timeSpan = dateNow.Subtract(dateTerminal);
                int idPlan = int.Parse(row.Cells["idPlan"].Value.ToString());

                if (timeSpan.Days > 30)
                {
                    situationsPlan.updateSituationPlan(idPlan, "Cancelado");
                }

                LoadDataPlan();
            }
        }

        // atualiza a coluna da tabela timeInactivated incrementado se o plano estiver inativado
        private void UpdateTimeInactivated()
        {
            TimeSpan time;

            foreach (DataGridViewRow dgv in dgvDataPlan.Rows)
            {
                if (dgv.Cells["situation"].Value.ToString() == "Inativo")
                {
                    //dgvDataPlan.Columns["dateTerminalPlanLast"].Visible = true;
                    dgvDataPlan.Columns["timeInactivated"].Visible = true;
                    dgvDataPlan.Columns["deactivationDate"].Visible = true;
                    int idSituation = int.Parse(dgv.Cells["idSituationPlan"].Value.ToString());

                    var dateTerminal = Convert.ToDateTime(dgv.Cells["dateTerminalPlanLast"].Value.ToString());
                    var deactivationDate = Convert.ToDateTime(dgv.Cells["deactivationDate"].Value.ToString());

                    /*
                        * subtrai a data de atual com a data da desativação do plano para
                        * pegar a diferença das datas e aumentar o prazo do término
                     */
                    time = DateTime.Now.Subtract(deactivationDate);

                    situationsPlan._timeInactivated = time.Days.ToString();
                    plan._dateTerminalPlan = dateTerminal.AddDays(time.Days).ToShortDateString();
                    situationsPlan.updateTimeInactivated(idSituation);

                    plan.UpdateTerminalPlan(int.Parse(dgv.Cells["idPlan"].Value.ToString()));

                    dgv.Cells["dateTerminalPlan"].Value = plan._dateTerminalPlan;
                    if (time.Days == 1)
                    {
                        dgv.Cells["timeInactivated"].Value = $"{time.Days} dia";
                    }
                    else
                        dgv.Cells["timeInactivated"].Value = $"{time.Days} dias";
                }
            }
        }

        private void LoadDataPlan()
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
                dgvDataPlan.Rows[addRow].Cells["renewPlan"].Value = Properties.Resources.icons8_renew_32px;
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
                dgvDataPlan.Rows[addRow].Cells["dateTerminalPlanLast"].Value = dr["date_terminal_plan_last"].ToString();
                dgvDataPlan.Rows[addRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
            UpdateTimeInactivated();
            updateColorRowDataGridIfSituationPlanExpired();
        }

        private void updateColorRowDataGridIfSituationPlanExpired()
        {
            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                if (row.Cells["situation"].Value.ToString() == "Expirado")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
                }
            }
        }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();

                int idPlan = int.Parse(dgvDataPlan.CurrentRow.Cells["idPlan"].Value.ToString());
                int idStudent = int.Parse(dgvDataPlan.CurrentRow.Cells["idStudent"].Value.ToString());

                if (dgvDataPlan.CurrentCell.ColumnIndex == 0)
                {
                    OpenForm.ShowForm(new FrmDetailsPlan(idPlan, idStudent), this);
                }
                else if (dgvDataPlan.CurrentCell.ColumnIndex == 1)
                {
                    if (!dgvDataPlan.CurrentRow.Cells["situation"].Value.ToString().Equals("Expirado"))
                    {
                        MessageBox.Show("Só é permitido renovar o plano após a sua expiração!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var frmRenewPlan = new FrmRenewPlan(idPlan);
                    frmRenewPlan.ShowDialog();
                    LoadDataPlan();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataPlan();
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                dgvDataPlan.ClearSelection();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            if (new Package().SearchAll().Rows.Count > 0)
                OpenForm.ShowForm(new FrmPurchasePlan(), this);
            else
                MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
