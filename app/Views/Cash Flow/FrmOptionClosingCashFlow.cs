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
                {
                    FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo Caixa - Fechamento";
                    OpenForm.ShowForm(new FrmClosingCashFlow(), this);
                }
                else
                    MessageBox.Show("O caixa foi fechado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveMoney_Click(object sender, EventArgs e)
        {
            try
            {
                if (!new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                {
                    FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo Caixa - Retirar dinheiro";
                    OpenForm.ShowForm(new FrmExitMonewBox(), this);
                }
                else
                    MessageBox.Show("O caixa foi fechado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo Caixa - Registro";
                OpenForm.ShowForm(new FrmRegisterCashFlow(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegisterEntyAndExit(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmReportCashFlow(), this);
        }
    }
}
