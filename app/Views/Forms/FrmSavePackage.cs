using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmSavePackage : Form
    {
        Package package = new Package();
        int idPackage;

        public FrmSavePackage()
        {
            InitializeComponent();
        } 

        public FrmSavePackage(int id)
        {
            InitializeComponent();
            idPackage = id;
            var searchPackage = package.SearchID(id);

            txtDescription.Text = searchPackage["description"].ToString();
            txtValue.Text = searchPackage["value"].ToString();
            ndDuration.Value = decimal.Parse(searchPackage["duration"].ToString());
            cbPeriod.Text = searchPackage["period"].ToString();
        }

        private void txtValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(txtValue.Text))
                    txtValue.Text = FormatTextBox.FormatValueDecimal(txtValue.Text);
            }
            catch 
            {
                MessageBox.Show("Valor informado inválido! Verifique se o valor é um número decimal.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtValue, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Informe o valor!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          
            package._id = idPackage;
            package._description = txtDescription.Text.Trim();
            package._value = decimal.Parse(txtValue.Text);
            package._duration = int.Parse(ndDuration.Value.ToString());
            package._period = cbPeriod.Text;

            if (ValidateFields())
            {
                package.Save();
                this.Close();
                OpenForm.ShowForm(new FrmPackage(), this);
            }
        }

        private bool ValidateFields()
        {
            string messageValidationPackage = package.ValidateFieldsGetMessage();

            if (messageValidationPackage == "Campo 'Descrição' obrigatório!")
            {
                MessageBox.Show(messageValidationPackage, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return false;
            }
            else if (messageValidationPackage == "Campo 'Duração' obrigatório!")
            {
                MessageBox.Show(messageValidationPackage, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ndDuration.Focus();
                return false;
            }
            else if (messageValidationPackage == "Campo 'Período' obrigatório!")
            {
                MessageBox.Show(messageValidationPackage, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbPeriod.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (new  Package().SearchAll().Rows.Count > 0)
                OpenForm.ShowForm(new FrmPackage(), this);
            else
                OpenForm.ShowForm(new FrmOptionsSave(), this);
        }

        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.SelectedIndex == 0)
            {
                ndDuration.Value = 1;
                lblDuration.Text = "Duração(dia)";
            }
            else if (cbPeriod.SelectedIndex == 1)
            {
                ndDuration.Value = 1;
                lblDuration.Text = "Duração(mes)";
            }
            else if (cbPeriod.SelectedIndex == 2)
            {
                ndDuration.Value = 2;
                lblDuration.Text = "Duração(meses)";
            }
            else if (cbPeriod.SelectedIndex == 3)
            {
                ndDuration.Value = 3;
                lblDuration.Text = "Duração(meses)";
            }
            else if (cbPeriod.SelectedIndex == 4)
            {
                ndDuration.Value = 6;
                lblDuration.Text = "Duração(meses)";
            }
            else if (cbPeriod.SelectedIndex == 5)
            {
                ndDuration.Value = 12;
                lblDuration.Text = "Duração(meses)";
            }
            else if (cbPeriod.SelectedIndex == 6)
            {
                ndDuration.Value = 15;
                lblDuration.Text = "Duração(dias)";
            }
            else if (cbPeriod.SelectedIndex == 7)
            {
                ndDuration.Value = 40;
                lblDuration.Text = "Duração(dias)";
            }
            else
            { 
                lblDuration.Text = "Duração(dias/meses)";
                ndDuration.Enabled = true;
                return;
            }

            ndDuration.Enabled = false;
        }
    }
}
