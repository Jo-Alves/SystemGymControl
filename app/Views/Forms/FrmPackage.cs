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
            dgvDatePackage.Rows.Clear();

            DataTable GetSearchPackage;
            if (string.IsNullOrWhiteSpace(txtSearchDescription.Text))
                GetSearchPackage = package.SearchAll();
            else
                GetSearchPackage = package.SearchDescription(txtSearchDescription.Text.Trim());

            foreach (DataRow dr in GetSearchPackage.Rows)
            {
                int coutRow = dgvDatePackage.Rows.Add();
                dgvDatePackage.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDatePackage.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDatePackage.Rows[coutRow].Cells["id"].Value = dr["id"].ToString();
                dgvDatePackage.Rows[coutRow].Cells["description"].Value = dr["description"].ToString();
                dgvDatePackage.Rows[coutRow].Cells["duration"].Value = dr["duration"].ToString();
                dgvDatePackage.Rows[coutRow].Cells["period"].Value = dr["period"].ToString();

                //responsiblepackage._packageID = int.Parse(dr["id"].ToString());
                //foreach (DataRow drResponsible in responsiblepackage.SearchID().Rows)
                //{
                //    dgvDatePackage.Rows[coutRow].Cells["responsible"].Value = drResponsible["name"].ToString();
                //    dgvDatePackage.Rows[coutRow].Cells["cpfResponsible"].Value = drResponsible["cpf"].ToString();
                //    dgvDatePackage.Rows[coutRow].Cells["kinship"].Value = drResponsible["kinship"].ToString();
                //    dgvDatePackage.Rows[coutRow].Cells["phoneResponsible"].Value = drResponsible["phone"].ToString();
                //}

                dgvDatePackage.Rows[coutRow].MinimumHeight = 45;

                dgvDatePackage.ClearSelection();
            }
        }

        private void dgvDatePackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDatePackage.ClearSelection();

                    // Ao acionar a célula para editar abre o Form para Editar os dados
                    int id = int.Parse(dgvDatePackage.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDatePackage.CurrentCell.ColumnIndex == 0)
                    {
                        OpenForm.ShowForm(new FrmSavePackage(id), this);
                    }
                    else if (dgvDatePackage.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDatePackage.CurrentRow.Cells["description"].Value.ToString()}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            package.Delete(id);
                            LoadDataPackages();
                            if (dgvDatePackage.Rows.Count == 0)
                            {
                                this.Close();
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

        private void dgvDatePackage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDatePackage.ClearSelection();
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
