using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DeposityBillit
{
    public partial class FrmContasPagar : Form
    {
        public FrmContasPagar()
        {
            InitializeComponent();
        }

        private void txt_ValorDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorDocumento.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Desconto.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_ValorDocumentoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorDocumentoQuitar.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_DescontoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_DescontoQuitar.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_Multa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Multa.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorPago.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_NumeroDocumentoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_NumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (txt_Beneficiario.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Beneficiario, "Campo obrigatório!");
                txt_Beneficiario.Focus();
                return;
            }
            else if (txt_Referente.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Referente, "Campo obrigatório!");
                txt_Referente.Focus();
                return;
            }
            else if (txt_NumeroDocumento.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_NumeroDocumento, "Campo obrigatório!");
                txt_NumeroDocumento.Focus();
                return;
            }
            else if (txt_ValorDocumento.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ValorDocumento, "Campo obrigatório!");
                txt_ValorDocumento.Focus();
                return;
            }
            else if (txt_Desconto.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Desconto, "Campo obrigatório!");
                txt_Desconto.Focus();
                return;
            }
            else
            {
                string status = "Não Pago";
                try
                {
                    MessageBox.Show("Valores gravados no banco de dados com sucesso!", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Limpar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txt_Beneficiario.Clear();
            txt_Referente.Clear();
            txt_NumeroDocumento.Clear();
            dt_Vencimento.Value = DateTime.Now;
            txt_ValorDocumento.Clear();
            txt_Desconto.Clear();
        }       
        int X = 0, Y = 0;

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        
        private void txt_Referente_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Vencimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumento_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Desconto_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Beneficiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_Referente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_NumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void mask_Vencimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_ValorDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_Desconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        string codigo = "";

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            string Status = "Pago";
            try
            {
                if (txt_BeneficiarioQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_BeneficiarioQuitar, "Campo obrigatório");
                    txt_BeneficiarioQuitar.Focus();
                    return;
                }
                else if (txt_ReferenteQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ReferenteQuitar, "Campo obrigatório");
                    txt_ReferenteQuitar.Focus();
                    return;
                }
                else if (txt_NumeroDocumentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_NumeroDocumentoQuitar, "Campo obrigatório");
                    txt_NumeroDocumentoQuitar.Focus();
                    return;
                }
                else if (mask_VencimentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(mask_VencimentoQuitar, "Campo obrigatório");
                    mask_VencimentoQuitar.Focus();
                    return;
                }
                else if (txt_ValorDocumentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ValorDocumentoQuitar, "Campo obrigatório");
                    txt_ValorDocumentoQuitar.Focus();
                    return;
                }
                else if (txt_DescontoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_DescontoQuitar, "Campo obrigatório");
                    txt_DescontoQuitar.Focus();
                    return;
                }
                else if (txt_Multa.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Multa, "Campo obrigatório");
                    txt_Multa.Focus();
                    return;
                }
                else if (txt_ValorPago.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ValorPago, "Campo obrigatório");
                    txt_ValorPago.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Boleto quitado com sucesso", "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_LimparQuitar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LimparQuitar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txt_ValorDocumentoQuitar.Clear();
            txt_BeneficiarioQuitar.Clear();
            txt_DescontoQuitar.Clear();
            txt_NumeroDocumentoQuitar.Clear();
            txt_ReferenteQuitar.Clear();
            txt_ValorDocumentoQuitar.Clear();
            txt_ValorPago.Clear();
            txt_Multa.Clear();
            mask_VencimentoQuitar.Clear();
        }

        private void txt_Beneficiario_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumentoQuitar_TextChanged(object sender, EventArgs e)
        {
            txt_ValorPago.Text = txt_ValorDocumentoQuitar.Text;
        }

        private void txt_Multa_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if ((txt_Multa.Text != "") && (txt_ValorPago.Text != "") && (txt_ValorDocumentoQuitar.Text != ""))
            {
                double VD = double.Parse(txt_ValorDocumentoQuitar.Text), Multa = double.Parse(txt_Multa.Text);
                txt_ValorPago.Text = (VD + Multa).ToString();
            }
        }

        private void txt_ValorPago_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_VencimentoQuitar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_BeneficiarioQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ReferenteQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroDocumentoQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DescontoQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumento_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorDocumento.Text != "")
                {
                    txt_ValorDocumento.Text = decimal.Parse(txt_ValorDocumento.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorDocumento.Clear();
            }
        }

        private void txt_Desconto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Desconto.Text != "")
                {
                    txt_Desconto.Text = decimal.Parse(txt_Desconto.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Desconto.Clear();
            }
        }

        private void txt_Multa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Multa.Text != "")
                {
                    txt_Multa.Text = decimal.Parse(txt_Multa.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Desconto.Clear();
            }
        }

        private void txt_ValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorPago.Text != "")
                {
                    txt_ValorPago.Text = decimal.Parse(txt_ValorPago.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorPago.Clear();
                txt_ValorPago.Clear();
            }
        }



        private void cbMaxRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
