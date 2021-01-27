using System;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmConfigurationSystem : Form
    {
        public FrmConfigurationSystem()
        {
            InitializeComponent();
            LoadFields();
        }

        private void LoadFields()
        {
            txtDirectory.Text = Settings.Default["directory"].ToString();
            rbPrintDirecty.Checked = bool.Parse(Settings.Default["optionPreviewIsDirecty"].ToString()) || string.IsNullOrEmpty(Settings.Default["optionPreviewIsDirecty"].ToString()) ? true : false;
            rbVisualize.Checked = bool.Parse(Settings.Default["optionPreviewIsDirecty"].ToString()) ? false : true;
            txtNameFantasy.Text = Settings.Default["nameFantasy"].ToString();
            mkCPF.Text = Settings.Default["CNPJ"].ToString();
            txtEmail.Text = Settings.Default["email"].ToString();
            cbGeneratesBackupAutomatically.Checked = bool.Parse(Settings.Default["generatesBackupAutomatically"].ToString());
            cbxSelectOptions.Text = Settings.Default["optionBackup"].ToString();
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmHome(), this);
        }

        private void cbGeneratesBackupAutomatically_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGeneratesBackupAutomatically.Checked)
            {
                cbxSelectOptions.SelectedIndex = 0;
                cbxSelectOptions.Enabled = true;
            }
            else
            {
                cbxSelectOptions.SelectedIndex = -1;
                cbxSelectOptions.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default["directory"] = txtDirectory.Text;
            Settings.Default["optionPreviewIsDirecty"] = rbPrintDirecty.Checked ? true : false;
            Settings.Default["nameFantasy"] = txtNameFantasy.Text.Trim();
            Settings.Default["CNPJ"] = mkCPF.Text;
            Settings.Default["email"] = txtEmail.Text.Trim();
            Settings.Default["generatesBackupAutomatically"] = cbGeneratesBackupAutomatically.Checked ? true : false;
            Settings.Default["optionBackup"] = cbxSelectOptions.Text.Trim();
            Settings.Default.Save();
            OpenForm.ShowForm(new FrmHome(), this);
        }
    }
}
