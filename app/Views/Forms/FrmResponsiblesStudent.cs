using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemGymControl
{
    public partial class FrmResponsiblesStudent : Form
    {
        public FrmResponsiblesStudent()
        {
            InitializeComponent();
        }

        public FrmResponsiblesStudent(int studentId)
        {
            InitializeComponent();

            responsible._studentID = studentId;
            var getResponsible = responsible.SearchID();

            if (getResponsible.Rows.Count > 0)
            {
                mkCPF.Enabled = false;
                id = int.Parse(getResponsible.Rows[0]["id"].ToString());
                stundetID = int.Parse(getResponsible.Rows[0]["student_id"].ToString());
                txtName.Text = getResponsible.Rows[0]["name"].ToString();
                mkCPF.Text = getResponsible.Rows[0]["cpf"].ToString();
                cbKinship.Text = getResponsible.Rows[0]["kinship"].ToString();
                mkPhone.Text = getResponsible.Rows[0]["phone"].ToString();
            }
        }

        public int id { get; set; }
        public int stundetID { get; set; }
        public string name { get; set; }
        public string cpf { get; set; }
        public string kinship { get; set; }
        public string phone { get; set; }

        ResponsibleStudent responsible = new ResponsibleStudent();

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
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leave;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider error = new ErrorProvider();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                name = txtName.Text.Trim();
                kinship = cbKinship.Text;

                if (mkCPF.Text.Length == 14)
                    cpf = mkCPF.Text;
                else
                    cpf = "";

                if (mkPhone.Text.Length == 15)
                    phone = mkPhone.Text;
                else
                    phone = "";

                this.Close();
            }
        }

        private bool ValidateFields()
        {
            error.Clear();

            bool theFieldsHaveBeenValidated = false;
                     
            responsible._name = txtName.Text.Trim();
            responsible._cpf = mkCPF.Text;
            responsible._kinship = cbKinship.Text;
            responsible._phone = mkPhone.Text;

            if (!string.IsNullOrEmpty(responsible.ValidateFields()))
            {
                if (responsible.ValidateFields() == "Campo Nome do responsável obrigatório!")
                {
                    MessageBox.Show("Campo 'Nome do responsável' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtName, "Campo 'Nome do responsável' obrigatório!");
                    txtName.Focus();
                }
                else if (responsible.ValidateFields() == "Campo CPF obrigatório!")
                {
                    MessageBox.Show("Campo 'CPF' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Campo 'CPF' obrigatório!");
                    mkCPF.Focus();
                } 
                else if (responsible.ValidateFields() == "Campo Grau de Parentesco obrigatório!")
                {
                    MessageBox.Show("Campo 'Grau de Parentesco' obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(cbKinship, "Campo 'Grau de Parentesco' obrigatório!");
                    cbKinship.Focus();
                }
                else if (responsible.ValidateFields() == "Este CPF já está cadastrado!")
                {
                    MessageBox.Show("Este CPF já está cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Este CPF já está cadastrado!");
                    mkCPF.Focus();
                }
                else if (responsible.ValidateFields() == "CPF inválido!")
                {
                    MessageBox.Show("CPF inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mkCPF.Focus();
                }
            }
            else
            {
                theFieldsHaveBeenValidated = true;
            }

            return theFieldsHaveBeenValidated;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmResponsiblesStudent_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
