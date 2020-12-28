using Bussiness;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmRenewPlan : Form
    {
        Package package = new Package();
        Plan plan = new Plan();
        SituationsPlan situationsPlan = new SituationsPlan();

        FrmCardInPayment cardInPayment;
        FrmCashInPayment cashInPayment;

        CashPayment cashPayment = new CashPayment();
        CardPayment cardPayment = new CardPayment();

        int idPackage, duration, idPlan, idItemsPackage, studentId, idSituation, idCashPayment;

        DateTime datePlan;

        string period;

        public FrmRenewPlan()
        {
            InitializeComponent();
        }

        public FrmRenewPlan(int idPlan)
        {
            InitializeComponent();

            this.idPlan = idPlan;
            DataTable dataPlan = plan.SearchID(idPlan);

            idPackage = int.Parse(dataPlan.Rows[0]["idPackage"].ToString());
            idItemsPackage = int.Parse(dataPlan.Rows[0]["idItemsPackage"].ToString());
            idSituation = int.Parse(dataPlan.Rows[0]["idSituationPlan"].ToString());
            period = dataPlan.Rows[0]["period"].ToString();
            studentId = int.Parse(dataPlan.Rows[0]["idStudent"].ToString());
            txtCodigoStudent.Text = idPlan.ToString();
            txtNameStudent.Text = dataPlan.Rows[0]["name"].ToString();
            txtPackage.Text = dataPlan.Rows[0]["descriptionPackage"].ToString();
            duration = int.Parse(dataPlan.Rows[0]["duration"].ToString());
            txtValue.Text = dataPlan.Rows[0]["valueItemsPackage"].ToString();
            txtModality.Text = dataPlan.Rows[0]["descriptionModality"].ToString();
            foreach (DataRow dr in package.GetPackageAndItemsPackageId(idPackage).Rows)
            {
                cbFormOfPayment.Items.Add(dr["description"].ToString());
            }

            cbFormOfPayment.Text = dataPlan.Rows[0]["descriptionFormOfPayment"].ToString();
            if (cashPayment.SearchPlanID(idPlan).Rows.Count > 0)
                idCashPayment = int.Parse(cashPayment.SearchPlanID(idPlan).Rows[0]["id"].ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenewPlan_Click(object sender, EventArgs e)
        {
            if (cbFormOfPayment.Text.ToLower() == "dinheiro")
            {
                cashInPayment = new FrmCashInPayment(decimal.Parse(txtValue.Text));

                cashInPayment.ShowDialog();

                if (!cashInPayment.paymentCancel) return;
            }
            else
            {
                cardInPayment = new FrmCardInPayment(decimal.Parse(txtValue.Text), duration, cbFormOfPayment.Text);
                cardInPayment.ShowDialog();

                if (!cardInPayment.paymentCancel) return;
            }

            datePlan = DateTime.Now;

            RenewPlan();

            MessageBox.Show($"O Prazo foi renovado até o dia {plan._dateTerminalPlan}.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void RenewPlan()
        {
            try
            {
                plan._id = idPlan;
                plan._datePurchasePlan = datePlan.ToShortDateString();
                plan._timePurchasePlan = datePlan.ToLongTimeString();
                plan._dateTerminalPlan = GetTerminalPeriod(period);
                plan._itemsPackageID = idItemsPackage;
                plan._studentID = studentId;

                situationsPlan._id = idSituation;
                situationsPlan._situation = "Ativo";

                DataTable dataCardPayment = null;
                if (cbFormOfPayment.Text.ToLower() == "dinheiro")
                {
                    cashPayment._id = idCashPayment;
                    cashPayment._valueTotal = cashInPayment.valueDiscount;
                    cashPayment._valueDiscount = cashInPayment.discountMoney;
                    cashPayment._payday = datePlan.ToShortDateString();
                    cashPayment._paymentTime = datePlan.ToLongTimeString();
                }
                else
                    dataCardPayment = cardInPayment.dataPortion;

                plan.Save(new Modality(), situationsPlan, dataCardPayment, cashPayment, cbFormOfPayment.Text.ToLower(), period);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTerminalPeriod(string periodPackage)
        {
            string terminal = "";
            TimeSpan time;

            switch (periodPackage.ToLower())
            {
                case "diário":
                    terminal = datePlan.ToShortDateString();
                    break;
                case "mensal":
                    time = datePlan.AddMonths(1) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;
                case "bimestral":
                    time = datePlan.AddMonths(2) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;
                case "trimestral":
                    time = datePlan.AddMonths(3) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;
                case "semestral":
                    time = datePlan.AddMonths(6) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;
                case "anual":
                    time = datePlan.AddYears(1) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;
                case "quinzena":
                    time = datePlan.AddDays(15) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays).ToShortDateString();
                    break;
                case "quarentena":
                    time = datePlan.AddDays(40) - datePlan;
                    terminal = datePlan.AddDays(time.TotalDays).ToShortDateString();
                    break;
            }
            return terminal;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmRenewPlan_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbFormOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Text = package.GetValuePackageAndId(idPackage, cbFormOfPayment.Text).Rows[0]["value"].ToString();
            idItemsPackage = int.Parse(package.GetValuePackageAndId(idPackage, cbFormOfPayment.Text).Rows[0]["id"].ToString());
        }
    }
}
