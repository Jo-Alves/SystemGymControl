using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmCardInPayment : Form
    {
        public bool paymentEffected { get; set; }
        public bool generateReceipt = false;
        public int nPortion { get; set; }
        public string dueDate { get; set; }

        decimal valuePackage;
        string formPayment;
        public FrmCardInPayment()
        {
            InitializeComponent();
        }

        public FrmCardInPayment(decimal valuePackage, int numberPortions, string formPayment, string period)
        {
            InitializeComponent();

            this.formPayment = formPayment;
            if (this.formPayment == "Cartão de Débito" || period.ToLower() == "mensal" || period.ToLower() == "diário")
            {
                ndNumberPortions.Enabled = false;
                ndNumberPortions.Value = 1;
                numberPortions = 1;
            }
            this.valuePackage = valuePackage;
            lblvalueTotal.Text = $"R$ {valuePackage}";
            ndNumberPortions.Value = numberPortions;
            parcelValue(valuePackage, numberPortions, formPayment);
        }

        private void parcelValue(decimal valuePackage, int numberPortions, string formPayment)
        {

            DateTime dateNow = DateTime.Now;
            dueDate = formPayment.ToLower() == "cartão de crédito" ? dateNow.AddMonths(1).ToShortDateString() : dateNow.AddDays(numberPortions).ToShortDateString();
            lblValuePortion.Text = $"R$ {(valuePackage / numberPortions).ToString("0.00")}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            nPortion = int.Parse(ndNumberPortions.Value.ToString());
            paymentEffected = true;
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmCardInPayment_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ndNumberPortions_ValueChanged(object sender, EventArgs e)
        {
            parcelValue(valuePackage, int.Parse(ndNumberPortions.Value.ToString()), formPayment);
        }

        private void FrmCardInPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFinish_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            generateReceipt = true;
            btnFinish_Click(sender, e);
        }
    }
}
