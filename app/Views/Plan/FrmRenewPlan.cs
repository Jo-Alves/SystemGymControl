using Bussiness;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmRenewPlan : Form
    {
        Package package = new Package();
        Plan plan = new Plan();
        SituationsPlan situationsPlan = new SituationsPlan();
        IcomingCashFlow icomingCashFlow = new IcomingCashFlow();

        FrmCardInPayment cardInPayment;
        FrmCashInPayment cashInPayment;

        Payment payment = new Payment();

        int idPackage, duration, idPlan, idItemsPackage, studentId, idSituation, idCashPayment;

        DateTime datePlan = DateTime.Now;

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
            LoadFIelds(dataPlan);
        }

        private void LoadFIelds(DataTable dataPlan)
        {
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
            if (payment.SearchPlanID(idPlan).Rows.Count > 0)
                idCashPayment = int.Parse(payment.SearchPlanID(idPlan).Rows[0]["id"].ToString());

            lblDateTerminalPlan.Text = $"O prazo será prorrogado até {GetTerminalPeriod(period)}";
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

                if (!cashInPayment.paymentEffected) return;
            }
            else
            {
                cardInPayment = new FrmCardInPayment(decimal.Parse(txtValue.Text), duration, cbFormOfPayment.Text, period);
                cardInPayment.ShowDialog();

                if (!cardInPayment.paymentEffected) return;
            }

            RenewPlan();

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
                    payment._id = idCashPayment;
                    payment._valueTotal = cashInPayment.valueDiscount;
                    payment._valueDiscount = cashInPayment.discountMoney;
                    payment._payday = datePlan.ToShortDateString();
                    payment._paymentTime = datePlan.ToLongTimeString();
                    payment._formPayment = cbFormOfPayment.Text;
                    payment._numberPortion = 1;
                    payment._paymentOnAccount = "yes";
                    icomingCashFlow._valueMoney = payment._valueTotal;
                    icomingCashFlow._valueCard = 0.00M;
                }
                else
                {
                    dataCardPayment = cardInPayment.dataPortion;
                    icomingCashFlow._valueMoney = 0.00M;
                    icomingCashFlow._valueCard = decimal.Parse(txtValue.Text);
                }


                icomingCashFlow._entryDate = datePlan.ToShortDateString();
                icomingCashFlow._entryTime = datePlan.ToLongTimeString();
                icomingCashFlow._cashFlowID = FrmGymControl.Instance._IdCashFlow;
                icomingCashFlow._descriptionIcoming = $"Pagamento da renovação do plano: {txtPackage.Text} do(a) aluno(a) {txtNameStudent.Text}";

                plan.Save(new Modality(), situationsPlan, dataCardPayment, payment, cbFormOfPayment.Text, period, icomingCashFlow);

                if (bool.Parse(Settings.Default["optionPreviewIsDirecty"].ToString()))
                {
                    string path = Path.GetDirectoryName(Application.ExecutablePath);
                    string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Views\Report\Recibo de Pagamento.rdlc";
                    CreateReceipt.GenerateReceipt(payment.GetMaxIdPayment(), fullPath);
                }
                else
                    OpenForm.ShowForm(new FrmReportReceipt(payment.GetMaxIdPayment()), this);
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

        private void FrmRenewPlan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRenewPlan_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);

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
