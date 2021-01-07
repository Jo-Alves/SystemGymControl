using Bussiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmPlans : Form
    {
        Plan plan = new Plan();
        SituationsPlan situationsPlan = new SituationsPlan();

        public FrmPlans()
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
                dgvDataPlan.Rows[addRow].Cells["period"].Value = dr["period"].ToString();
                dgvDataPlan.Rows[addRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
            ShowTimeInactivated();
            FormatFieldsTimeInactivated();
            updateColorRowDataGridIfSituationPlanExpired();
        }

        private void ShowTimeInactivated()
        {
            foreach (DataGridViewRow dgv in dgvDataPlan.Rows)
            {
                if (dgv.Cells["situation"].Value.ToString() == "Inativo")
                {
                    dgvDataPlan.Columns["timeInactivated"].Visible = true;
                    dgvDataPlan.Columns["deactivationDate"].Visible = true;

                    break;
                }
                else
                {
                    dgvDataPlan.Columns["timeInactivated"].Visible = false;
                    dgvDataPlan.Columns["deactivationDate"].Visible = false;
                }
            }
        }
        private void FormatFieldsTimeInactivated()
        {
            foreach (DataGridViewRow dgv in dgvDataPlan.Rows)
            {
                if (dgv.Cells["situation"].Value.ToString().ToLower() == "inativo")
                {
                    if (dgv.Cells["timeInactivated"].Value.ToString() == "1")
                    {
                        dgv.Cells["timeInactivated"].Value = $"{dgv.Cells["timeInactivated"].Value} dia";
                    }
                    else
                        dgv.Cells["timeInactivated"].Value = $"{dgv.Cells["timeInactivated"].Value} dias";
                }
            }
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

                    if (new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                    {
                        MessageBox.Show("Não há como realizar renovar plano neste momento. Para renovar plano fecha o sistema e abra um novo caixa", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                        if (dgvDataPlan.CurrentRow.Cells["period"].Value.ToString().ToLower().Equals("mensal"))
                    {
                        MessageBox.Show("Você será redirecionado para a tela de pagamento.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenForm.ShowForm(new FrmMonthlyPayment(idPlan), this);

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
            try
            {

                if (!new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                {
                    if (new Package().SearchAll().Rows.Count > 0)
                        OpenForm.ShowForm(new FrmPurchasePlan(), this);
                    else
                        MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Não há como realizar um novo plano neste momento. Para realizar um novo plano fecha o sistema e abra um novo caixa", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
