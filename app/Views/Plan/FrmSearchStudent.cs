using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemGymControl
{
    public partial class FrmSearchStudent : Form
    {
        Student student = new Student();
        Bussiness.ResponsibleStudent responsibleStudent = new Bussiness.ResponsibleStudent();
        public int idStudent { get; set; }
        public string nameStudent { get; set; }

        public FrmSearchStudent()
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

                dgvDataStudent.Rows[coutRow].MinimumHeight = 30;

                dgvDataStudent.ClearSelection();
            }
        }

        private void dgvDataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idStudent = int.Parse(dgvDataStudent.CurrentRow.Cells["id"].Value.ToString());
                nameStudent = dgvDataStudent.CurrentRow.Cells["name"].Value.ToString();
                this.Close();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadDataStudents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmSearchStudent_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
