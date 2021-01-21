namespace SystemGymControl
{
    partial class FrmGymControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGymControl));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnNotification = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.btnMimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnConjuctMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMenuQuestion = new System.Windows.Forms.Button();
            this.btnCashFlow = new System.Windows.Forms.Button();
            this.btnMenuSales = new System.Windows.Forms.Button();
            this.btnMenuPayment = new System.Windows.Forms.Button();
            this.btnMenuPlan = new System.Windows.Forms.Button();
            this.btnMenuSave = new System.Windows.Forms.Button();
            this.btnMenuHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pcPerfil = new System.Windows.Forms.PictureBox();
            this.pnPage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            this.pnConjuctMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnTitle.Controls.Add(this.btnNotification);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Controls.Add(this.lblDateNow);
            this.pnTitle.Controls.Add(this.btnMimized);
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(852, 40);
            this.pnTitle.TabIndex = 1;
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Image = global::SystemGymControl.Properties.Resources.icons8_notification_25px;
            this.btnNotification.Location = new System.Drawing.Point(742, 7);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(25, 26);
            this.btnNotification.TabIndex = 6;
            this.btnNotification.TabStop = false;
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Visible = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 22);
            this.lblTitle.TabIndex = 5;
            // 
            // lblDateNow
            // 
            this.lblDateNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblDateNow.ForeColor = System.Drawing.Color.White;
            this.lblDateNow.Location = new System.Drawing.Point(211, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateNow.Size = new System.Drawing.Size(431, 22);
            this.lblDateNow.TabIndex = 4;
            this.lblDateNow.Text = "segunda-feira, 20 de novembro de 2020, 16:32:44";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMimized
            // 
            this.btnMimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMimized.FlatAppearance.BorderSize = 0;
            this.btnMimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMimized.Image = global::SystemGymControl.Properties.Resources.icons8_minimize_window_32px_leave1;
            this.btnMimized.Location = new System.Drawing.Point(784, 3);
            this.btnMimized.Name = "btnMimized";
            this.btnMimized.Size = new System.Drawing.Size(25, 30);
            this.btnMimized.TabIndex = 2;
            this.btnMimized.TabStop = false;
            this.btnMimized.UseVisualStyleBackColor = true;
            this.btnMimized.Click += new System.EventHandler(this.btnMimized_Click);
            this.btnMimized.MouseEnter += new System.EventHandler(this.btnMimized_MouseEnter);
            this.btnMimized.MouseLeave += new System.EventHandler(this.btnMimized_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(815, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnConjuctMenu
            // 
            this.pnConjuctMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnConjuctMenu.Controls.Add(this.panel3);
            this.pnConjuctMenu.Controls.Add(this.panel1);
            this.pnConjuctMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnConjuctMenu.Location = new System.Drawing.Point(0, 40);
            this.pnConjuctMenu.Name = "pnConjuctMenu";
            this.pnConjuctMenu.Size = new System.Drawing.Size(205, 709);
            this.pnConjuctMenu.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetting);
            this.panel3.Controls.Add(this.btnMenuQuestion);
            this.panel3.Controls.Add(this.btnCashFlow);
            this.panel3.Controls.Add(this.btnMenuSales);
            this.panel3.Controls.Add(this.btnMenuPayment);
            this.panel3.Controls.Add(this.btnMenuPlan);
            this.panel3.Controls.Add(this.btnMenuSave);
            this.panel3.Controls.Add(this.btnMenuHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 504);
            this.panel3.TabIndex = 5;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::SystemGymControl.Properties.Resources.icons8_settings_32px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.Location = new System.Drawing.Point(0, 343);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSetting.Size = new System.Drawing.Size(205, 49);
            this.btnSetting.TabIndex = 42;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Configurações";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMenuQuestion
            // 
            this.btnMenuQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuQuestion.FlatAppearance.BorderSize = 0;
            this.btnMenuQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenuQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenuQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuQuestion.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQuestion.ForeColor = System.Drawing.Color.White;
            this.btnMenuQuestion.Image = global::SystemGymControl.Properties.Resources.icons8_about_32px;
            this.btnMenuQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuQuestion.Location = new System.Drawing.Point(0, 294);
            this.btnMenuQuestion.Name = "btnMenuQuestion";
            this.btnMenuQuestion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuQuestion.Size = new System.Drawing.Size(205, 49);
            this.btnMenuQuestion.TabIndex = 41;
            this.btnMenuQuestion.TabStop = false;
            this.btnMenuQuestion.Text = "Sobre";
            this.btnMenuQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuQuestion.UseVisualStyleBackColor = false;
            this.btnMenuQuestion.Click += new System.EventHandler(this.btnMenuQuestion_Click);
            // 
            // btnCashFlow
            // 
            this.btnCashFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCashFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashFlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashFlow.FlatAppearance.BorderSize = 0;
            this.btnCashFlow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCashFlow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCashFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashFlow.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashFlow.ForeColor = System.Drawing.Color.White;
            this.btnCashFlow.Image = global::SystemGymControl.Properties.Resources.icons8_flow_32px_1;
            this.btnCashFlow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCashFlow.Location = new System.Drawing.Point(0, 245);
            this.btnCashFlow.Name = "btnCashFlow";
            this.btnCashFlow.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCashFlow.Size = new System.Drawing.Size(205, 49);
            this.btnCashFlow.TabIndex = 40;
            this.btnCashFlow.TabStop = false;
            this.btnCashFlow.Text = "Fluxo de Caixa";
            this.btnCashFlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashFlow.UseVisualStyleBackColor = false;
            this.btnCashFlow.Click += new System.EventHandler(this.btnCashFlow_Click);
            // 
            // btnMenuSales
            // 
            this.btnMenuSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSales.FlatAppearance.BorderSize = 0;
            this.btnMenuSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenuSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenuSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSales.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSales.ForeColor = System.Drawing.Color.White;
            this.btnMenuSales.Image = global::SystemGymControl.Properties.Resources.icons8_sale_price_tag_32px_1;
            this.btnMenuSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuSales.Location = new System.Drawing.Point(0, 196);
            this.btnMenuSales.Name = "btnMenuSales";
            this.btnMenuSales.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuSales.Size = new System.Drawing.Size(205, 49);
            this.btnMenuSales.TabIndex = 35;
            this.btnMenuSales.TabStop = false;
            this.btnMenuSales.Text = "Vendas";
            this.btnMenuSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSales.UseVisualStyleBackColor = false;
            this.btnMenuSales.Click += new System.EventHandler(this.btnMenuSales_Click);
            // 
            // btnMenuPayment
            // 
            this.btnMenuPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPayment.FlatAppearance.BorderSize = 0;
            this.btnMenuPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenuPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenuPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPayment.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPayment.ForeColor = System.Drawing.Color.White;
            this.btnMenuPayment.Image = global::SystemGymControl.Properties.Resources.icons8_card_payment_32px;
            this.btnMenuPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPayment.Location = new System.Drawing.Point(0, 147);
            this.btnMenuPayment.Name = "btnMenuPayment";
            this.btnMenuPayment.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuPayment.Size = new System.Drawing.Size(205, 49);
            this.btnMenuPayment.TabIndex = 34;
            this.btnMenuPayment.TabStop = false;
            this.btnMenuPayment.Text = "Pagamentos";
            this.btnMenuPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPayment.UseVisualStyleBackColor = false;
            this.btnMenuPayment.Click += new System.EventHandler(this.btnMenuPayment_Click);
            // 
            // btnMenuPlan
            // 
            this.btnMenuPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPlan.FlatAppearance.BorderSize = 0;
            this.btnMenuPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenuPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenuPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPlan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPlan.ForeColor = System.Drawing.Color.White;
            this.btnMenuPlan.Image = global::SystemGymControl.Properties.Resources.icons8_floor_plan_32px_1;
            this.btnMenuPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPlan.Location = new System.Drawing.Point(0, 98);
            this.btnMenuPlan.Name = "btnMenuPlan";
            this.btnMenuPlan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuPlan.Size = new System.Drawing.Size(205, 49);
            this.btnMenuPlan.TabIndex = 25;
            this.btnMenuPlan.TabStop = false;
            this.btnMenuPlan.Text = "Plano";
            this.btnMenuPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPlan.UseVisualStyleBackColor = false;
            this.btnMenuPlan.Click += new System.EventHandler(this.btnMenuPlan_Click);
            // 
            // btnMenuSave
            // 
            this.btnMenuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSave.FlatAppearance.BorderSize = 0;
            this.btnMenuSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenuSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenuSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSave.ForeColor = System.Drawing.Color.White;
            this.btnMenuSave.Image = global::SystemGymControl.Properties.Resources.icons8_save_32px;
            this.btnMenuSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuSave.Location = new System.Drawing.Point(0, 49);
            this.btnMenuSave.Name = "btnMenuSave";
            this.btnMenuSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuSave.Size = new System.Drawing.Size(205, 49);
            this.btnMenuSave.TabIndex = 20;
            this.btnMenuSave.TabStop = false;
            this.btnMenuSave.Text = "Cadastro";
            this.btnMenuSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSave.UseVisualStyleBackColor = false;
            this.btnMenuSave.Click += new System.EventHandler(this.btnMenuSave_Click);
            // 
            // btnMenuHome
            // 
            this.btnMenuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuHome.FlatAppearance.BorderSize = 0;
            this.btnMenuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHome.ForeColor = System.Drawing.Color.White;
            this.btnMenuHome.Image = global::SystemGymControl.Properties.Resources.icons8_home_page_32px;
            this.btnMenuHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuHome.Location = new System.Drawing.Point(0, 0);
            this.btnMenuHome.Name = "btnMenuHome";
            this.btnMenuHome.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuHome.Size = new System.Drawing.Size(205, 49);
            this.btnMenuHome.TabIndex = 15;
            this.btnMenuHome.TabStop = false;
            this.btnMenuHome.Text = "Início";
            this.btnMenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.UseVisualStyleBackColor = false;
            this.btnMenuHome.Click += new System.EventHandler(this.btnMenuHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pcPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 187);
            this.panel1.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(54, 153);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 22);
            this.lblUser.TabIndex = 4;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcPerfil
            // 
            this.pcPerfil.Image = global::SystemGymControl.Properties.Resources.icons8_person_female_50px;
            this.pcPerfil.Location = new System.Drawing.Point(37, 18);
            this.pcPerfil.Name = "pcPerfil";
            this.pcPerfil.Size = new System.Drawing.Size(130, 130);
            this.pcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPerfil.TabIndex = 3;
            this.pcPerfil.TabStop = false;
            // 
            // pnPage
            // 
            this.pnPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(205, 40);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(647, 709);
            this.pnPage.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 100);
            this.panel2.TabIndex = 27;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // FrmGymControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 749);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.pnConjuctMenu);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGymControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXPLOSION ACADEMIA";
            this.Load += new System.EventHandler(this.FrmGymControl_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnConjuctMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMimized;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnConjuctMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pcPerfil;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Button btnMenuHome;
        private System.Windows.Forms.Button btnMenuSave;
        private System.Windows.Forms.Button btnMenuPlan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMenuSales;
        private System.Windows.Forms.Button btnMenuPayment;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMenuQuestion;
        private System.Windows.Forms.Button btnCashFlow;
        private System.Windows.Forms.Button btnNotification;
    }
}