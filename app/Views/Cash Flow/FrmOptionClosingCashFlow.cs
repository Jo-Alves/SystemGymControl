using Bussiness;
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
            try
            {
                if (!new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                    OpenForm.ShowForm(new FrmClosingCashFlow(), this);
                else
                    MessageBox.Show("O caixa foi fechado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (!new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                {

                }
                else
                    MessageBox.Show("O caixa foi fechado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
