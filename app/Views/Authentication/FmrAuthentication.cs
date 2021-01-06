using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmAuthentication : Form
    {
        public FrmAuthentication()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        bool isPasswordHidden;

        private void pcUpdateFormatPassword_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;

            switch (isPasswordHidden)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    pcUpdateFormatPassword.Image = Properties.Resources.ocultar_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ocultar");
                    break;
                case false:
                    txtPassword.UseSystemPasswordChar = true;
                    pcUpdateFormatPassword.Image = Properties.Resources.ver_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ver");
                    break;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmAuthentication_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                new FrmReportTipPassword(txtUser.Text.Trim(), new Bussiness.User().SearchUser(txtUser.Text.Trim()).Rows[0]["question"].ToString()).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            Bussiness.User user = new Bussiness.User();

            if (user.Logout(txtUser.Text.Trim(), txtPassword.Text.Trim()))
            {
                var dataUser = new Bussiness.User().GetUserOrName(txtUser.Text.Trim());
                string nameUser = dataUser.Rows[0]["name_user"].ToString();
                string avatar = dataUser.Rows[0]["avatar"].ToString();
                this.Visible = false;

                if (new Bussiness.CashFlow().HaveCashFlowOpen())
                    new FrmGymControl(nameUser, avatar).ShowDialog();
                else
                    new FrmBoxOpening(nameUser, avatar).ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário|email ou senha incorreta!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (new Bussiness.User().ExitNameOrUser(txtUser.Text.Trim()))
                    linkReset.Visible = true;
            }
        }

        private bool ValidateFields()
        {
            bool fieldsValidate = false;

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Informe o seu nome ou email cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Informe a senha cadastrada!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else
                fieldsValidate = true;

            return fieldsValidate;
        }

        private void FrmAuthentication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}
