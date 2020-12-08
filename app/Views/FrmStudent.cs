using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmStudent : Form
    {
        Student student = new Student();
        Bussiness.ResponsibleStudent responsibleStudent = new Bussiness.ResponsibleStudent();

        public FrmStudent()
        {
            InitializeComponent();
            LoadDataStudents();
        }

        private void LoadDataStudents()
        {
            dgvDateStudent.Rows.Clear();

            DataTable GetSearchStudent;
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
                GetSearchStudent = student.SearchAll();
            else
                GetSearchStudent = student.SearchName(txtSearchName.Text.Trim());

            foreach (DataRow dr in GetSearchStudent.Rows)
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

                foreach (DataRow drResponsible in responsibleStudent.SearchID(int.Parse(dr["id"].ToString())).Rows)
                {
                    dgvDateStudent.Rows[coutRow].Cells["responsible"].Value = drResponsible["name"].ToString();
                    dgvDateStudent.Rows[coutRow].Cells["cpfResponsible"].Value = drResponsible["cpf"].ToString();
                    dgvDateStudent.Rows[coutRow].Cells["kinship"].Value = drResponsible["kinship"].ToString();
                    dgvDateStudent.Rows[coutRow].Cells["phoneResponsible"].Value = drResponsible["phone"].ToString();
                }

                dgvDateStudent.Rows[coutRow].MinimumHeight = 45;

                dgvDateStudent.ClearSelection();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmSaveStudent(), this);
        }

        private void dgvDateStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDateStudent.ClearSelection();

                    // Ao acionar a célula para editar abre o Form para Editar os dados
                    int id = int.Parse(dgvDateStudent.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDateStudent.CurrentCell.ColumnIndex == 0)
                    {
                        OpenForm.ShowForm(new FrmSaveStudent(id), this);
                    }
                    else if (dgvDateStudent.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDateStudent.CurrentRow.Cells["name"].Value.ToString()}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            student.Delete(id);
                            LoadDataStudents();
                            if (dgvDateStudent.Rows.Count == 0)
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

        private void dgvDateStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDateStudent.ClearSelection();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadDataStudents();
        }
    }
}
