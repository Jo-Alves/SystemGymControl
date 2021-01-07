using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class frmOptionClosingCashFlow : Form
    {
        public frmOptionClosingCashFlow()
        {
            InitializeComponent();
        }

        private void btnClosingBox_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmClosingCashFlow(), this);
        }
    }
}
