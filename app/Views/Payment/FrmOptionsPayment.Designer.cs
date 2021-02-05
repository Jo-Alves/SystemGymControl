namespace SystemGymControl
{
    partial class FrmOptionsPayment
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
            this.pnUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pcUser = new System.Windows.Forms.PictureBox();
            this.pnPackage = new System.Windows.Forms.Panel();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pcPackage = new System.Windows.Forms.PictureBox();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).BeginInit();
            this.pnPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnUser
            // 
            this.pnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnUser.Controls.Add(this.lblUser);
            this.pnUser.Controls.Add(this.btnHistory);
            this.pnUser.Controls.Add(this.pcUser);
            this.pnUser.Location = new System.Drawing.Point(500, 163);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(272, 245);
            this.pnUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(38, 100);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(193, 22);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Histórico de pagamento";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(9, 159);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(252, 42);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Ir para a tela";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // pcUser
            // 
            this.pcUser.Image = global::SystemGymControl.Properties.Resources.Actions_view_history_icon;
            this.pcUser.Location = new System.Drawing.Point(102, 28);
            this.pcUser.Name = "pcUser";
            this.pcUser.Size = new System.Drawing.Size(64, 64);
            this.pcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcUser.TabIndex = 1;
            this.pcUser.TabStop = false;
            // 
            // pnPackage
            // 
            this.pnPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPackage.Controls.Add(this.lblPackage);
            this.pnPackage.Controls.Add(this.btnPayment);
            this.pnPackage.Controls.Add(this.pcPackage);
            this.pnPackage.Location = new System.Drawing.Point(46, 163);
            this.pnPackage.Name = "pnPackage";
            this.pnPackage.Size = new System.Drawing.Size(272, 245);
            this.pnPackage.TabIndex = 4;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblPackage.Location = new System.Drawing.Point(47, 100);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(171, 22);
            this.lblPackage.TabIndex = 3;
            this.lblPackage.Text = "Pagamentos Mensais";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(9, 159);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(252, 42);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Ir para a tela";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pcPackage
            // 
            this.pcPackage.Image = global::SystemGymControl.Properties.Resources.icons8_card_payment_64px1;
            this.pcPackage.Location = new System.Drawing.Point(102, 28);
            this.pcPackage.Name = "pcPackage";
            this.pcPackage.Size = new System.Drawing.Size(64, 64);
            this.pcPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPackage.TabIndex = 1;
            this.pcPackage.TabStop = false;
            // 
            // FrmOptionsPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 570);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.pnPackage);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOptionsPayment";
            this.Text = "FrmOptionsSave";
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).EndInit();
            this.pnPackage.ResumeLayout(false);
            this.pnPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.PictureBox pcUser;
        private System.Windows.Forms.Panel pnPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.PictureBox pcPackage;
    }
}