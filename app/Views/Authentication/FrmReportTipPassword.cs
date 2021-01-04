using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportTipPassword : Form
    {
        public FrmReportTipPassword(string PerguntaSeguranca)
        {
            InitializeComponent();
            //lbl_PerguntaSeguranca.Text = PerguntaSeguranca;
        }

        public string RespostaSeguranca { get; set; }
        public string AcaoFechar { get; set; }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_DicaSenha.Text == "")
            {
                MessageBox.Show("Digite a dica de senha!", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RespostaSeguranca = txt_DicaSenha.Text.Trim();
                txt_DicaSenha.Clear();
                txt_DicaSenha.Focus();
                this.Close();
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            RespostaSeguranca = "";
            AcaoFechar = "Fechar";
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
