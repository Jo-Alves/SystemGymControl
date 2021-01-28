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
            mkCNPJ.Text = Settings.Default["CNPJ"].ToString();
            txtEmail.Text = Settings.Default["email"].ToString();
            cbGeneratesBackup.Checked = bool.Parse(Settings.Default["generatesBackupAutomatically"].ToString());
            cbxSelectOptions.Text = Settings.Default["optionBackup"].ToString();
            mkPhone.Text = Settings.Default["phone"].ToString();
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

        private void cbGeneratesBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGeneratesBackup.Checked)
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
            if (!ValidateFields()) return;

            Settings.Default["directory"] = txtDirectory.Text;
            Settings.Default["optionPreviewIsDirecty"] = rbPrintDirecty.Checked ? true : false;
            Settings.Default["nameFantasy"] = txtNameFantasy.Text.Trim();
            Settings.Default["CNPJ"] = mkCNPJ.Text.Length < 18 ? "" : mkCNPJ.Text;
            Settings.Default["email"] = txtEmail.Text.Trim();
            Settings.Default["generatesBackupAutomatically"] = cbGeneratesBackup.Checked ? true : false;
            Settings.Default["optionBackup"] = cbxSelectOptions.Text.Trim();
            Settings.Default["phone"] = mkPhone.Text.Length < 15 ? "" : mkPhone.Text;

            FrmGymControl.Instance._btnBackup.Visible = cbxSelectOptions.SelectedIndex == 1 && cbGeneratesBackup.Checked ? true : false;

            Settings.Default.Save();
            OpenForm.ShowForm(new FrmHome(), this);
        }

        private bool ValidateFields()
        {
            bool fieldsValidated = false;

            if (string.IsNullOrWhiteSpace(txtNameFantasy.Text))
            {
                MessageBox.Show("Informe o nome fantasia!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNameFantasy.Focus();
            }
            else if (mkCNPJ.Text.Length == 18 && !ValidateCNPJ.Validate(mkCNPJ.Text))
            {
                MessageBox.Show("CNPJ inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mkCNPJ.Focus();
            }
            else if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidateEmail.Validate(txtEmail.Text))
            {
                MessageBox.Show("Email inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
                fieldsValidated = true;

            return fieldsValidated;
        }
    }
}
