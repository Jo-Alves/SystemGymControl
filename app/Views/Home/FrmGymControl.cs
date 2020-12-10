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

            ShowForm(new FrmHome());
            _obj = this;
            this.ClientSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Top = 0;
            this.Left = 0;
        }

        private Form activeForm = null;

        private void ShowForm(Form form)
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

        public Label _lblTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnMimized_MouseEnter(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_enter;
        }

        private void btnMimized_MouseLeave(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_leave1;
        }

        private void btnMenuSave_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            OpenForm.ShowForm(new FrmOptionsSave(), this);
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            OpenForm.ShowForm(new FrmHome(), this);
        }

        private void btnMenuPlan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            OpenForm.ShowForm(new FrmOptionsPlan(), this);
        }
    }
}
