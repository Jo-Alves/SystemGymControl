
namespace SystemGymControl
{
    partial class FrmConfigurationSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPrintDirecty = new System.Windows.Forms.RadioButton();
            this.rbVisualize = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNameFantasy = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSelectOptions = new System.Windows.Forms.ComboBox();
            this.cbGeneratesBackupAutomatically = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mkPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenDirectory);
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha a pasta onde serão armazenadas os arquivos de bakup e imagens do usuário " +
    "do sistema e alunos.";
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnOpenDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDirectory.FlatAppearance.BorderSize = 0;
            this.btnOpenDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnOpenDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnOpenDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDirectory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDirectory.ForeColor = System.Drawing.Color.White;
            this.btnOpenDirectory.Location = new System.Drawing.Point(592, 71);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(51, 36);
            this.btnOpenDirectory.TabIndex = 320;
            this.btnOpenDirectory.TabStop = false;
            this.btnOpenDirectory.Text = "...";
            this.btnOpenDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip.SetToolTip(this.btnOpenDirectory, "Abri diretório");
            this.btnOpenDirectory.UseVisualStyleBackColor = false;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(26, 73);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(560, 29);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório";
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbPrintDirecty);
            this.groupBox2.Controls.Add(this.rbVisualize);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 83);
            this.groupBox2.TabIndex = 321;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione a opção de como deve ser realizada a impressão";
            // 
            // rbPrintDirecty
            // 
            this.rbPrintDirecty.AutoSize = true;
            this.rbPrintDirecty.Checked = true;
            this.rbPrintDirecty.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrintDirecty.Location = new System.Drawing.Point(6, 38);
            this.rbPrintDirecty.Name = "rbPrintDirecty";
            this.rbPrintDirecty.Size = new System.Drawing.Size(144, 26);
            this.rbPrintDirecty.TabIndex = 1;
            this.rbPrintDirecty.TabStop = true;
            this.rbPrintDirecty.Text = "imprimir direto";
            this.rbPrintDirecty.UseVisualStyleBackColor = true;
            // 
            // rbVisualize
            // 
            this.rbVisualize.AutoSize = true;
            this.rbVisualize.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisualize.Location = new System.Drawing.Point(156, 38);
            this.rbVisualize.Name = "rbVisualize";
            this.rbVisualize.Size = new System.Drawing.Size(239, 26);
            this.rbVisualize.TabIndex = 0;
            this.rbVisualize.Text = "Visualizar antes de imprimir";
            this.rbVisualize.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.mkPhone);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.mkCNPJ);
            this.groupBox3.Controls.Add(this.lblCPF);
            this.groupBox3.Controls.Add(this.txtNameFantasy);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 180);
            this.groupBox3.TabIndex = 322;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro da academia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(16, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(595, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // mkCNPJ
            // 
            this.mkCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mkCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkCNPJ.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCNPJ.Location = new System.Drawing.Point(617, 55);
            this.mkCNPJ.Mask = "00,000,000/0000-00";
            this.mkCNPJ.Name = "mkCNPJ";
            this.mkCNPJ.Size = new System.Drawing.Size(169, 29);
            this.mkCNPJ.TabIndex = 1;
            this.mkCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(613, 29);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(50, 22);
            this.lblCPF.TabIndex = 69;
            this.lblCPF.Text = "CNPJ";
            // 
            // txtNameFantasy
            // 
            this.txtNameFantasy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameFantasy.BackColor = System.Drawing.Color.White;
            this.txtNameFantasy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameFantasy.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFantasy.ForeColor = System.Drawing.Color.Black;
            this.txtNameFantasy.Location = new System.Drawing.Point(16, 55);
            this.txtNameFantasy.Name = "txtNameFantasy";
            this.txtNameFantasy.Size = new System.Drawing.Size(595, 29);
            this.txtNameFantasy.TabIndex = 0;
            this.txtNameFantasy.WordWrap = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(12, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 22);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Nome Fantasia";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbxSelectOptions);
            this.groupBox4.Controls.Add(this.cbGeneratesBackupAutomatically);
            this.groupBox4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 100);
            this.groupBox4.TabIndex = 323;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(289, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 78;
            this.label3.Text = "Selecione a opção";
            // 
            // cbxSelectOptions
            // 
            this.cbxSelectOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectOptions.Enabled = false;
            this.cbxSelectOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSelectOptions.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectOptions.FormattingEnabled = true;
            this.cbxSelectOptions.Items.AddRange(new object[] {
            "Ao abrir o sistema",
            "Ao fechar o sistema",
            "Manualmente"});
            this.cbxSelectOptions.Location = new System.Drawing.Point(293, 54);
            this.cbxSelectOptions.Name = "cbxSelectOptions";
            this.cbxSelectOptions.Size = new System.Drawing.Size(275, 30);
            this.cbxSelectOptions.TabIndex = 1;
            this.cbxSelectOptions.TabStop = false;
            // 
            // cbGeneratesBackupAutomatically
            // 
            this.cbGeneratesBackupAutomatically.AutoSize = true;
            this.cbGeneratesBackupAutomatically.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneratesBackupAutomatically.Location = new System.Drawing.Point(16, 56);
            this.cbGeneratesBackupAutomatically.Name = "cbGeneratesBackupAutomatically";
            this.cbGeneratesBackupAutomatically.Size = new System.Drawing.Size(271, 26);
            this.cbGeneratesBackupAutomatically.TabIndex = 0;
            this.cbGeneratesBackupAutomatically.TabStop = false;
            this.cbGeneratesBackupAutomatically.Text = "Gerar backup automaticamente";
            this.cbGeneratesBackupAutomatically.UseVisualStyleBackColor = true;
            this.cbGeneratesBackupAutomatically.CheckedChanged += new System.EventHandler(this.cbGeneratesBackupAutomatically_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(144, 534);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 325;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 324;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mkPhone
            // 
            this.mkPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mkPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkPhone.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPhone.Location = new System.Drawing.Point(617, 128);
            this.mkPhone.Mask = "(00) 00000-0000";
            this.mkPhone.Name = "mkPhone";
            this.mkPhone.Size = new System.Drawing.Size(132, 29);
            this.mkPhone.TabIndex = 78;
            this.mkPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(613, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Celular|Telefone";
            // 
            // FrmConfigurationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 589);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfigurationSystem";
            this.Text = "FrmConfigurationSystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDirectory;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPrintDirecty;
        private System.Windows.Forms.RadioButton rbVisualize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mkCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNameFantasy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSelectOptions;
        private System.Windows.Forms.CheckBox cbGeneratesBackupAutomatically;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mkPhone;
        private System.Windows.Forms.Label label4;
    }
}