using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class UsStudent : UserControl
    {
        public UsStudent()
        {
            InitializeComponent();
            LoadGrid();

            //foreach (DataGridViewRow row in dgvDateStudent.Rows)
            //{
            //    row.MinimumHeight = 45;
            //}
          
            dgvDateStudent.ClearSelection();
        }

        Student student = new Student();

        private void LoadGrid()
        {
            foreach(DataRow dr in student.SearchAll().Rows)
            {
                int coutRow = dgvDateStudent.Rows.Add();
                dgvDateStudent.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDateStudent.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDateStudent.Rows[coutRow].Cells["id"].Value = dr["id"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["name"].Value = dr["name"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["CPF"].Value = dr["cpf"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["birth"].Value = dr["birth"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["CEP"].Value = dr["cep"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["address"].Value = dr["address"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["number"].Value = dr["number"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["city"].Value = dr["city"].ToString();
                dgvDateStudent.Rows[coutRow].Cells["state"].Value = dr["state"].ToString();
                dgvDateStudent.Rows[coutRow].MinimumHeight = 45;
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

                int id = int.Parse(dgvDateStudent.CurrentRow.Cells["id"].Value.ToString());
                //string name = dgvDateStudent.CurrentRow.Cells["name"].Value.ToString();
                //string CPF = dgvDateStudent.CurrentRow.Cells["CPF"].Value.ToString();
                //string birth = dgvDateStudent.CurrentRow.Cells["birth"].Value.ToString();
                //string CEP = dgvDateStudent.CurrentRow.Cells["CEP"].Value.ToString();
                //string district = dgvDateStudent.CurrentRow.Cells["district"].Value.ToString();
                //string address = dgvDateStudent.CurrentRow.Cells["address"].Value.ToString();
                //int number = int.Parse(dgvDateStudent.CurrentRow.Cells["number"].Value.ToString());
                //string city = dgvDateStudent.CurrentRow.Cells["city"].Value.ToString();
                //string state = dgvDateStudent.CurrentRow.Cells["state"].Value.ToString();

                FrmGymControl.Instance.PnPageContainer.Controls.Clear();
                OpenFormAndUser.OpenUserControl(new UsSaveStudent(id), "UsSaveStudent");
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
