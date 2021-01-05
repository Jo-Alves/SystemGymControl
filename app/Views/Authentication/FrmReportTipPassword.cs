using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportTipPassword : Form
    {
        public FrmReportTipPassword(string question)
        {
            InitializeComponent();
            txtQuestionSecurity.Text = question;
        }

        public string RespostaSeguranca { get; set; }
        public string AcaoFechar { get; set; }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txtAnswerSecurity.Text == "")
            {
                MessageBox.Show("Digite a dica de senha!", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RespostaSeguranca = txtAnswerSecurity.Text.Trim();
                txtAnswerSecurity.Clear();
                txtAnswerSecurity.Focus();
                this.Close();
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            RespostaSeguranca = "";
            AcaoFechar = "Fechar";
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            new FrmResetPassword().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
