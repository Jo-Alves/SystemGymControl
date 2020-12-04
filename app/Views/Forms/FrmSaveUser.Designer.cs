namespace SystemGymControl
{
    partial class FrmSaveUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pcAvatar = new System.Windows.Forms.PictureBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.pcUpdateFormatPassword = new System.Windows.Forms.PictureBox();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUpdateFormatPassword)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(155, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 6;
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
            this.btnSave.Location = new System.Drawing.Point(23, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(23, 320);
            this.txtAnswer.MaxLength = 100;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(427, 33);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.WordWrap = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(19, 294);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(88, 22);
            this.lblCity.TabIndex = 44;
            this.lblCity.Text = "Resposta";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImage.FlatAppearance.BorderSize = 0;
            this.btnOpenImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnOpenImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.ForeColor = System.Drawing.Color.White;
            this.btnOpenImage.Location = new System.Drawing.Point(426, 165);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(140, 33);
            this.btnOpenImage.TabIndex = 7;
            this.btnOpenImage.TabStop = false;
            this.btnOpenImage.Text = "Abrir Imagem";
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenAvatar_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(19, 228);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(200, 22);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Questão de segurança";
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.Color.White;
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.ForeColor = System.Drawing.Color.Black;
            this.txtPassword1.Location = new System.Drawing.Point(23, 127);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(294, 33);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.WordWrap = false;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.Black;
            this.lblDistrict.Location = new System.Drawing.Point(19, 101);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(62, 22);
            this.lblDistrict.TabIndex = 34;
            this.lblDistrict.Text = "Senha";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(23, 50);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(378, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.WordWrap = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(19, 24);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 22);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Usuário";
            // 
            // pcAvatar
            // 
            this.pcAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcAvatar.Location = new System.Drawing.Point(430, 24);
            this.pcAvatar.Name = "pcAvatar";
            this.pcAvatar.Size = new System.Drawing.Size(130, 135);
            this.pcAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAvatar.TabIndex = 40;
            this.pcAvatar.TabStop = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.Color.White;
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword2.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.Black;
            this.txtPassword2.Location = new System.Drawing.Point(23, 192);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(294, 33);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Repita a senha";
            // 
            // cbQuestion
            // 
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Items.AddRange(new object[] {
            "Qual é o nome do seu primeiro animal de estimação?",
            "Quem é o(a) seu(sua) melhor amigo(a)?",
            "Qual é a sua matéria escolar preferida?",
            "Qual é a sua comida Predileta?"});
            this.cbQuestion.Location = new System.Drawing.Point(23, 254);
            this.cbQuestion.MaxLength = 100;
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(427, 30);
            this.cbQuestion.TabIndex = 3;
            // 
            // pcUpdateFormatPassword
            // 
            this.pcUpdateFormatPassword.Image = global::SystemGymControl.Properties.Resources.ver_32x32;
            this.pcUpdateFormatPassword.Location = new System.Drawing.Point(318, 127);
            this.pcUpdateFormatPassword.Name = "pcUpdateFormatPassword";
            this.pcUpdateFormatPassword.Size = new System.Drawing.Size(32, 32);
            this.pcUpdateFormatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcUpdateFormatPassword.TabIndex = 58;
            this.pcUpdateFormatPassword.TabStop = false;
            this.metroToolTip.SetToolTip(this.pcUpdateFormatPassword, "Ver");
            this.pcUpdateFormatPassword.Click += new System.EventHandler(this.pcUpdateFormatPassword_Click);
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FrmSaveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(601, 446);
            this.Controls.Add(this.pcUpdateFormatPassword);
            this.Controls.Add(this.cbQuestion);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pcAvatar);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSaveUser";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUpdateFormatPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pcAvatar;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.PictureBox pcUpdateFormatPassword;
        private MetroFramework.Components.MetroToolTip metroToolTip;
    }
}
