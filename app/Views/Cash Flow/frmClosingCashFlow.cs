using Bussiness;
using System;
using System.Data;
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

        private void FrmClosingCashFlow_Load(object sender, EventArgs e)
        {
            lblOperator.Text = FrmGymControl.Instance._nameUser;
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
            decimal discount = 0.00M, valueReicept = 0.00M, valueCardCred = 0.00M, valueCardDeb = 0.00M;

            foreach (DataGridViewRow row in dgvDataHistoryPayment.Rows)
            {
                discount += decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(row.Cells["valueDiscount"].Value.ToString()));

               if(row.Cells["formPayment"].Value.ToString().ToLower() == "cartão de crédito")
                    valueCardCred += decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(row.Cells["value"].Value.ToString()));
               else if(row.Cells["formPayment"].Value.ToString().ToLower() == "cartão de débito")
                    valueCardDeb += decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(row.Cells["value"].Value.ToString()));
               else if (row.Cells["formPayment"].Value.ToString().ToLower() == "dinheiro")
                    valueReicept += decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(row.Cells["value"].Value.ToString()));
            }

            lblDiscount.Text = $"R$ {discount}";
            lblValueReicept.Text = $"R$ {valueReicept}";
            lblValueCardCred.Text = $"R$ {valueCardCred}";
            lblValueCardDeb.Text = $"R$ {valueCardDeb}";
        }

        private void LoadDataHistoryPayment()
        {
            var payment = new Payment().HistoryPayment(entryTimeCashFlow);
            foreach(DataRow dr in payment.Rows)
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

        string entryTimeCashFlow;

        private void GetDataCashFlow(int idCashFlow)
        {
            var cashFlow = new CashFlow().SearchID(idCashFlow);

            entryTimeCashFlow = cashFlow.Rows[0]["opening_time"].ToString();
            lblNumberBox.Text = cashFlow.Rows[0]["id"].ToString();
            lblDateEntry.Text = $"{cashFlow.Rows[0]["opening_date"]}, {entryTimeCashFlow}";
            lblEntryBox.Text = $"R$ { new IcomingCashFlow().GetValueEntryInitial(idCashFlow)}";
        }
    }
}
