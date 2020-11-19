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
            this.btnRetoreMaximize = new System.Windows.Forms.Button();
            this.btnMimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.pnConjuctMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSubMenuPackage = new System.Windows.Forms.Button();
            this.btnSubMenuStudent = new System.Windows.Forms.Button();
            this.btnMenuCadastro = new System.Windows.Forms.Button();
            this.pnPage = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnConjuctMenu.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(852, 63);
            this.panel2.TabIndex = 1;
            // 
            // btnRetoreMaximize
            // 
            this.btnRetoreMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetoreMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetoreMaximize.FlatAppearance.BorderSize = 0;
            this.btnRetoreMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoreMaximize.Image = global::SystemGynControl.Properties.Resources.icons8_restore_window_32px;
            this.btnRetoreMaximize.Location = new System.Drawing.Point(784, 17);
            this.btnRetoreMaximize.Name = "btnRetoreMaximize";
            this.btnRetoreMaximize.Size = new System.Drawing.Size(25, 30);
            this.btnRetoreMaximize.TabIndex = 3;
            this.btnRetoreMaximize.TabStop = false;
            this.btnRetoreMaximize.UseVisualStyleBackColor = true;
            this.btnRetoreMaximize.Click += new System.EventHandler(this.btnRetoreMaximize_Click);
            // 
            // btnMimized
            // 
            this.btnMimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMimized.FlatAppearance.BorderSize = 0;
            this.btnMimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMimized.Image")));
            this.btnMimized.Location = new System.Drawing.Point(753, 17);
            this.btnMimized.Name = "btnMimized";
            this.btnMimized.Size = new System.Drawing.Size(25, 30);
            this.btnMimized.TabIndex = 2;
            this.btnMimized.TabStop = false;
            this.btnMimized.UseVisualStyleBackColor = true;
            this.btnMimized.Click += new System.EventHandler(this.btnMimized_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(815, 16);
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
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Gym Control";
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatus.Location = new System.Drawing.Point(0, 478);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(852, 40);
            this.pnStatus.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Controls.Add(this.btnToggleMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 415);
            this.panel1.TabIndex = 7;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(3, 375);
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
            this.btnSobre.Location = new System.Drawing.Point(3, 341);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(42, 28);
            this.btnSobre.TabIndex = 1;
            this.btnSobre.TabStop = false;
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.Image")));
            this.btnToggleMenu.Location = new System.Drawing.Point(3, 7);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(42, 28);
            this.btnToggleMenu.TabIndex = 0;
            this.btnToggleMenu.TabStop = false;
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // pnConjuctMenu
            // 
            this.pnConjuctMenu.AutoScroll = true;
            this.pnConjuctMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnConjuctMenu.Controls.Add(this.panel5);
            this.pnConjuctMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnConjuctMenu.Location = new System.Drawing.Point(45, 63);
            this.pnConjuctMenu.Name = "pnConjuctMenu";
            this.pnConjuctMenu.Size = new System.Drawing.Size(237, 415);
            this.pnConjuctMenu.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnSubMenuPackage);
            this.panel5.Controls.Add(this.btnSubMenuStudent);
            this.panel5.Controls.Add(this.btnMenuCadastro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 190);
            this.panel5.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button3.Image = global::SystemGynControl.Properties.Resources.icons8_checked_user;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 141);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(237, 47);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "Usuário";
            this.button3.UseVisualStyleBackColor = false;
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
            this.btnSubMenuPackage.Location = new System.Drawing.Point(0, 94);
            this.btnSubMenuPackage.Name = "btnSubMenuPackage";
            this.btnSubMenuPackage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuPackage.Size = new System.Drawing.Size(237, 47);
            this.btnSubMenuPackage.TabIndex = 2;
            this.btnSubMenuPackage.TabStop = false;
            this.btnSubMenuPackage.Text = "Pacote";
            this.btnSubMenuPackage.UseVisualStyleBackColor = false;
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
            this.btnSubMenuStudent.Location = new System.Drawing.Point(0, 47);
            this.btnSubMenuStudent.Name = "btnSubMenuStudent";
            this.btnSubMenuStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubMenuStudent.Size = new System.Drawing.Size(237, 47);
            this.btnSubMenuStudent.TabIndex = 1;
            this.btnSubMenuStudent.TabStop = false;
            this.btnSubMenuStudent.Text = "Aluno";
            this.btnSubMenuStudent.UseVisualStyleBackColor = false;
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCadastro.FlatAppearance.BorderSize = 0;
            this.btnMenuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastro.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuCadastro.Image = global::SystemGynControl.Properties.Resources.icons8_save_32px;
            this.btnMenuCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMenuCadastro.Size = new System.Drawing.Size(237, 47);
            this.btnMenuCadastro.TabIndex = 0;
            this.btnMenuCadastro.TabStop = false;
            this.btnMenuCadastro.Text = "Cadastro";
            this.btnMenuCadastro.UseVisualStyleBackColor = false;
            // 
            // pnPage
            // 
            this.pnPage.Controls.Add(this.pcLogo);
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(282, 63);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(570, 415);
            this.pnPage.TabIndex = 9;
            // 
            // pcLogo
            // 
            this.pcLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
            this.pcLogo.Location = new System.Drawing.Point(156, 83);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(259, 249);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogo.TabIndex = 1;
            this.pcLogo.TabStop = false;
            // 
            // FrmGymControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 518);
            this.Controls.Add(this.pnPage);
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
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Panel pnConjuctMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSubMenuPackage;
        private System.Windows.Forms.Button btnSubMenuStudent;
        private System.Windows.Forms.Button btnMenuCadastro;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.PictureBox pcLogo;
    }
}