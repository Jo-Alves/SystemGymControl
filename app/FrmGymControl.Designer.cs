namespace SystemGynControl
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
            this.btnRetoreMaximize = new System.Windows.Forms.Button();
            this.btnMimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnConjuctMenu = new System.Windows.Forms.Panel();
            this.pnMenuClass = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnFequency = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.pnMenuSave = new System.Windows.Forms.Panel();
            this.btnSubMenuUser = new System.Windows.Forms.Button();
            this.btnSubMenuPackage = new System.Windows.Forms.Button();
            this.btnSubMenuStudent = new System.Windows.Forms.Button();
            this.btnMenuCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcHome = new System.Windows.Forms.PictureBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.pnPage = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTitle.SuspendLayout();
            this.pnConjuctMenu.SuspendLayout();
            this.pnMenuClass.SuspendLayout();
            this.pnMenuSave.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).BeginInit();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.pnTitle.Controls.Add(this.btnRetoreMaximize);
            this.pnTitle.Controls.Add(this.btnMimized);
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(852, 40);
            this.pnTitle.TabIndex = 1;
            this.pnTitle.DoubleClick += new System.EventHandler(this.pnTitle_DoubleClick);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // btnRetoreMaximize
            // 
            this.btnRetoreMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetoreMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetoreMaximize.FlatAppearance.BorderSize = 0;
            this.btnRetoreMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoreMaximize.Image = global::SystemGynControl.Properties.Resources.icons8_maximize_window_32px_leave;
            this.btnRetoreMaximize.Location = new System.Drawing.Point(781, 4);
            this.btnRetoreMaximize.Name = "btnRetoreMaximize";
            this.btnRetoreMaximize.Size = new System.Drawing.Size(28, 30);
            this.btnRetoreMaximize.TabIndex = 3;
            this.btnRetoreMaximize.TabStop = false;
            this.btnRetoreMaximize.UseVisualStyleBackColor = true;
            this.btnRetoreMaximize.Click += new System.EventHandler(this.btnRetoreMaximize_Click);
            this.btnRetoreMaximize.MouseEnter += new System.EventHandler(this.btnRetoreMaximize_MouseEnter);
            this.btnRetoreMaximize.MouseLeave += new System.EventHandler(this.btnRetoreMaximize_MouseLeave);
            // 
            // btnMimized
            // 
            this.btnMimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMimized.FlatAppearance.BorderSize = 0;
            this.btnMimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMimized.Image = global::SystemGynControl.Properties.Resources.icons8_minimize_window_32px_leave;
            this.btnMimized.Location = new System.Drawing.Point(750, 4);
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Gym Control";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnConjuctMenu
            // 
            this.pnConjuctMenu.AutoScroll = true;
            this.pnConjuctMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnConjuctMenu.Controls.Add(this.pnMenuClass);
            this.pnConjuctMenu.Controls.Add(this.btnClass);
            this.pnConjuctMenu.Controls.Add(this.pnMenuSave);
            this.pnConjuctMenu.Controls.Add(this.btnMenuCadastro);
            this.pnConjuctMenu.Controls.Add(this.panel1);
            this.pnConjuctMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnConjuctMenu.Location = new System.Drawing.Point(0, 40);
            this.pnConjuctMenu.Name = "pnConjuctMenu";
            this.pnConjuctMenu.Size = new System.Drawing.Size(235, 438);
            this.pnConjuctMenu.TabIndex = 8;
            // 
            // pnMenuClass
            // 
            this.pnMenuClass.Controls.Add(this.btnHistory);
            this.pnMenuClass.Controls.Add(this.btnFequency);
            this.pnMenuClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuClass.Location = new System.Drawing.Point(0, 292);
            this.pnMenuClass.Name = "pnMenuClass";
            this.pnMenuClass.Size = new System.Drawing.Size(235, 103);
            this.pnMenuClass.TabIndex = 14;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnHistory.Image = global::SystemGynControl.Properties.Resources.icons8_activity_history_32px;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 51);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHistory.Size = new System.Drawing.Size(235, 47);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "Histórico";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnFequency
            // 
            this.btnFequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFequency.FlatAppearance.BorderSize = 0;
            this.btnFequency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFequency.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnFequency.Image = global::SystemGynControl.Properties.Resources.icons8_frequency_32px_1;
            this.btnFequency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFequency.Location = new System.Drawing.Point(0, 4);
            this.btnFequency.Name = "btnFequency";
            this.btnFequency.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFequency.Size = new System.Drawing.Size(235, 47);
            this.btnFequency.TabIndex = 4;
            this.btnFequency.TabStop = false;
            this.btnFequency.Text = "Fequência";
            this.btnFequency.UseVisualStyleBackColor = false;
            this.btnFequency.Click += new System.EventHandler(this.btnFequency_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnClass.Image = global::SystemGynControl.Properties.Resources.icons8_class_32px;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 245);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClass.Size = new System.Drawing.Size(235, 47);
            this.btnClass.TabIndex = 13;
            this.btnClass.TabStop = false;
            this.btnClass.Text = "Aula";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // pnMenuSave
            // 
            this.pnMenuSave.Controls.Add(this.btnSubMenuUser);
            this.pnMenuSave.Controls.Add(this.btnSubMenuPackage);
            this.pnMenuSave.Controls.Add(this.btnSubMenuStudent);
            this.pnMenuSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuSave.Location = new System.Drawing.Point(0, 97);
            this.pnMenuSave.Name = "pnMenuSave";
            this.pnMenuSave.Size = new System.Drawing.Size(235, 148);
            this.pnMenuSave.TabIndex = 12;
            // 
            // btnSubMenuUser
            // 
            this.btnSubMenuUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSubMenuUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuUser.FlatAppearance.BorderSize = 0;
            this.btnSubMenuUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSubMenuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuUser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnSubMenuUser.Image = global::SystemGynControl.Properties.Resources.icons8_checked_user;
            this.btnSubMenuUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuUser.Location = new System.Drawing.Point(0, 98);
            this.btnSubMenuUser.Name = "btnSubMenuUser";
            this.btnSubMenuUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuUser.Size = new System.Drawing.Size(235, 47);
            this.btnSubMenuUser.TabIndex = 3;
            this.btnSubMenuUser.TabStop = false;
            this.btnSubMenuUser.Text = "Usuário";
            this.btnSubMenuUser.UseVisualStyleBackColor = false;
            this.btnSubMenuUser.Click += new System.EventHandler(this.btnSubMenuUser_Click);
            // 
            // btnSubMenuPackage
            // 
            this.btnSubMenuPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSubMenuPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuPackage.FlatAppearance.BorderSize = 0;
            this.btnSubMenuPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSubMenuPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuPackage.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnSubMenuPackage.Image = global::SystemGynControl.Properties.Resources.icons8_handle_with_package;
            this.btnSubMenuPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuPackage.Location = new System.Drawing.Point(0, 51);
            this.btnSubMenuPackage.Name = "btnSubMenuPackage";
            this.btnSubMenuPackage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuPackage.Size = new System.Drawing.Size(235, 47);
            this.btnSubMenuPackage.TabIndex = 2;
            this.btnSubMenuPackage.TabStop = false;
            this.btnSubMenuPackage.Text = "Pacote";
            this.btnSubMenuPackage.UseVisualStyleBackColor = false;
            this.btnSubMenuPackage.Click += new System.EventHandler(this.btnSubMenuPackage_Click);
            // 
            // btnSubMenuStudent
            // 
            this.btnSubMenuStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSubMenuStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuStudent.FlatAppearance.BorderSize = 0;
            this.btnSubMenuStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSubMenuStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuStudent.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnSubMenuStudent.Image = global::SystemGynControl.Properties.Resources.icons8_client;
            this.btnSubMenuStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuStudent.Location = new System.Drawing.Point(0, 4);
            this.btnSubMenuStudent.Name = "btnSubMenuStudent";
            this.btnSubMenuStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuStudent.Size = new System.Drawing.Size(235, 47);
            this.btnSubMenuStudent.TabIndex = 1;
            this.btnSubMenuStudent.TabStop = false;
            this.btnSubMenuStudent.Text = "Aluno";
            this.btnSubMenuStudent.UseVisualStyleBackColor = false;
            this.btnSubMenuStudent.Click += new System.EventHandler(this.btnSubMenuStudent_Click);
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCadastro.FlatAppearance.BorderSize = 0;
            this.btnMenuCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMenuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastro.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuCadastro.Image = global::SystemGynControl.Properties.Resources.icons8_save_32px;
            this.btnMenuCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 50);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMenuCadastro.Size = new System.Drawing.Size(235, 47);
            this.btnMenuCadastro.TabIndex = 11;
            this.btnMenuCadastro.TabStop = false;
            this.btnMenuCadastro.Text = "Cadastro";
            this.btnMenuCadastro.UseVisualStyleBackColor = false;
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 50);
            this.panel1.TabIndex = 1;
            // 
            // pcHome
            // 
            this.pcHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcHome.Image = global::SystemGynControl.Properties.Resources.logo;
            this.pcHome.Location = new System.Drawing.Point(0, 0);
            this.pcHome.Name = "pcHome";
            this.pcHome.Size = new System.Drawing.Size(235, 50);
            this.pcHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHome.TabIndex = 0;
            this.pcHome.TabStop = false;
            this.pcHome.Click += new System.EventHandler(this.pcHome_Click);
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.pnStatus.Controls.Add(this.lblDateNow);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatus.Location = new System.Drawing.Point(0, 478);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(852, 40);
            this.pnStatus.TabIndex = 5;
            // 
            // lblDateNow
            // 
            this.lblDateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateNow.BackColor = System.Drawing.Color.Black;
            this.lblDateNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblDateNow.Location = new System.Drawing.Point(461, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateNow.Size = new System.Drawing.Size(379, 22);
            this.lblDateNow.TabIndex = 0;
            this.lblDateNow.Text = "segunda-feira, 20 de novembro de 2020, 16:32:44";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPage
            // 
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(235, 40);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(617, 438);
            this.pnPage.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button4.Image = global::SystemGynControl.Properties.Resources.icons8_handle_with_package;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-8, 51);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(235, 47);
            this.button4.TabIndex = 26;
            this.button4.TabStop = false;
            this.button4.Text = "Pacote";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button5.Image = global::SystemGynControl.Properties.Resources.icons8_client;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-8, 4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button5.Size = new System.Drawing.Size(235, 47);
            this.button5.TabIndex = 25;
            this.button5.TabStop = false;
            this.button5.Text = "Aluno";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 100);
            this.panel2.TabIndex = 27;
            // 
            // FrmGymControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 518);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.pnConjuctMenu);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGymControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGymControl";
            this.TopMost = true;
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnConjuctMenu.ResumeLayout(false);
            this.pnMenuClass.ResumeLayout(false);
            this.pnMenuSave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).EndInit();
            this.pnStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRetoreMaximize;
        private System.Windows.Forms.Button btnMimized;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnConjuctMenu;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.PictureBox pcHome;
        private System.Windows.Forms.Panel pnMenuClass;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnFequency;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Panel pnMenuSave;
        private System.Windows.Forms.Button btnSubMenuUser;
        private System.Windows.Forms.Button btnSubMenuPackage;
        private System.Windows.Forms.Button btnSubMenuStudent;
        private System.Windows.Forms.Button btnMenuCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
    }
}