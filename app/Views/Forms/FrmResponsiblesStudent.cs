using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmResponsiblesStudent : Form
    {
        public FrmResponsiblesStudent()
        {
            InitializeComponent();
        }

        public string name { get; set; }
        public string cpf { get; set; }
        public string kinship { get; set; }
        public string phone { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_black_leave;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            cpf = txtCPF.Text;
            kinship = cbKinship.Text;
            phone = txtPhone.Text;
            this.Close();
        }
    }
}
