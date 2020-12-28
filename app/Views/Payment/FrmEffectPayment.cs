using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmEffectPayment : Form
    {
        decimal valuePackage;
        public bool paymentCancel { get; set; }
        public decimal valuePaidOut { get; set; }
        public decimal valueDiscount = 0.00m;
        public decimal change { get; set; }
        public decimal discountMoney = 0.00m;
        decimal ValorDescontoPorcento, DiscountPercentage;

        public FrmEffectPayment()
        {
            InitializeComponent();
        }

        public FrmEffectPayment(int idCash)
        {
            InitializeComponent();

            try
            {
                DataTable dataPlanCash = new Bussiness.CashPayment().SearchCashPaymentPlanIDCash(idCash);

                LoadFields(dataPlanCash);
                CheckedDaysDelay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.valuePackage = valuePackage;
            //txtValuePlan.Text = $"R$ {valuePackage}";
        }

        private void CheckedDaysDelay()
        {
            DateTime dueDate = Convert.ToDateTime(txtDuedate.Text);
            if (DateTime.Now > dueDate)
            {
                TimeSpan timeSpan;
                timeSpan = DateTime.Now.Subtract(dueDate);
                txtDaysOfDelay.Text = $"{timeSpan.Days} dia(s)";
            }
        }

        private void LoadFields(DataTable dataPlanCash)
        {
            txtIdStudent.Text = dataPlanCash.Rows[0]["idStudent"].ToString();
            txtName.Text = dataPlanCash.Rows[0]["name"].ToString();
            txtValuePlan.Text = $"R$ {dataPlanCash.Rows[0]["valuePackage"]}";
            txtValuePenalty.Text = $"R$ {dataPlanCash.Rows[0]["value_penalty"]}";
            txtValueInterest.Text = $"R$ {dataPlanCash.Rows[0]["value_interest"]}";
            txtDuedate.Text = dataPlanCash.Rows[0]["duedate"].ToString();
            txtPayDay.Text = DateTime.Now.ToShortDateString();

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

        //private void txtPaidOut_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
        //        {
        //            txtPaidOut.Text = FormatTextBox.FormatValueDecimal(txtPaidOut.Text);
        //            valuePaidOut = decimal.Parse(txtPaidOut.Text.Trim());
        //            change = valuePaidOut - decimal.Parse(txtValueWithDiscount.Text);
        //            txtChange.Text = change.ToString();
        //            txtPaidOut.Text = valuePaidOut.ToString();
        //            if (txtValueWithDiscount.Text != "0,00")
        //            {
        //                txtChange.Text = (decimal.Parse(txtPaidOut.Text) - decimal.Parse(txtValueWithDiscount.Text)).ToString();
        //            }
        //        }
        //        else
        //            txtChange.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtPaidOut.Clear();
        //    }
        //}

        //private void txtDiscountMoney_Leave(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(txtDiscountMoney.Text))
        //    {
        //        try
        //        {
        //            discountMoney = decimal.Parse(txtDiscountMoney.Text);
        //            if (discountMoney <= valuePackage)
        //            {
        //                txtDiscountMoney.Text = FormatTextBox.FormatValueDecimal(txtDiscountMoney.Text);
        //                txtValueWithDiscount.Text = (valuePackage - discountMoney).ToString();

        //                if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
        //                    txtChange.Text = (valuePaidOut - decimal.Parse(txtValueWithDiscount.Text)).ToString();

        //                valueDiscount = decimal.Parse(txtValueWithDiscount.Text);
        //                DiscountPercentage = (100 * discountMoney) / valuePackage;
        //                DiscountPercentage = Math.Round(DiscountPercentage, 2);
        //                txtDiscountPercentage.Text = Math.Round(DiscountPercentage, 2).ToString();
        //            }
        //            else
        //            {
        //                txtDiscountPercentage.Text = "0,00";
        //                txtDiscountMoney.Text = "0,00";
        //                DiscountPercentage = 0.00M;
        //                discountMoney = 0.00M;
        //                txtValueWithDiscount.Text = valuePackage.ToString();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtDiscountMoney.Text = "0,00";
        //        }
        //    }
        //}

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
    }
}
