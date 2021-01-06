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
