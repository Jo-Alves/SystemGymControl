namespace SystemGymControl
{
    partial class FrmReportTipPassword
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
            this.txtAnswerSecurity = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtQuestionSecurity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnswerSecurity
            // 
            this.txtAnswerSecurity.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtAnswerSecurity.Location = new System.Drawing.Point(25, 142);
            this.txtAnswerSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswerSecurity.Name = "txtAnswerSecurity";
            this.txtAnswerSecurity.Size = new System.Drawing.Size(414, 33);
            this.txtAnswerSecurity.TabIndex = 6;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Open Sans", 14F);
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(19, 113);
            this.Usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(299, 26);
            this.Usuario.TabIndex = 5;
            this.Usuario.Text = "Digite a  resposta de segurança:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(308, 182);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 43);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "OK";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_4;
            this.btnClose.Location = new System.Drawing.Point(422, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 30);
            this.btnClose.TabIndex = 28;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQuestionSecurity
            // 
            this.txtQuestionSecurity.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtQuestionSecurity.Location = new System.Drawing.Point(24, 76);
            this.txtQuestionSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestionSecurity.Name = "txtQuestionSecurity";
            this.txtQuestionSecurity.ReadOnly = true;
            this.txtQuestionSecurity.Size = new System.Drawing.Size(415, 33);
            this.txtQuestionSecurity.TabIndex = 30;
            this.txtQuestionSecurity.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sua pergunta de segurança:";
            // 
            // FrmReportTipPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.txtQuestionSecurity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAnswerSecurity);
            this.Controls.Add(this.Usuario);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportTipPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informar Dica de Senha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReportTipPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswerSecurity;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtQuestionSecurity;
        private System.Windows.Forms.Label label1;
    }
}