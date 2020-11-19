using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGynControl
{
    public partial class FrmGymControl : Form
    {
        int panelWidth;
        bool hidden;

        public FrmGymControl()
        {
            InitializeComponent();
            panelWidth = pnConjuctMenu.Width;
            //pcLogo.Image = Properties.Resources.logo;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pcLogo.DisplayRectangle);
            pcLogo.Region = new Region(gp);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetoreMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_5;

            }
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnConjuctMenu.Width += 10;
                if (pnConjuctMenu.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnConjuctMenu.Width -= 10;
                if (pnConjuctMenu.Width <= 0)
                {
                    timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnMimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px;
        }

        private void btnRetoreMaximize_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px_leave;
            else if (this.WindowState == FormWindowState.Normal)
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_leave;
        }

        private void btnRetoreMaximize_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px;
            else if (this.WindowState == FormWindowState.Normal)
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_5;
        }

        private void btnMimized_MouseEnter(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_leave;
        }

        private void btnMimized_MouseLeave(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_1;
        }
    }
}
