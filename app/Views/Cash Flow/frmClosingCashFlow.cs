using Bussiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmClosingCashFlow : Form
    {
        string entryTimeCashFlow;
        decimal valueEntryBox, valueExitBox, valueReicept = 0.00M, balance;

        public FrmClosingCashFlow()
        {
            InitializeComponent();

            if (FrmGymControl.Instance._datePrevious)
                btnCancel.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new frmOptionClosingCashFlow(), this);
            FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo de Caixa";
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValueTotalBox.Text))
            {
                MessageBox.Show("Informe o valor total do caixa para prosseguir!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValueTotalBox.Focus();
                return;
            }

            try
            {
                CashFlow cash = new CashFlow();
                cash.ClosingBox(balance, FrmGymControl.Instance._IdCashFlow);

                if (FrmGymControl.Instance._datePrevious)
                {
                    var boxOpening = new FrmBoxOpening(FrmGymControl.Instance._datePrevious);
                    boxOpening.ShowDialog();

                    if (!boxOpening.theValueHasBeenInformed) return;

                    FrmGymControl.Instance._datePrevious = false;
                    FrmGymControl.Instance._IdCashFlow = cash.GetMaxCashFlowID();
                }

                OpenForm.ShowForm(new FrmHome(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClosingCashFlow_Load(object sender, EventArgs e)
        {
            lblOperator.Text = FrmGymControl.Instance._name;
            try
            {
                GetDataCashFlow(FrmGymControl.Instance._IdCashFlow);
                LoadDataHistoryPayment();
                SumValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumValues()
        {
            decimal valueCardCred = 0.00M, valueCardDeb = 0.00M, valueCard = 0.00M;

            foreach (DataGridViewRow row in dgvDataHistoryPayment.Rows)
            {
                if (row.Cells["formPayment"].Value.ToString().ToLower() == "cartão de crédito" || row.Cells["formPayment"].Value.ToString().ToLower() == "cartão de débito")
                    valueCard += decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(row.Cells["value"].Value.ToString()));
            }

            var cash = new CashFlow();
            cash.GetDateOpeningCashFlow();

            var icoming = new IcomingCashFlow().GetDataIcoming(FrmGymControl.Instance._IdCashFlow, entryTimeCashFlow, cash._openingDate);

            foreach (DataRow dr in icoming.Rows)
            {
                if (dr["description_icoming"].ToString().ToLower().Equals("valor adicionado na conta do pagamento do cartão de crédito"))
                {
                    valueCardCred += decimal.Parse(dr["value_card"].ToString());
                }
                else if (dr["description_icoming"].ToString().ToLower().Equals("valor adicionado na conta do pagamento do cartão de débito"))
                {
                    valueCardDeb += decimal.Parse(dr["value_card"].ToString());
                }
            }

            lblValueReceipt.Text = $"R$ {valueCard}";
            lblValueCardCred.Text = $"R$ {valueCardCred}";
            lblValueCardDeb.Text = $"R$ {valueCardDeb}";
        }

        private void LoadDataHistoryPayment()
        {
            var cash = new CashFlow();
            cash.GetDateOpeningCashFlow();

            var payment = new Payment().HistoryPayment(entryTimeCashFlow, cash._openingDate);
            foreach (DataRow dr in payment.Rows)
            {
                int countRow = dgvDataHistoryPayment.Rows.Add();
                dgvDataHistoryPayment.Rows[countRow].Cells["description"].Value = dr["description"].ToString();
                dgvDataHistoryPayment.Rows[countRow].Cells["value"].Value = $"R$ {dr["value_total"]}";
                dgvDataHistoryPayment.Rows[countRow].Cells["valueDiscount"].Value = $"R$ {dr["value_discount"]}";
                dgvDataHistoryPayment.Rows[countRow].Cells["formPayment"].Value = dr["form_payment"].ToString();
                dgvDataHistoryPayment.Rows[countRow].Cells["payday"].Value = dr["payday"].ToString();
                dgvDataHistoryPayment.Rows[countRow].Cells["paymentTime"].Value = dr["payment_time"].ToString();

                dgvDataHistoryPayment.Rows[countRow].MinimumHeight = 45;
            }

            dgvDataHistoryPayment.ClearSelection();
        }

        private void GetDataCashFlow(int idCashFlow)
        {
            var cashFlow = new CashFlow();
            var cashDate = cashFlow.SearchID(idCashFlow);

            valueEntryBox = decimal.Parse(new IcomingCashFlow().GetValueEntryInitial(idCashFlow).ToString());
            valueExitBox = decimal.Parse(cashDate.Rows[0]["output_value_total"].ToString());

            entryTimeCashFlow = cashDate.Rows[0]["opening_time"].ToString();
            lblNumberBox.Text = cashDate.Rows[0]["id"].ToString();
            lblDateEntry.Text = $"{cashDate.Rows[0]["opening_date"]}, {entryTimeCashFlow}";
            lblEntryBox.Text = $"R$ {valueEntryBox}";
            lblExitBox.Text = $"R$ {valueExitBox}";

            cashFlow.GetDateOpeningCashFlow();

            var payment = new Payment().GetSumValueTotalAndDiscount(entryTimeCashFlow, cashFlow._openingDate);

            valueReicept = !string.IsNullOrEmpty(payment.Rows[0]["valueTotal"].ToString()) ? decimal.Parse(payment.Rows[0]["valueTotal"].ToString()) : 0.00M;

            lblValueReicept.Text = $"R${valueReicept}";
            lblDiscount.Text = !string.IsNullOrEmpty(payment.Rows[0]["discount"].ToString()) ? $"R$ {payment.Rows[0]["discount"]}" : "R$ 0,00";
        }

        private void txtValueTotalBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValueTotalBox.Text))
            {
                balance = (decimal.Parse(txtValueTotalBox.Text) - ((valueReicept + valueEntryBox) - valueExitBox));

                lblBalance.Text = $"R$ {balance}";

                if (balance < 0)
                    lblBalance.ForeColor = Color.Red;
                else if (balance == 0)
                    lblBalance.ForeColor = Color.Black;
                else
                    lblBalance.ForeColor = Color.Green;
            }
            else
                lblBalance.Text = "";
        }

        private void txtValueTotalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtValueTotalBox, e);
        }

        private void txtValueTotalBox_Leave(object sender, EventArgs e)
        {
            txtValueTotalBox.Text = FormatTextBox.FormatValueDecimal(txtValueTotalBox.Text);
        }
    }
}
