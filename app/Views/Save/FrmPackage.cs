using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmPackage : Form
    {
        Package package = new Package();

        public FrmPackage()
        {
            InitializeComponent();
            LoadDataPackages();
        }

        private void LoadDataPackages()
        {
            dgvDataPackage.Rows.Clear();

            DataTable GetSearchPackage;
            if (string.IsNullOrWhiteSpace(txtSearchDescription.Text))
                GetSearchPackage = package.SearchAll();
            else
                GetSearchPackage = package.SearchDescription(txtSearchDescription.Text.Trim());

            foreach (DataRow dr in GetSearchPackage.Rows)
            {
                int coutRow = dgvDataPackage.Rows.Add();
                dgvDataPackage.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDataPackage.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDataPackage.Rows[coutRow].Cells["id"].Value = dr["id"].ToString();
                dgvDataPackage.Rows[coutRow].Cells["description"].Value = dr["description"].ToString();
                dgvDataPackage.Rows[coutRow].Cells["duration"].Value = dr["duration"].ToString();
                dgvDataPackage.Rows[coutRow].Cells["period"].Value = dr["period"].ToString();

                dgvDataPackage.Rows[coutRow].MinimumHeight = 45;

                dgvDataPackage.ClearSelection();
            }
        }

        private void dgvDataPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDataPackage.ClearSelection();

                    // Ao acionar a célula para editar abre o Form para Editar os dados
                    int id = int.Parse(dgvDataPackage.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDataPackage.CurrentCell.ColumnIndex == 0)
                    {
                        OpenForm.ShowForm(new FrmSavePackage(id), this);
                    }
                    else if (dgvDataPackage.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDataPackage.CurrentRow.Cells["description"].Value.ToString()}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            package.Delete(id);
                            LoadDataPackages();
                            if (dgvDataPackage.Rows.Count == 0)
                            {
                                OpenForm.ShowForm(new FrmOptionsSave(), this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataPackage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPackage.ClearSelection();
            }
        }

        private void txtSearchDescription_TextChanged(object sender, EventArgs e)
        {
            LoadDataPackages();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmSavePackage(), this);
        }
    }
}
