using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class UsStudent : UserControl
    {
        Student student = new Student();

        public UsStudent()
        {
            InitializeComponent();
            LoadDataStudents();
        }

        private void LoadDataStudents()
        {
            dgvDateStudent.Rows.Clear();

            foreach(DataRow dr in student.SearchAll().Rows)
            {
                int coutRow = dgvDateStudent.Rows.Add();
                dgvDateStudent.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDateStudent.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDateStudent.Rows[coutRow].Cells["id"].Value = dr["id"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["name"].Value = dr["name"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["CPF"].Value = dr["cpf"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["birth"].Value = dr["birth"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["phone"].Value = dr["phone"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["CEP"].Value = dr["cep"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["district"].Value = dr["district"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["address"].Value = dr["address"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["number"].Value = dr["number"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["city"].Value = dr["city"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["state"].Value = dr["state"].ToString();
                dgvDateStudent.Rows[coutRow].MinimumHeight = 45;

                dgvDateStudent.ClearSelection();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmGymControl.Instance.PnPageContainer.Controls.Clear();
            OpenFormAndUser.OpenUserControl(new UsSaveStudent(), "UsSaveStudent");
        }

        private void dgvDateStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDateStudent.ClearSelection();

                // Ao acionar a célula para editar abre o Form para Editar os dados
                int id = int.Parse(dgvDateStudent.CurrentRow.Cells["id"].Value.ToString());

                if (dgvDateStudent.CurrentCell.ColumnIndex == 0)
                {
                    FrmGymControl.Instance.PnPageContainer.Controls.Clear();
                    OpenFormAndUser.OpenUserControl(new UsSaveStudent(id), "UsSaveStudent");
                }
                else if (dgvDateStudent.CurrentCell.ColumnIndex == 1)
                {
                    if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDateStudent.CurrentRow.Cells["name"].Value.ToString()}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        student._id = id;
                        student.Delete();
                        LoadDataStudents();
                    }
                }
            }
        }

        private void dgvDateStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDateStudent.ClearSelection();
            }
        }
    }
}
