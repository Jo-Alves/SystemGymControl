using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmResetPassword : Form
    {
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        public FrmResetPassword(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        public bool hasBeenReset { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmResetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        bool isPasswordHidden;

        private void pcUpdateFormatPassword_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;

            switch (isPasswordHidden)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    txtConfirmPassword.UseSystemPasswordChar = false;
                    pcUpdateFormatPassword.Image = Properties.Resources.ocultar_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ocultar");
                    break;
                case false:
                    txtPassword.UseSystemPasswordChar = true;
                    txtConfirmPassword.UseSystemPasswordChar = true;
                    pcUpdateFormatPassword.Image = Properties.Resources.ver_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ver");
                    break;
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("Os caracteres não são compatíveis!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("A senha deve ter no mínimo 5 cararacteres!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                new Bussiness.User()
                {
                    _user = lblUser.Text,
                    _email = txtPassword.Text.Trim(),
                    _password = Security.Cry(txtConfirmPassword.Text.Trim())
                }
        .ResetSecurity();

                MessageBox.Show("Senha redefinida com sucesso!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hasBeenReset = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnResetPassword_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}