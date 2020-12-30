using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmEffectPayment : Form
    {
        public bool paymentCancel { get; set; }
        public decimal valuePaidOut { get; set; }
        public decimal valueDiscount = 0.00m;
        public decimal change { get; set; }
        public decimal discountMoney = 0.00m;
        decimal valueTotal, amountReceivable;
        DataTable dataPlanCash; 
        int daysDelay;

        public FrmEffectPayment()
        {
            InitializeComponent();
        }

        public FrmEffectPayment(int idCash)
        {
            InitializeComponent();

            try
            {
                cbFormOfPayment.SelectedIndex = 2;

                dataPlanCash = new Bussiness.Payment().SearchCashPaymentPlanIDCash(idCash);

                LoadFields(dataPlanCash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private int GetValueDaysDelay()
        {
            int daysDelay = 0;

            DateTime dueDate = Convert.ToDateTime(txtDuedate.Text);
            if (DateTime.Now > dueDate)
            {
                TimeSpan timeSpan;
                timeSpan = DateTime.Now.Subtract(dueDate);
                daysDelay = timeSpan.Days;
            }

            return daysDelay;
        }

        private void LoadFields(DataTable dataPlanCash)
        {
            txtIdStudent.Text = dataPlanCash.Rows[0]["idStudent"].ToString();
            txtName.Text = dataPlanCash.Rows[0]["name"].ToString();
            txtValuePlan.Text = $"R$ {dataPlanCash.Rows[0]["valuePackage"]}";
            txtDuedate.Text = dataPlanCash.Rows[0]["duedate"].ToString();
            txtPayDay.Text = DateTime.Now.ToShortDateString();
            daysDelay = GetValueDaysDelay();
            txtDaysOfDelay.Text = $"{daysDelay} dia(s)";

            valueTotal = decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(txtValuePlan.Text));

            decimal valueInterestMoney, valuePenaltyMoney;
            if (dataPlanCash.Rows[0]["type_interest"].ToString().ToLower() == "percentage")
            {
                decimal valueInterest = decimal.Parse(dataPlanCash.Rows[0]["value_interest"].ToString());

                valueInterestMoney = (valueInterest * valueTotal) / 100;
                txtValueInterest.Text = $"R$ {valueInterestMoney.ToString("0.00")}";
            }
            else
            {
                valueInterestMoney = decimal.Parse(dataPlanCash.Rows[0]["value_interest"].ToString());
                txtValueInterest.Text = $"R$ {valueInterestMoney}";
            }

            if (dataPlanCash.Rows[0]["type_penalty"].ToString().ToLower() == "percentage")
            {
                decimal valuePenalty = decimal.Parse(dataPlanCash.Rows[0]["value_penalty"].ToString());

                valuePenaltyMoney = (valuePenalty * valueTotal) / 100;

                txtValuePenalty.Text = $"R$ {valuePenaltyMoney.ToString("0.00")}";
            }
            else
            {
                valuePenaltyMoney = decimal.Parse(dataPlanCash.Rows[0]["value_penalty"].ToString());
                txtValuePenalty.Text = $"R$ {valuePenaltyMoney}";
            }

            if (daysDelay >= 1)
            {
                CalculatePenaltyAndInteres(valuePenaltyMoney, valueInterestMoney, daysDelay);
                txtDiscount.Enabled = false;
            }
            else
            {
                amountReceivable = valueTotal;
                txtAmountReceivable.Text = $"R$ {valueTotal}";
            }
        }

        // Ao método função de somar o valor total com os juros e a multa penalizada
        private void CalculatePenaltyAndInteres(decimal valuePenaltyMoney, decimal valueInterestMoney, int daysDelay)
        {
            amountReceivable = valueTotal + valuePenaltyMoney + (valueInterestMoney * daysDelay);
            txtAmountReceivable.Text = $"R$ {amountReceivable}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmCashInPayment_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                try
                {
                    discountMoney = decimal.Parse(txtDiscount.Text);
                    if (discountMoney <= amountReceivable)
                    {
                        txtDiscount.Text = FormatTextBox.FormatValueDecimal(txtDiscount.Text);
                        if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
                            txtChange.Text = $"R$ {(decimal.Parse(txtPaidOut.Text) - (amountReceivable - discountMoney))}";

                        valueDiscount = amountReceivable - discountMoney;
                    }
                    else
                    {
                        txtAmountReceivable.Text = amountReceivable.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscount.Text = "0,00";
                }
            }
            else
            txtDiscount.Text = "0,00";
        }

        private void txtPaidOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtPaidOut, e);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtPaidOut.Text))
            //{
            //    MessageBox.Show("Informe o valor pago!", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //change = decimal.Parse(txtChange.Text);
            //if (valueDiscount == 0.00M && discountMoney < valuePackage)
            //    valueDiscount = valuePackage;

            //if (decimal.Parse(txtPaidOut.Text) < valueDiscount)
            //{
            //    MessageBox.Show("Valor em dinheiro menor do que o valor total da venda!", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            paymentCancel = true;

            this.Close();
        }

        private void cbCalculateInaterastAndPenalty_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCalculateInaterastAndPenalty.Checked)
            {
                txtAmountReceivable.Text = $"R$ {valueTotal}";
                txtValueInterest.Enabled = false;
                txtValuePenalty.Enabled = false;
                txtValuePlan.Enabled = false;
                txtDiscount.Enabled = true;
            }
            else
            {
                txtValueInterest.Enabled = true;
                txtValuePenalty.Enabled = true;
                txtValuePlan.Enabled = true;
                LoadFields(dataPlanCash);
                if(daysDelay > 1)
                {
                    txtDiscount.Enabled = false;
                    txtDiscount.Text = "0,00";
                }
            }

            txtPaidOut_Leave(sender, e);
            txtDiscount_Leave(sender, e);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                txtDiscount.Text = "0,00";
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtDiscount, e);
        }

        private void txtPaidOut_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
                {                    
                    txtDiscount_Leave(sender, e);

                    txtPaidOut.Text = FormatTextBox.FormatValueDecimal(txtPaidOut.Text);
                    valuePaidOut = decimal.Parse(txtPaidOut.Text);
                }
                else
                    txtChange.Clear();
            }
            catch
            {
                MessageBox.Show("Valor digitado inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
