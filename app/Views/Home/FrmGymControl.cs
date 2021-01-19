using Bussiness;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SystemGymControl
{
    public partial class FrmGymControl : Form
    {
        Plan plan = new Plan();
        SituationsPlan situationPlan = new SituationsPlan();
        CashFlow cashFlow = new CashFlow();
        Payment payment = new Payment();
        Student student = new Student();

        int idCashFlow, id;
        string nameUser, name;
        bool dateBoxIsPrevious = false, existUsers = true;

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
            CheckedCashFlowItOpenig();
        }

        public FrmGymControl(string nameUser, string avatar, string name)
        {
            InitializeComponent();
            InitialSettings(cashFlow.GetMaxCashFlowID());
            loadFieldsPerfil(nameUser, avatar, name);
            CheckedCashFlowItOpenig();
        }

        public FrmGymControl(string messageIfExistUser)
        {
            InitializeComponent();
            InitialSettings(0);
            MessageBox.Show("Crie o usuário para o sistema.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            existUsers = false;
            OpenForm.ShowForm(new FrmSaveUser(0, messageIfExistUser), this);
        }

        private void CheckedCashFlowItOpenig()
        {
            cashFlow.GetDateOpeningCashFlow();
            if (!string.IsNullOrEmpty(cashFlow._openingDate))
            {
                if (!DateTime.Now.ToShortDateString().Equals(cashFlow._openingDate))
                {
                    MessageBox.Show("Verificamos que o caixa não foi fechado. Fecha o caixa para a liberação as operações do sistema.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateBoxIsPrevious = true;
                    OpenForm.ShowForm(new FrmClosingCashFlow(), this);
                }
            }
        }

        private void loadFieldsPerfil(string nameUser, string avatar, string name)
        {
            if (!string.IsNullOrEmpty(avatar))
            {
                pcPerfil.ImageLocation = avatar;
                pcPerfil.Load();
            }

            lblUser.Text = nameUser;
            this.nameUser = nameUser;
            this.name = name;
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

            if (id == 0) return;

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

        public bool _dateBoxIsPrevious
        {
            get { return dateBoxIsPrevious; }
            set { dateBoxIsPrevious = value; }
        }

        public bool _existUsers
        {
            get { return existUsers; }
            set { existUsers = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public Panel PnPageContainer
        {
            get { return pnPage; }
            set { pnPage = value; }
        }

        public PictureBox _pcPerfil
        {
            get { return pcPerfil; }
            set { pcPerfil = value; }
        }

        public Label _lblTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        public int _IdCashFlow
        {
            get { return idCashFlow; }
            set { idCashFlow = value; }
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
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblTitle.Text = "EXPLOSION ACADEMIA";
            OpenForm.ShowForm(new FrmOptionsSave(), this);
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblTitle.Text = "EXPLOSION ACADEMIA";
            OpenForm.ShowForm(new FrmHome(), this);
        }

        private void btnMenuPlan_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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

        private void btnMenuSales_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnMenuQuestion_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void FrmGymControl_Load(object sender, EventArgs e)
        {
            try
            {
                UpdatePaymentCardIfDueDateEqualDateNow();
                NotificationSystem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotificationSystem()
        {
            DataTable dataStudents = student.GetBirthStudents(DateTime.Now.ToShortDateString().Substring(0, 5)), dataPayments = payment.GetDataPaymentDueDateLate();

            if (dataStudents.Rows.Count == 0 && dataPayments.Rows.Count == 0) return;

            btnNotification.Visible = true;

            if (new Notification().GetNotification().Rows.Count > 0) return;
                
            NotifyStudent(dataStudents);            
            NotifyPayment(dataPayments);

            SoundPlayer sound = new SoundPlayer(Properties.Resources.hangouts);
            sound.Play();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.icons8_notification_25px;
            popup.TitleText = "Notificação do sistema...";
            popup.ContentText = "Verifique na caixa de mensagem a notificação do dia.";
            popup.Popup();

        }

        private void NotifyPayment(DataTable dataPayments)
        {
            TimeSpan time;

            foreach (DataRow dr in dataPayments.Rows)
            {
                DateTime dueDate = Convert.ToDateTime(dr["duedate"].ToString());
                time = DateTime.Now.Subtract(dueDate);
                new Notification()
                {
                    _dateNotification = DateTime.Now.ToShortDateString(),
                    _message = $"Constamos que o pagamento do(a) aluno(a) {dr["name"]} está à {time.Days} dias de atraso.",
                    _situation = "Não lida"
                }.GerateMessage();
            }

        }

        private void NotifyStudent(DataTable dataStudents)
        {
            foreach (DataRow dr in dataStudents.Rows)
            {
                new Notification()
                {
                    _dateNotification = DateTime.Now.ToShortDateString(),
                    _message = $"Constamos que o(a) aluno(a) {dr["name"]} está fazendo aniversário na data de hoje.",
                    _situation = "Não lida"
                }.GerateMessage();
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmNotification(), this);
        }

        private void UpdatePaymentCardIfDueDateEqualDateNow()
        {
            try
            {
                DateTime dateNow = DateTime.Now;
                foreach (DataRow dr in payment.SearchPaymentDateNow().Rows)
                {
                    IcomingCashFlow icomingCashFlow = new IcomingCashFlow()
                    {
                        _cashFlowID = idCashFlow,
                        _descriptionIcoming = $"Valor adicionado na conta do pagamento do {dr["form_payment"]}",
                        _entryDate = dateNow.ToShortDateString(),
                        _entryTime = dateNow.ToLongTimeString(),
                        _valueCard = decimal.Parse(dr["value_total"].ToString()),
                        _valueMoney = 0.00M
                    };

                    payment.UpdatePaymentOnAccount(int.Parse(dr["id"].ToString()), icomingCashFlow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCashFlow_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            OpenForm.ShowForm(new frmOptionClosingCashFlow(), this);
            lblTitle.Text = "EXPLOSION ACADEMIA --- Fluxo de Caixa";
        }

        private void btnMenuPayment_Click(object sender, EventArgs e)
        {
            if (dateBoxIsPrevious)
            {
                MessageBox.Show("Faça o fechamento do caixa para liberar essa operação!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!existUsers)
            {
                MessageBox.Show("Crie o usuário do sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblTitle.Text = "EXPLOSION ACADEMIA --- Pagamentos";
            OpenForm.ShowForm(new FrmPayments(), this);
        }
    }
}