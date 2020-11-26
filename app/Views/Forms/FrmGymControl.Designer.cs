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
            this.lblDateNow = new System.Windows.Forms.Label();
            this.btnRetoreMaximize = new System.Windows.Forms.Button();
            this.btnMimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnConjuctMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMenuQuestion = new System.Windows.Forms.Button();
            this.btnMenuReport = new System.Windows.Forms.Button();
            this.btnMenuClass = new System.Windows.Forms.Button();
            this.btnMenuSave = new System.Windows.Forms.Button();
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
            this.pnTitle.Controls.Add(this.lblDateNow);
            this.pnTitle.Controls.Add(this.btnRetoreMaximize);
            this.pnTitle.Controls.Add(this.btnMimized);
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(852, 40);
            this.pnTitle.TabIndex = 1;
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // lblDateNow
            // 
            this.lblDateNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblDateNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblDateNow.Location = new System.Drawing.Point(211, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateNow.Size = new System.Drawing.Size(431, 22);
            this.lblDateNow.TabIndex = 4;
            this.lblDateNow.Text = "segunda-feira, 20 de novembro de 2020, 16:32:44";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateNow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDateNow_MouseDown);
            // 
            // btnRetoreMaximize
            // 
            this.btnRetoreMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetoreMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetoreMaximize.FlatAppearance.BorderSize = 0;
            this.btnRetoreMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoreMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnRetoreMaximize.Image")));
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
            this.btnMimized.Image = global::SystemGymControl.Properties.Resources.icons8_minimize_window_32px_leave;
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
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leave;
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
            this.pnConjuctMenu.Size = new System.Drawing.Size(235, 570);
            this.pnConjuctMenu.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetting);
            this.panel3.Controls.Add(this.btnMenuQuestion);
            this.panel3.Controls.Add(this.btnMenuReport);
            this.panel3.Controls.Add(this.btnMenuClass);
            this.panel3.Controls.Add(this.btnMenuSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 335);
            this.panel3.TabIndex = 5;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnSetting.Image = global::SystemGymControl.Properties.Resources.icons8_settings_32px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.Location = new System.Drawing.Point(0, 220);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSetting.Size = new System.Drawing.Size(235, 55);
            this.btnSetting.TabIndex = 14;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Configurações";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnMenuQuestion
            // 
            this.btnMenuQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuQuestion.FlatAppearance.BorderSize = 0;
            this.btnMenuQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMenuQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuQuestion.Image = global::SystemGymControl.Properties.Resources.icons8_ask_question_32px;
            this.btnMenuQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuQuestion.Location = new System.Drawing.Point(0, 165);
            this.btnMenuQuestion.Name = "btnMenuQuestion";
            this.btnMenuQuestion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuQuestion.Size = new System.Drawing.Size(235, 55);
            this.btnMenuQuestion.TabIndex = 13;
            this.btnMenuQuestion.TabStop = false;
            this.btnMenuQuestion.Text = "Sobre";
            this.btnMenuQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuQuestion.UseVisualStyleBackColor = false;
            // 
            // btnMenuReport
            // 
            this.btnMenuReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuReport.FlatAppearance.BorderSize = 0;
            this.btnMenuReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMenuReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuReport.Image = global::SystemGymControl.Properties.Resources.icons8_report_file_32px;
            this.btnMenuReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuReport.Location = new System.Drawing.Point(0, 110);
            this.btnMenuReport.Name = "btnMenuReport";
            this.btnMenuReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuReport.Size = new System.Drawing.Size(235, 55);
            this.btnMenuReport.TabIndex = 12;
            this.btnMenuReport.TabStop = false;
            this.btnMenuReport.Text = "Relatório";
            this.btnMenuReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReport.UseVisualStyleBackColor = false;
            // 
            // btnMenuClass
            // 
            this.btnMenuClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuClass.FlatAppearance.BorderSize = 0;
            this.btnMenuClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMenuClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuClass.Image = global::SystemGymControl.Properties.Resources.icons8_class_32px;
            this.btnMenuClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuClass.Location = new System.Drawing.Point(0, 55);
            this.btnMenuClass.Name = "btnMenuClass";
            this.btnMenuClass.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuClass.Size = new System.Drawing.Size(235, 55);
            this.btnMenuClass.TabIndex = 11;
            this.btnMenuClass.TabStop = false;
            this.btnMenuClass.Text = "Aula";
            this.btnMenuClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClass.UseVisualStyleBackColor = false;
            // 
            // btnMenuSave
            // 
            this.btnMenuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenuSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSave.FlatAppearance.BorderSize = 0;
            this.btnMenuSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMenuSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnMenuSave.Image = global::SystemGymControl.Properties.Resources.icons8_save_32px;
            this.btnMenuSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuSave.Location = new System.Drawing.Point(0, 0);
            this.btnMenuSave.Name = "btnMenuSave";
            this.btnMenuSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuSave.Size = new System.Drawing.Size(235, 55);
            this.btnMenuSave.TabIndex = 10;
            this.btnMenuSave.TabStop = false;
            this.btnMenuSave.Text = "Cadastro";
            this.btnMenuSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSave.UseVisualStyleBackColor = false;
            this.btnMenuSave.Click += new System.EventHandler(this.btnMenuSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pcPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 159);
            this.panel1.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(67, 112);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 22);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Silmara";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcPerfil
            // 
            this.pcPerfil.Image = global::SystemGymControl.Properties.Resources.icons8_person_female_50px;
            this.pcPerfil.Location = new System.Drawing.Point(67, 10);
            this.pcPerfil.Name = "pcPerfil";
            this.pcPerfil.Size = new System.Drawing.Size(100, 100);
            this.pcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPerfil.TabIndex = 3;
            this.pcPerfil.TabStop = false;
            // 
            // pnPage
            // 
            this.pnPage.AutoScroll = true;
            this.pnPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(235, 40);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(617, 570);
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
            this.ClientSize = new System.Drawing.Size(852, 610);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.pnConjuctMenu);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGymControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGymControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTitle.ResumeLayout(false);
            this.pnConjuctMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRetoreMaximize;
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
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMenuQuestion;
        private System.Windows.Forms.Button btnMenuReport;
        private System.Windows.Forms.Button btnMenuClass;
        private System.Windows.Forms.Button btnMenuSave;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Label lblDateNow;
    }
}