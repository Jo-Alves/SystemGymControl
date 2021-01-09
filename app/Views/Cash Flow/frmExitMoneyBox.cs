using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class frmExitMonewBox : Form
    {
        string entryTimeCashFlow;
        decimal valueEntryBox, valueExitBox, valueTotalCash;

        public frmExitMonewBox()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new frmOptionClosingCashFlow(), this);
            FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo de Caixa";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWithdrawMoney.Text))
            {
                MessageBox.Show("Informe o valor para retirar do caixa!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWithdrawMoney.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Descreva o motivo a finalidade de retirar o valor do caixa!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else if (decimal.Parse(txtWithdrawMoney.Text) > valueTotalCash)
            {
                MessageBox.Show("O valor informado é maior que o valor do caixa!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }

            try
            {
                try
                {
                    new OutgoingCashFlow()
                    {
                        _cashFlowID = FrmGymControl.Instance._IdCashFlow,
                        _descriptionExit = txtDescription.Text.Trim(),
                        _exitDate = DateTime.Now.ToShortDateString(),
                        _exitTime = DateTime.Now.ToLongTimeString(),
                        _valueOutput = decimal.Parse(txtWithdrawMoney.Text)
                    }.ExitMoney();

                    OpenForm.ShowForm(new FrmHome(), this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExitMonewBox_Load(object sender, EventArgs e)
        {
            lblOperator.Text = FrmGymControl.Instance._name;
            try
            {
                GetDataCashFlow(FrmGymControl.Instance._IdCashFlow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void GetDataCashFlow(int idCashFlow)
        {
            var cashFlow = new CashFlow().SearchID(idCashFlow);

            valueTotalCash = decimal.Parse(cashFlow.Rows[0]["cash_value_total"].ToString());

            valueEntryBox = decimal.Parse(new IcomingCashFlow().GetValueEntryInitial(idCashFlow).ToString());
            valueExitBox = decimal.Parse(cashFlow.Rows[0]["output_value_total"].ToString());

            entryTimeCashFlow = cashFlow.Rows[0]["opening_time"].ToString();
            lblNumberBox.Text = cashFlow.Rows[0]["id"].ToString();
            lblDateEntry.Text = $"{cashFlow.Rows[0]["opening_date"]}, {entryTimeCashFlow}";
            lblEntryBox.Text = $"R$ {valueEntryBox}";
            lblExitBox.Text = $"R$ {valueExitBox}";

            lblValueReicept.Text = ((valueTotalCash + decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(lblExitBox.Text))) - (decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(lblEntryBox.Text)))).ToString();
        }

       private void txtWithdrawMoney_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWithdrawMoney.Text))
            {

            }
            else
            { 
                
            }
        }

        private void txtWithdrawMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtWithdrawMoney, e);
        }

        private void txtWithdrawMoney_Leave(object sender, EventArgs e)
        {
            txtWithdrawMoney.Text = FormatTextBox.FormatValueDecimal(txtWithdrawMoney.Text);
        }
    }
}
