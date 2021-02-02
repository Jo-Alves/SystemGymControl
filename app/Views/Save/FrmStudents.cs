using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmStudents : Form
    {
        Student student = new Student();
        Bussiness.ResponsibleStudent responsibleStudent = new Bussiness.ResponsibleStudent();

        public FrmStudents()
        {
            InitializeComponent();
            LoadDataStudents();
        }

        private void LoadDataStudents()
        {
            dgvDataStudent.Rows.Clear();

            DataTable GetSearchStudent;
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
                GetSearchStudent = student.SearchAll();
            else
                GetSearchStudent = student.SearchName(txtSearchName.Text.Trim());

            foreach (DataRow dr in GetSearchStudent.Rows)
            {
                int coutRow = dgvDataStudent.Rows.Add();
                dgvDataStudent.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDataStudent.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDataStudent.Rows[coutRow].Cells["quiz"].Value = Properties.Resources.icons8_quiz_32px;
                dgvDataStudent.Rows[coutRow].Cells["id"].Value = dr["id"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["name"].Value = dr["name"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["CPF"].Value = dr["cpf"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["birth"].Value = dr["birth"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["phone"].Value = dr["phone"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["CEP"].Value = dr["cep"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["district"].Value = dr["district"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["address"].Value = dr["address"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["number"].Value = dr["number"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["city"].Value = dr["city"].ToString();
                dgvDataStudent.Rows[coutRow].Cells["state"].Value = dr["state"].ToString();

                foreach (DataRow drResponsible in responsibleStudent.SearchID(int.Parse(dr["id"].ToString())).Rows)
                {
                    dgvDataStudent.Rows[coutRow].Cells["responsible"].Value = drResponsible["name"].ToString();
                    dgvDataStudent.Rows[coutRow].Cells["cpfResponsible"].Value = drResponsible["cpf"].ToString();
                    dgvDataStudent.Rows[coutRow].Cells["kinship"].Value = drResponsible["kinship"].ToString();
                    dgvDataStudent.Rows[coutRow].Cells["phoneResponsible"].Value = drResponsible["phone"].ToString();
                }

                dgvDataStudent.Rows[coutRow].MinimumHeight = 45;

                dgvDataStudent.ClearSelection();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmSaveStudent(), this);
        }

        private void dgvDataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDataStudent.ClearSelection();

                    // Ao acionar a célula para editar abre o Form para Editar os dados
                    int id = int.Parse(dgvDataStudent.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDataStudent.CurrentCell.ColumnIndex == 0)
                    {
                        OpenForm.ShowForm(new FrmSaveStudent(id), this);
                    }
                    else if (dgvDataStudent.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDataStudent.CurrentRow.Cells["name"].Value}?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            student.Delete(id);
                            LoadDataStudents();
                            if (dgvDataStudent.Rows.Count == 0)
                            {
                                OpenForm.ShowForm(new FrmOptionsSave(), this);
                            }
                        }
                    }
                    else if (dgvDataStudent.CurrentCell.ColumnIndex == 2)
                    {
                        OpenForm.ShowForm(new FrmQuizParq(Convert.ToInt32(dgvDataStudent.CurrentRow.Cells["id"].Value), dgvDataStudent.CurrentRow.Cells["name"].Value.ToString()), this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataStudent.ClearSelection();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadDataStudents();
        }
    }
}
