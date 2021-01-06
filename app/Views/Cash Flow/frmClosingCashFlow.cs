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
    public partial class FrmClosingCashFlow : Form
    {
        public FrmClosingCashFlow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new frmOptionClosingCashFlow(), this);
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmHome(), this);
        }
    }
}
