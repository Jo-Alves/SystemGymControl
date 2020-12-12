using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemGymControl
{
    public partial class FrmCashInPayment : Form
    {
        decimal valuePackage;
        public bool paymentCancel { get; set; }

        public FrmCashInPayment()
        {
            InitializeComponent();
        }

        public FrmCashInPayment(decimal valuePackage)
        {
            InitializeComponent();
            this.valuePackage = valuePackage;
            lblValuePackage.Text = $"R$ {valuePackage}";
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
                    break;
                case false:
                    lblDiscountMoney.Visible = false;
                    lblDiscountPercentage.Visible = false;
                    lblValueWithDiscount.Visible = false;
                    txtDiscountMoney.Visible = false;
                    txtDiscountPercentage.Visible = false;
                    txtValueWithDiscount.Visible = false;
                    break;
            }
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            paymentCancel = true;

            this.Close();
        }
    }
}
