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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnConjuctMenu = new System.Windows.Forms.Panel();
            this.pnMenuClass = new System.Windows.Forms.Panel();
            this.pnMenuSave = new System.Windows.Forms.Panel();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnPage = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnFequency = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnSubMenuUser = new System.Windows.Forms.Button();
            this.btnSubMenuPackage = new System.Windows.Forms.Button();
            this.btnSubMenuStudent = new System.Windows.Forms.Button();
            this.btnMenuCadastro = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnRetoreMaximize = new System.Windows.Forms.Button();
            this.btnMimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnConjuctMenu.SuspendLayout();
            this.pnMenuClass.SuspendLayout();
            this.pnMenuSave.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.pnPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnRetoreMaximize);
            this.panel2.Controls.Add(this.btnMimized);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 40);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 6);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 438);
            this.panel1.TabIndex = 7;
            // 
            // pnConjuctMenu
            // 
            this.pnConjuctMenu.AutoScroll = true;
            this.pnConjuctMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnConjuctMenu.Controls.Add(this.pnMenuClass);
            this.pnConjuctMenu.Controls.Add(this.btnClass);
            this.pnConjuctMenu.Controls.Add(this.pnMenuSave);
            this.pnConjuctMenu.Controls.Add(this.btnMenuCadastro);
            this.pnConjuctMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnConjuctMenu.Location = new System.Drawing.Point(45, 40);
            this.pnConjuctMenu.Name = "pnConjuctMenu";
            this.pnConjuctMenu.Size = new System.Drawing.Size(189, 438);
            this.pnConjuctMenu.TabIndex = 8;
            // 
            // pnMenuClass
            // 
            this.pnMenuClass.Controls.Add(this.btnHistory);
            this.pnMenuClass.Controls.Add(this.btnFequency);
            this.pnMenuClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuClass.Location = new System.Drawing.Point(0, 242);
            this.pnMenuClass.Name = "pnMenuClass";
            this.pnMenuClass.Size = new System.Drawing.Size(189, 143);
            this.pnMenuClass.TabIndex = 6;
            // 
            // pnMenuSave
            // 
            this.pnMenuSave.Controls.Add(this.btnSubMenuUser);
            this.pnMenuSave.Controls.Add(this.btnSubMenuPackage);
            this.pnMenuSave.Controls.Add(this.btnSubMenuStudent);
            this.pnMenuSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuSave.Location = new System.Drawing.Point(0, 47);
            this.pnMenuSave.Name = "pnMenuSave";
            this.pnMenuSave.Size = new System.Drawing.Size(189, 148);
            this.pnMenuSave.TabIndex = 3;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Black;
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
            this.lblDateNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblDateNow.Location = new System.Drawing.Point(461, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateNow.Size = new System.Drawing.Size(379, 22);
            this.lblDateNow.TabIndex = 0;
            this.lblDateNow.Text = "segunda-feira, 20 de novembro de 2020, 16:32:44";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(807, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 438);
            this.panel3.TabIndex = 10;
            // 
            // pnPage
            // 
            this.pnPage.Controls.Add(this.pcLogo);
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(234, 40);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(573, 438);
            this.pnPage.TabIndex = 11;
            // 
            // pcLogo
            // 
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(573, 438);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogo.TabIndex = 1;
            this.pcLogo.TabStop = false;
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
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.Location = new System.Drawing.Point(0, 51);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHistory.Size = new System.Drawing.Size(189, 47);
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
            this.btnFequency.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFequency.Location = new System.Drawing.Point(0, 4);
            this.btnFequency.Name = "btnFequency";
            this.btnFequency.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFequency.Size = new System.Drawing.Size(189, 47);
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
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClass.Location = new System.Drawing.Point(0, 195);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClass.Size = new System.Drawing.Size(189, 47);
            this.btnClass.TabIndex = 5;
            this.btnClass.TabStop = false;
            this.btnClass.Text = "Aula";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
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
            this.btnSubMenuUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenuUser.Location = new System.Drawing.Point(0, 98);
            this.btnSubMenuUser.Name = "btnSubMenuUser";
            this.btnSubMenuUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuUser.Size = new System.Drawing.Size(189, 47);
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
            this.btnSubMenuPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenuPackage.Location = new System.Drawing.Point(0, 51);
            this.btnSubMenuPackage.Name = "btnSubMenuPackage";
            this.btnSubMenuPackage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuPackage.Size = new System.Drawing.Size(189, 47);
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
            this.btnSubMenuStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenuStudent.Location = new System.Drawing.Point(0, 4);
            this.btnSubMenuStudent.Name = "btnSubMenuStudent";
            this.btnSubMenuStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuStudent.Size = new System.Drawing.Size(189, 47);
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
            this.btnMenuCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMenuCadastro.Size = new System.Drawing.Size(189, 47);
            this.btnMenuCadastro.TabIndex = 2;
            this.btnMenuCadastro.TabStop = false;
            this.btnMenuCadastro.Text = "Cadastro";
            this.btnMenuCadastro.UseVisualStyleBackColor = false;
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::SystemGynControl.Properties.Resources.icons8_home_page;
            this.btnHome.Location = new System.Drawing.Point(3, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(42, 28);
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(3, 398);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(42, 28);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.TabStop = false;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.Location = new System.Drawing.Point(3, 364);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(42, 28);
            this.btnSobre.TabIndex = 1;
            this.btnSobre.TabStop = false;
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnRetoreMaximize
            // 
            this.btnRetoreMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetoreMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetoreMaximize.FlatAppearance.BorderSize = 0;
            this.btnRetoreMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoreMaximize.Image = global::SystemGynControl.Properties.Resources.icons8_maximize_window_32px_leave;
            this.btnRetoreMaximize.Location = new System.Drawing.Point(782, 6);
            this.btnRetoreMaximize.Name = "btnRetoreMaximize";
            this.btnRetoreMaximize.Size = new System.Drawing.Size(27, 30);
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
            this.btnMimized.Location = new System.Drawing.Point(751, 6);
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
            this.btnClose.Location = new System.Drawing.Point(815, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // FrmGymControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 518);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnConjuctMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGymControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGymControl";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnConjuctMenu.ResumeLayout(false);
            this.pnMenuClass.ResumeLayout(false);
            this.pnMenuSave.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRetoreMaximize;
        private System.Windows.Forms.Button btnMimized;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Panel pnConjuctMenu;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Panel pnMenuSave;
        private System.Windows.Forms.Button btnSubMenuUser;
        private System.Windows.Forms.Button btnSubMenuPackage;
        private System.Windows.Forms.Button btnSubMenuStudent;
        private System.Windows.Forms.Button btnMenuCadastro;
        private System.Windows.Forms.Panel pnMenuClass;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnFequency;
    }
}