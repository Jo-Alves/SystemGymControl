using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemGymControl
{
    public partial class FrmGymControl : Form
    {
        bool isMaximized;

        public FrmGymControl()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pcPerfil.DisplayRectangle);
            pcPerfil.Region = new Region(gp);

            OpenForm(new FrmHome());
            _obj = this;
        }

        private Form activeForm = null;

        private void OpenForm(Form form)
        {
            if (activeForm != null)
                activeForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnPage.Controls.Add(form);
            pnPage.Tag = form;
            form.BringToFront();
            form.Show();
        }

        static FrmGymControl _obj;

        public static FrmGymControl Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmGymControl();
                }
                return _obj;
            }
        }

        public Panel PnPageContainer
        {
            get { return pnPage; }
            set { pnPage = value; }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnRetoreMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px_leave;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_leave;
            }

            isMaximized = !isMaximized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateNow.Text = $"{DateTime.Now.ToLongDateString()}, {DateTime.Now.ToLongTimeString()}";
        }

        private void btnMimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leave;
        }

        private void btnRetoreMaximize_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px_enter;
            else if (this.WindowState == FormWindowState.Normal)
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_enter;
        }

        private void btnRetoreMaximize_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px_leave;
            else if (this.WindowState == FormWindowState.Normal)
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_leave;
        }

        private void btnMimized_MouseEnter(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_enter;
        }

        private void btnMimized_MouseLeave(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_leave;
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcHome_Click(object sender, EventArgs e)
        {
            OpenFormAndUser.OpenForm(new FrmHome());
        }

        private void btnMenuSave_Click(object sender, EventArgs e)
        {
            OpenFormAndUser.OpenForm(new FrmOptionsSave());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormAndUser.OpenForm(new FrmHome());
        }

        private void lblDateNow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
