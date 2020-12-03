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
        ItemsPackage itemsPackage = new ItemsPackage();

        int idPackage, idParametersPackage, idItemsPackage, idMaxPackage, indexRowSelected = -1;

        public FrmSavePackage()
        {
            InitializeComponent();
            txtDescription.Focus();
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
                GetItemsPackage(idPackage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetItemsPackage(int idPackage)
        {
            foreach(DataRow dr in itemsPackage.SearchID(idPackage).Rows)
            {
                int countRow = dgvFormOfPagament.Rows.Add();
                dgvFormOfPagament.Rows[countRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvFormOfPagament.Rows[countRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvFormOfPagament.Rows[countRow].Cells["id"].Value = dr["id"].ToString();
                dgvFormOfPagament.Rows[countRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();
                dgvFormOfPagament.Rows[countRow].Cells["value"].Value = $"R$ {dr["value"].ToString()}";

                dgvFormOfPagament.Rows[countRow].MinimumHeight = 45;
                dgvFormOfPagament.ClearSelection();
            }
        }

        private void GetParametersPackage(int idPackage)
        {
            var drParameters = parametersPackage.SearchID(idPackage);
            txtValuePenalty.Text = drParameters["value_penalty"].ToString();
            txtValueInterest.Text = drParameters["value_interest"].ToString();
            idParametersPackage = int.Parse(drParameters["id"].ToString());


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
            try
            {
              
                package._id = idPackage;
                package._description = txtDescription.Text.Trim();
                package._duration = int.Parse(ndDuration.Value.ToString());
                package._period = cbPeriod.Text;

                if (ValidateFields())
                {
                    package.Save();
                    idMaxPackage = package.GetMaxId();

                    SaveParametersPackage();

                    SaveItemsPackage();

                    OpenForm.ShowForm(new FrmPackage(), this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveItemsPackage()
        {
            foreach(DataGridViewRow row in dgvFormOfPagament.Rows)
            {
                
                itemsPackage._formOfPayment = row.Cells["formOfPayment"].Value.ToString();
                itemsPackage._valuePackage = decimal.Parse(RemoveDollarSignGetValue(row.Cells["value"].Value.ToString()));
                if (idPackage == 0)
                    itemsPackage._packageID = idMaxPackage;
                else
                    itemsPackage._packageID = idPackage;
                itemsPackage._id = int.Parse(row.Cells["id"].Value.ToString());
                itemsPackage.Save();
            }
        }

        private string RemoveDollarSignGetValue(string value)
        {
            int lenghtValue = value.Length;
            return value.Substring(3, lenghtValue - 3);
        }

        private void SaveParametersPackage()
        {
            if (string.IsNullOrWhiteSpace(txtValueInterest.Text))
                parametersPackage._valueInterest = 0.00m;
            else
                parametersPackage._valueInterest = decimal.Parse(txtValueInterest.Text);

            if (string.IsNullOrWhiteSpace(txtValuePenalty.Text))
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
                parametersPackage._packageID = idMaxPackage;
            else
                parametersPackage._packageID = idPackage;

            parametersPackage._id = idParametersPackage;
            parametersPackage.Save();
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
            else if(dgvFormOfPagament.Rows.Count == 0)
            {
                MessageBox.Show("Informe o valor do pacote e a forma de pagamento", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValue.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        private void dgvFormOfPagament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idItemsPackage = int.Parse(dgvFormOfPagament.CurrentRow.Cells["id"].Value.ToString());

                if (dgvFormOfPagament.CurrentCell.ColumnIndex == 0)
                {
                    txtValue.Text = RemoveDollarSignGetValue(dgvFormOfPagament.CurrentRow.Cells["value"].Value.ToString());
                    cbFormOfPayment.Text = dgvFormOfPagament.CurrentRow.Cells["formOfPayment"].Value.ToString();
                    indexRowSelected = dgvFormOfPagament.CurrentRow.Index;
                }

                if (dgvFormOfPagament.CurrentCell.ColumnIndex == 1)
                {
                    if (dgvFormOfPagament.Rows.Count == 1)
                    {
                        MessageBox.Show("Não é permitido a exclusão! O pacote tem que ter no mínimo um valor informado no sistema.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (MessageBox.Show("Deseja mesmo excluir este valor?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        itemsPackage.Delete(idItemsPackage);

                        dgvFormOfPagament.Rows.Remove(dgvFormOfPagament.CurrentRow);
                    }
                }
            }
        }

        private void dgvFormOfPagament_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvFormOfPagament.ClearSelection();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsFormOfPayments())
            {
                if (indexRowSelected == -1)
                {
                    dgvFormOfPagament.Rows.Add(Properties.Resources.icons8_pencil_25px, Properties.Resources.icons8_trash_25px, "0", cbFormOfPayment.Text, $"R$ {txtValue.Text}");
                    dgvFormOfPagament.Rows[dgvFormOfPagament.Rows.Count - 1].MinimumHeight = 45;
                }
                else
                {
                    dgvFormOfPagament.Rows[indexRowSelected].Cells["value"].Value = $"R$ {txtValue.Text}";
                    dgvFormOfPagament.Rows[indexRowSelected].Cells["formOfPayment"].Value = cbFormOfPayment.Text;
                    indexRowSelected = -1;
                }

                cbFormOfPayment.SelectedIndex = -1;
                txtValue.Clear();
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
            else if (cbFormOfPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a forma de pagamento!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbFormOfPayment.Focus();
                return false;
            }

            return true;
        }
    }
}