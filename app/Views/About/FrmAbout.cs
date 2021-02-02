using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Resources.icons8_close_window_32px_leavee;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pcLogo_MouseDown(object sender, MouseEventArgs e)
        {
            FrmAbout_MouseDown(sender, e);
        }

        private void lblInformation_MouseDown(object sender, MouseEventArgs e)
        {
            FrmAbout_MouseDown(sender, e);
        }
    }
}
