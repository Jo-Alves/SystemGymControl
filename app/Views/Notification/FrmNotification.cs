using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmNotification : Form
    {
        Notification notification = new Notification();

        public FrmNotification()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                DataTable dataNotification = notification.GetDataNotificationNotRead();

                foreach (DataRow dr in dataNotification.Rows)
                {
                    int countRow = dgvDataPlan.Rows.Add();
                    dgvDataPlan.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = dr["situation"].ToString().ToLower() == "não lida" ? "false" : "true";
                    dgvDataPlan.Rows[countRow].Cells["message"].Value = dr["message"].ToString();

                    dgvDataPlan.Rows[countRow].MinimumHeight = 45;
                }

                dgvDataPlan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    if (dgvDataPlan.CurrentCell.ColumnIndex == 1)
                    {
                        int idNotification = int.Parse(dgvDataPlan.CurrentRow.Cells["id"].Value.ToString());

                        string situationNotification = notification.GetSituationNotification(idNotification).Rows[0]["situation"].ToString().ToLower() == "não lida" ? "Lida" : "Não Lida";

                        dgvDataPlan.CurrentRow.Cells["situation"].Value = situationNotification.ToLower() == "não lida" ? "false" : "true";

                        notification.MarctMessage(idNotification, situationNotification);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvDataPlan.ClearSelection();

            }
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();
            }
        }
    }
}
