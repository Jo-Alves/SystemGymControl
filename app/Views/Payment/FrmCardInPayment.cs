using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmCardInPayment : Form
    {

        public bool paymentCancel { get; set; }
        public FrmCardInPayment()
        {
            InitializeComponent();           
        } 
        public FrmCardInPayment(decimal valuePackage)
        {
            InitializeComponent();
            lblvalueTotal.Text = $"R$ {valuePackage}";
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
            paymentCancel = true;
        }
    }
}
