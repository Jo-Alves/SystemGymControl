using System;
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
            HideSubMenu();
        }

        private void HideSubMenu()
        {
            pnMenuClass.Visible = false;
            pnMenuSave.Visible = false;
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
                btnRetoreMaximize.Image = Properties.Resources.icons8_restore_window_32px_leave;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnRetoreMaximize.Image = Properties.Resources.icons8_maximize_window_32px_leave;

            }
        }

        //private void btnToggleMenu_Click(object sender, EventArgs e)
        //{
            
        //    //timer.Start();
        //    if (pnConjuctMenu.Width == 0)
        //    {
        //        pnConjuctMenu.Width = panelWidth;
        //    }
        //    else
        //    {
        //        pnConjuctMenu.Width = 0;
        //    }
        //}

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateNow.Text = $"{DateTime.Now.ToLongDateString()}, {DateTime.Now.ToLongTimeString()}";
            //if (hidden)
            //{
            //    pnConjuctMenu.Width += 10;
            //    if (pnConjuctMenu.Width >= panelWidth)
            //    {
            //        timer.Stop();
            //        hidden = false;
            //        this.Refresh();
            //    }
            //}
            //else
            //{
            //    pnConjuctMenu.Width -= 10;
            //    if (pnConjuctMenu.Width <= 0)
            //    {
            //        timer.Stop();
            //        hidden = true;
            //        this.Refresh();
            //    }
            //}
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

        private void btnMenuCadastro_MouseLeave(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSubMenuStudent_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSubMenuPackage_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSubMenuUser_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnMenuClass);
        }

        private void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnMenuSave);
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnFequency_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
    }
}
