﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmCashInPayment : Form
    {
        decimal valuePackage;
        public bool paymentEffected { get; set; }
        public bool generateReceipt = false;
        public decimal valuePaidOut { get; set; }
        public decimal valueDiscount = 0.00m;
        public decimal change { get; set; }
        public decimal discountMoney = 0.00m;
        decimal ValorDescontoPorcento, DiscountPercentage;

        public FrmCashInPayment()
        {
            InitializeComponent();
        }

        public FrmCashInPayment(decimal valuePackage)
        {
            InitializeComponent();
            this.valuePackage = valuePackage;
            lblValuePackage.Text = $"R$ {valuePackage}";
            txtValueWithDiscount.Text = this.valuePackage.ToString();
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

        bool goDiscount;

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            goDiscount = !goDiscount;
            switch (goDiscount)
            {
                case true:
                    lblDiscountMoney.Visible = true;
                    lblDiscountPercentage.Visible = true;
                    lblValueWithDiscount.Visible = true;
                    txtDiscountMoney.Visible = true;
                    txtDiscountPercentage.Visible = true;
                    txtValueWithDiscount.Visible = true;
                    valueDiscount = decimal.Parse(txtValueWithDiscount.Text);
                    break;
                case false:
                    lblDiscountMoney.Visible = false;
                    lblDiscountPercentage.Visible = false;
                    lblValueWithDiscount.Visible = false;
                    txtDiscountMoney.Visible = false;
                    txtDiscountPercentage.Visible = false;
                    txtValueWithDiscount.Visible = false;
                    txtDiscountMoney.Text = "0,00";
                    txtDiscountPercentage.Text = "0,00";
                    valueDiscount = decimal.Parse(txtValueWithDiscount.Text);
                    txtChange.Text = (valuePaidOut - valuePackage).ToString();
                    discountMoney = 0.00m;
                    txtDiscountMoney.Focus();
                    break;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmCashInPayment_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPaidOut_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
                {
                    txtPaidOut.Text = FormatTextBox.FormatValueDecimal(txtPaidOut.Text);
                    valuePaidOut = decimal.Parse(txtPaidOut.Text.Trim());
                    change = valuePaidOut - decimal.Parse(txtValueWithDiscount.Text);
                    txtChange.Text = change.ToString();
                    txtPaidOut.Text = valuePaidOut.ToString();
                    if (txtValueWithDiscount.Text != "0,00")
                    {
                        txtChange.Text = (decimal.Parse(txtPaidOut.Text) - decimal.Parse(txtValueWithDiscount.Text)).ToString();
                    }
                }
                else
                    txtChange.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidOut.Clear();
            }
        }

        private void txtDiscountMoney_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiscountMoney.Text))
            {
                try
                {
                    discountMoney = decimal.Parse(txtDiscountMoney.Text);
                    if (discountMoney <= valuePackage)
                    {
                        txtDiscountMoney.Text = FormatTextBox.FormatValueDecimal(txtDiscountMoney.Text);
                        txtValueWithDiscount.Text = (valuePackage - discountMoney).ToString();

                        if (!string.IsNullOrWhiteSpace(txtPaidOut.Text))
                            txtChange.Text = (valuePaidOut - decimal.Parse(txtValueWithDiscount.Text)).ToString();

                        valueDiscount = decimal.Parse(txtValueWithDiscount.Text);
                        DiscountPercentage = (100 * discountMoney) / valuePackage;
                        DiscountPercentage = Math.Round(DiscountPercentage, 2);
                        txtDiscountPercentage.Text = Math.Round(DiscountPercentage, 2).ToString();
                    }
                    else
                    {
                        txtDiscountPercentage.Text = "0,00";
                        txtDiscountMoney.Text = "0,00";
                        DiscountPercentage = 0.00M;
                        discountMoney = 0.00M;
                        txtValueWithDiscount.Text = valuePackage.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscountMoney.Text = "0,00";
                }
            }
        }

        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiscountPercentage.Text))
            {
                try
                {
                    ValorDescontoPorcento = decimal.Parse(txtDiscountPercentage.Text);
                    txtDiscountPercentage.Text = FormatTextBox.FormatValueDecimal(txtDiscountPercentage.Text);
                    if (ValorDescontoPorcento <= 100)
                    {
                        DiscountPercentage = (valuePackage * ValorDescontoPorcento) / 100;
                        DiscountPercentage = Math.Round(DiscountPercentage, 2);
                        txtDiscountMoney.Text = DiscountPercentage.ToString();
                        valueDiscount = valuePaidOut - DiscountPercentage;
                        txtValueWithDiscount.Text = valueDiscount.ToString();
                        txtDiscountMoney_Leave(sender, e);
                        txtDiscountPercentage.Text = FormatTextBox.FormatValueDecimal(txtDiscountPercentage.Text);
                    }
                    else
                    {
                        txtDiscountPercentage.Text = "0,00";
                        txtDiscountMoney.Text = "0,00";
                        DiscountPercentage = 0.00M;
                        discountMoney = 0.00M;
                        txtValueWithDiscount.Text = valuePackage.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscountPercentage.Text = "0,00";
                }
            }
        }

        private void txtPaidOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtPaidOut, e);
        }

        private void txtDiscountPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtDiscountPercentage, e);
        }

        private void txtDiscountMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtDiscountMoney, e);
        }

        private void txtDiscountPercentage_Click(object sender, EventArgs e)
        {
            txtDiscountPercentage.Text = FormatTextBox.FormatValueDecimal(txtDiscountPercentage.Text);
        }

        private void FrmCashInPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFinish_Click(sender, e);
            else if (e.KeyCode == Keys.F10)
                btnGenerateReceipt_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            generateReceipt = true;
            btnFinish_Click(sender, e);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaidOut.Text))
            {
                MessageBox.Show("Informe o valor pago!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            change = decimal.Parse(txtChange.Text);
            if (valueDiscount == 0.00M && discountMoney < valuePackage)
                valueDiscount = valuePackage;

            if (decimal.Parse(txtPaidOut.Text) < valueDiscount)
            {
                MessageBox.Show("Valor em dinheiro menor do que o valor a receber!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            paymentEffected = true;

            this.Close();
        }
    }
}
