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
        BillingParametersPackage parametersPackage = new BillingParametersPackage();
        int idPackage;

        public FrmSavePackage()
        {
            InitializeComponent();
        }

        public FrmSavePackage(int id)
        {
            InitializeComponent();
            idPackage = id;

            try
            {
                var searchPackage = package.SearchID(id);

                txtDescription.Text = searchPackage["description"].ToString();
                ndDuration.Value = decimal.Parse(searchPackage["duration"].ToString());
                cbPeriod.Text = searchPackage["period"].ToString();
                GetParametersPackage(idPackage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetParametersPackage(int idPackage)
        {
            var drParameters = parametersPackage.SearchID(idPackage);
            txtValuePenalty.Text = drParameters["value_penalty"].ToString();
            txtValueInterest.Text = drParameters["value_interest"].ToString();
           
            if (drParameters["type_penalty"].ToString().Equals("money"))
                rbValuePenalty.Checked = true;
            else
                rbPercentagePenalty.Checked = true;
            
            if (drParameters["type_interest"].ToString().Equals("money"))
                rbValueInterest.Checked = true;
            else
                rbPercentageInterest.Checked = true;
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
            package._duration = int.Parse(ndDuration.Value.ToString());
            package._period = cbPeriod.Text;

            if (ValidateFields())
            {
                package.Save();
                if(string.IsNullOrWhiteSpace(txtValueInterest.Text))
                    parametersPackage._valueInterest = 0.00m;
                else 
                    parametersPackage._valueInterest = decimal.Parse(txtValueInterest.Text);

                if(string.IsNullOrWhiteSpace(txtValuePenalty.Text))
                    parametersPackage._valuePenalty = 0.00m;
                else
                    parametersPackage._valuePenalty = decimal.Parse(txtValuePenalty.Text);
            
                if (rbPercentageInterest.Checked)
                {
                    parametersPackage._typeInterest = "percentage";
                }
                else if (rbValueInterest.Checked)
                {
                    parametersPackage._typeInterest = "money";
                }
                if (rbPercentagePenalty.Checked)
                {
                    parametersPackage._typePenalty = "percentage";
                }
                else if (rbValuePenalty.Checked)
                {
                    parametersPackage._typePenalty = "money";
                }
              
                if (idPackage == 0)
                    parametersPackage._packageID = package.GetMaxId();
                else
                    parametersPackage._packageID = idPackage;

                parametersPackage.Save();
                
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

        private void txtValuePenalty_Leave(object sender, EventArgs e)
        {
            txtValuePenalty.Text = FormatTextBox.FormatValueDecimal(txtValuePenalty.Text);
        }

        private void txtValuePenalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                FormatTextBox.HandleFormatTextBox(txtValuePenalty, e);
            }
            catch
            {
                MessageBox.Show("Erro no valor de entrada. Digite o valor válido.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValueInterest_Leave(object sender, EventArgs e)
        {
            txtValueInterest.Text = FormatTextBox.FormatValueDecimal(txtValueInterest.Text);
        }

        private void txtValueInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                FormatTextBox.HandleFormatTextBox(txtValueInterest, e);
            }
            catch
            {
                MessageBox.Show("Erro no valor de entrada. Digite o valor válido.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsFormOfPayments())
            {
                dgvFormOfPagament.Rows.Add(Properties.Resources.icons8_pencil_25px, Properties.Resources.icons8_trash_25px, cbFormOfPayement.Text, $"R$ {txtValue.Text}");
                dgvFormOfPagament.ClearSelection();
            }
        }

        private bool ValidateFieldsFormOfPayments()
        {
            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Informe o valor!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValue.Focus();
                return false;
            }
            else if (cbFormOfPayement.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a forma de pagamento!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbFormOfPayement.Focus();
                return false;
            }

            return true;
        }
    }
}