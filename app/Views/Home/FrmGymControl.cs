using Bussiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmGymControl : Form
    {
        Plan plan = new Plan();
        SituationsPlan situationPlan = new SituationsPlan();
        CashFlow cashFlow = new CashFlow();
        Payment payment = new Payment();
        int idCashFlow, id;
        string nameUser;

        public FrmGymControl()
        {
            InitializeComponent();
            InitialSettings(cashFlow.GetMaxCashFlowID());
        }

        public FrmGymControl(int id, string nameUser, string avatar, string name)
        {
            InitializeComponent();
            this.id = id;
            InitialSettings(id);
            loadFieldsPerfil(nameUser, avatar, name);
        }

        public FrmGymControl(string nameUser, string avatar, string name)
        {
            InitializeComponent();
            InitialSettings(cashFlow.GetMaxCashFlowID());
            loadFieldsPerfil(nameUser, avatar, name);
        }

        private void loadFieldsPerfil(string nameUser, string avatar, string name)
        {
            if (!string.IsNullOrEmpty(avatar))
            {
                pcPerfil.ImageLocation = avatar;
                pcPerfil.Load();
            }

            lblUser.Text = nameUser;
            this.nameUser = name;
        }

        private void InitialSettings(int id)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pcPerfil.DisplayRectangle);
            pcPerfil.Region = new Region(gp);

            ShowForm(new FrmHome());
            lblTitle.Text = "EXPLOSION ACADEMIA";
            _obj = this;
            this.ClientSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Top = 0;
            this.Left = 0;

            try
            {
                idCashFlow = id;
                CheckedPlanExpired();
                UpdateTimeInactivated();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTimeInactivated()
        {
            TimeSpan time;

            foreach (DataRow row in plan.SearchAll().Rows)
            {
                if (row["situation"].ToString().ToLower() == "inativo")
                {
                    int idSituation = int.Parse(row["idSituationPlan"].ToString());

                    var dateTerminal = Convert.ToDateTime(row["date_terminal_plan_last"].ToString());
                    var deactivationDate = Convert.ToDateTime(row["deactivation_date"].ToString());

                    /*
                        * subtrai a data de atual com a data da desativação do plano para
                        * pegar a diferença das datas e aumentar o prazo do término
                     */
                    time = DateTime.Now.Subtract(deactivationDate);

                    situationPlan._timeInactivated = time.Days.ToString();
                    plan._dateTerminalPlan = dateTerminal.AddDays(time.Days).ToShortDateString();
                    situationPlan.updateTimeInactivated(idSituation);
                    int idPlan = int.Parse(row["idPlan"].ToString());
                    plan.UpdateTerminalPlan(idPlan);

                    if (row["period"].ToString().ToLower() == "mensal")
                    {
                        payment.UpdatePaymentPlanMensal(idPlan, dateTerminal.AddDays(time.Days + 1).ToShortDateString());
                    }
                }
            }
        }

        private void CheckedPlanExpired()
        {
            foreach (DataRow dr in plan.GetDatePlanExpired().Rows)
            {
                situationPlan.updateSituationPlan(int.Parse(dr["id"].ToString()), "Expirado");
            }
        }

        private Form activeForm = null;

        private void ShowForm(Form form)
        {
            if (activeForm != null)
                activeForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnPage.Controls.Add(form);
            pnPage.Tag = form;
            form.BringToFront();
            form.Show();
        }

        static FrmGymControl _obj;

        public static FrmGymControl Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmGymControl();
                }
                return _obj;
            }
        }

        public string _nameUser
        {
            get { return nameUser; }
            set { nameUser = value; }
        }

        public Panel PnPageContainer
        {
            get { return pnPage; }
            set { pnPage = value; }
        }

        public Label _lblTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        public int _IdCashFlow
        {
            get { return idCashFlow; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateNow.Text = $"{DateTime.Now.ToLongDateString()}, {DateTime.Now.ToLongTimeString()}".ToUpper();
        }

        private void btnMimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnMimized_MouseEnter(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_enter;
        }

        private void btnMimized_MouseLeave(object sender, EventArgs e)
        {
            btnMimized.Image = Properties.Resources.icons8_minimize_window_32px_leave1;
        }

        private void btnMenuSave_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "EXPLOSION ACADEMIA";
            OpenForm.ShowForm(new FrmOptionsSave(), this);
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "EXPLOSION ACADEMIA";
            OpenForm.ShowForm(new FrmHome(), this);
        }

        private void btnMenuPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Plan().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPlans(), this);
                else
                {
                    if (new Package().SearchAll().Rows.Count > 0)
                        OpenForm.ShowForm(new FrmPurchasePlan(), this);
                    else
                        MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblTitle.Text = "EXPLOSION ACADEMIA --- Plano";
        }

        private void btnCashFlow_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new frmOptionClosingCashFlow(), this);
            lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo de Caixa";
        }

        private void btnMenuPayment_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "EXPLOSION ACADEMIA --- Pagamentos";
            OpenForm.ShowForm(new FrmPayments(), this);
        }
    }
}