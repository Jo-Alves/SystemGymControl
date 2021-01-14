using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmUsers : Form
    {
        User user = new User();

        public FrmUsers()
        {
            InitializeComponent();
            LoadDataUsers();
        }

        public FrmUsers(string save)
        {
        }

        private void LoadDataUsers()
        {
            try
            {
                dgvdataUser.Rows.Clear();

                DataTable GetDataUsers;

                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                    GetDataUsers = user.SearchAll();
                else
                    GetDataUsers = user.SearchUser(txtSearch.Text);

                foreach (DataRow dr in GetDataUsers.Rows)
                {
                    int countRow = dgvdataUser.Rows.Add();
                    dgvdataUser.Rows[countRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                    dgvdataUser.Rows[countRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                    dgvdataUser.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                    dgvdataUser.Rows[countRow].Cells["name"].Value = dr["name"].ToString();
                    dgvdataUser.Rows[countRow].Cells["nameUser"].Value = dr["name_user"].ToString();
                    dgvdataUser.Rows[countRow].Cells["email"].Value = dr["email"].ToString();
                    dgvdataUser.Rows[countRow].Cells["password"].Value = dr["password"].ToString();
                    dgvdataUser.Rows[countRow].Cells["question"].Value = dr["question"].ToString();
                    dgvdataUser.Rows[countRow].Cells["answer"].Value = dr["answer"].ToString();
                    dgvdataUser.Rows[countRow].Cells["registion"].Value = dr["date_registion"].ToString();

                    dgvdataUser.Rows[countRow].MinimumHeight = 45;
                    dgvdataUser.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmSaveUser(), this);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataUsers();
        }

        private void dgvdataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvdataUser.ClearSelection();

                // Ao acionar a célula para editar abre o Form para Editar os dados
                int id = int.Parse(dgvdataUser.CurrentRow.Cells["id"].Value.ToString());

                if (dgvdataUser.CurrentCell.ColumnIndex == 0)
                {
                    OpenForm.ShowForm(new FrmSaveUser(id), this);
                }
                else if (dgvdataUser.CurrentCell.ColumnIndex == 1)
                {
                    if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvdataUser.CurrentRow.Cells["nameUser"].Value.ToString()}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        user.Delete(id);
                        LoadDataUsers();
                        if (dgvdataUser.Rows.Count == 0)
                        {
                            OpenForm.ShowForm(new FrmOptionsSave(), this);
                        }
                    }
                }
            }
        }

        private void dgvdataUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvdataUser.ClearSelection();
            }
        }
    }
}
