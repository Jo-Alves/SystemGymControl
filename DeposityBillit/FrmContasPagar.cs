using System;
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
                try
                {
                    new BillyToPay()
                    {
                        recipient = txt_Beneficiario.Text.Trim(),
                        refering = txt_Referente.Text.Trim(),
                        duedate = dt_Vencimento.Text.Trim(),
                        number = txt_NumeroDocumento.Text.Trim(),
                        value = decimal.Parse(txt_ValorDocumento.Text),
                        discount = decimal.Parse(txt_Desconto.Text)
                    }.Save();

                    MessageBox.Show("Inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDataBillyToPay();
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Limpar()
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
                else if (decimal.Parse(txt_ValorPago.Text) < decimal.Parse(txt_ValorDocumentoQuitar.Text))
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ValorPago, "Valor é menor que o valor do documento");
                    MessageBox.Show("Valor é menor que o valor do documento!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_ValorPago.Focus();
                    return;
                }
                else
                {
                    new BillyToPay()
                    {
                        id = idBilly,
                        recipient = txt_BeneficiarioQuitar.Text.Trim(),
                        refering = txt_ReferenteQuitar.Text.Trim(),
                        duedate = mask_VencimentoQuitar.Text.Trim(),
                        number = txt_NumeroDocumentoQuitar.Text.Trim(),
                        value = decimal.Parse(txt_ValorDocumentoQuitar.Text),
                        discount = decimal.Parse(txt_DescontoQuitar.Text),
                        amountPaid = decimal.Parse(txt_ValorPago.Text),
                        penalty = decimal.Parse(txt_Multa.Text)
                    }.Save();

                    GetDataBillyToPay();
                    MessageBox.Show("Boleto quitado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            errorProvider.Clear();
            idBilly = 0;
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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorPago.Clear();
                txt_ValorPago.Clear();
            }
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
            GetDataBillyToPay();
        }

        private void GetDataBillyToPay()
        {
            try
            {
                dgv.DataSource = new BillyToPay().GetDataBillyToPay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                tabControl1.SelectedTab = tabPage3;
                CarregarCampos();
                dgv.ClearSelection();
            }
        }

        int idBilly;

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgv.ClearSelection();
            }
        }

        private void CarregarCampos()
        {
            idBilly = int.Parse(dgv.CurrentRow.Cells["id"].Value.ToString());
            txt_BeneficiarioQuitar.Text = dgv.CurrentRow.Cells["recipient"].Value.ToString();
            txt_DescontoQuitar.Text = dgv.CurrentRow.Cells["discount"].Value.ToString();
            txt_NumeroDocumentoQuitar.Text = dgv.CurrentRow.Cells["number"].Value.ToString();
            txt_ReferenteQuitar.Text = dgv.CurrentRow.Cells["refering"].Value.ToString();
            txt_ValorDocumentoQuitar.Text = dgv.CurrentRow.Cells["value"].Value.ToString();
            mask_VencimentoQuitar.Text = dgv.CurrentRow.Cells["duedate"].Value.ToString();
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
