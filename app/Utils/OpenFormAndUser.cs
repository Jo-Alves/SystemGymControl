using System.Windows.Forms;

namespace SystemGymControl
{
    public static class OpenFormAndUser
    {
        public static void OpenUserControl(UserControl userControl, string nameUserControl)
        {
            if (!FrmGymControl.Instance.PnPageContainer.Controls.ContainsKey(nameUserControl))
            {
                userControl.Dock = DockStyle.Fill;
                FrmGymControl.Instance.PnPageContainer.Controls.Add(userControl);
            }

            FrmGymControl.Instance.PnPageContainer.Controls[nameUserControl].BringToFront();
        }
        
        public static void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            FrmGymControl.Instance.PnPageContainer.Controls.Add(form);
            FrmGymControl.Instance.PnPageContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
