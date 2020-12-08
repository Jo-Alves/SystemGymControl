namespace SystemGymControl
{
    partial class FrmOptionsPlan
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
            this.pnPlan = new System.Windows.Forms.Panel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.btnPlan = new System.Windows.Forms.Button();
            this.pcPlan = new System.Windows.Forms.PictureBox();
            this.pnPausedPlan = new System.Windows.Forms.Panel();
            this.lblPausedPlan = new System.Windows.Forms.Label();
            this.btnPausedPlan = new System.Windows.Forms.Button();
            this.pcPausedPlan = new System.Windows.Forms.PictureBox();
            this.pnPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPlan)).BeginInit();
            this.pnPausedPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPausedPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPlan
            // 
            this.pnPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPlan.Controls.Add(this.lblPlan);
            this.pnPlan.Controls.Add(this.btnPlan);
            this.pnPlan.Controls.Add(this.pcPlan);
            this.pnPlan.Location = new System.Drawing.Point(229, 170);
            this.pnPlan.Name = "pnPlan";
            this.pnPlan.Size = new System.Drawing.Size(272, 245);
            this.pnPlan.TabIndex = 1;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblPlan.Location = new System.Drawing.Point(108, 102);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(53, 22);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plano";
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlan.FlatAppearance.BorderSize = 0;
            this.btnPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlan.ForeColor = System.Drawing.Color.White;
            this.btnPlan.Location = new System.Drawing.Point(9, 159);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(252, 42);
            this.btnPlan.TabIndex = 1;
            this.btnPlan.Text = "Ir para a tela";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // pcPlan
            // 
            this.pcPlan.Image = global::SystemGymControl.Properties.Resources.icons8_floor_plan_64px;
            this.pcPlan.Location = new System.Drawing.Point(102, 28);
            this.pcPlan.Name = "pcPlan";
            this.pcPlan.Size = new System.Drawing.Size(64, 64);
            this.pcPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPlan.TabIndex = 0;
            this.pcPlan.TabStop = false;
            // 
            // pnPausedPlan
            // 
            this.pnPausedPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPausedPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnPausedPlan.Controls.Add(this.lblPausedPlan);
            this.pnPausedPlan.Controls.Add(this.btnPausedPlan);
            this.pnPausedPlan.Controls.Add(this.pcPausedPlan);
            this.pnPausedPlan.Location = new System.Drawing.Point(680, 170);
            this.pnPausedPlan.Name = "pnPausedPlan";
            this.pnPausedPlan.Size = new System.Drawing.Size(272, 245);
            this.pnPausedPlan.TabIndex = 2;
            // 
            // lblPausedPlan
            // 
            this.lblPausedPlan.AutoSize = true;
            this.lblPausedPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblPausedPlan.Location = new System.Drawing.Point(109, 102);
            this.lblPausedPlan.Name = "lblPausedPlan";
            this.lblPausedPlan.Size = new System.Drawing.Size(60, 22);
            this.lblPausedPlan.TabIndex = 3;
            this.lblPausedPlan.Text = "Pausa ";
            // 
            // btnPausedPlan
            // 
            this.btnPausedPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnPausedPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausedPlan.FlatAppearance.BorderSize = 0;
            this.btnPausedPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnPausedPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPausedPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausedPlan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausedPlan.ForeColor = System.Drawing.Color.White;
            this.btnPausedPlan.Location = new System.Drawing.Point(9, 159);
            this.btnPausedPlan.Name = "btnPausedPlan";
            this.btnPausedPlan.Size = new System.Drawing.Size(252, 42);
            this.btnPausedPlan.TabIndex = 2;
            this.btnPausedPlan.Text = "Ir para a tela";
            this.btnPausedPlan.UseVisualStyleBackColor = false;
            this.btnPausedPlan.Click += new System.EventHandler(this.btnPausedPlan_Click);
            // 
            // pcPausedPlan
            // 
            this.pcPausedPlan.Image = global::SystemGymControl.Properties.Resources.icons8_handle_with_care_64px_1;
            this.pcPausedPlan.Location = new System.Drawing.Point(102, 28);
            this.pcPausedPlan.Name = "pcPausedPlan";
            this.pcPausedPlan.Size = new System.Drawing.Size(64, 64);
            this.pcPausedPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPausedPlan.TabIndex = 1;
            this.pcPausedPlan.TabStop = false;
            // 
            // FrmOptionsPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1131, 570);
            this.Controls.Add(this.pnPausedPlan);
            this.Controls.Add(this.pnPlan);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOptionsPlan";
            this.Text = "FrmOptionsSave";
            this.pnPlan.ResumeLayout(false);
            this.pnPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPlan)).EndInit();
            this.pnPausedPlan.ResumeLayout(false);
            this.pnPausedPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPausedPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnPlan;
        private System.Windows.Forms.PictureBox pcPlan;
        private System.Windows.Forms.Panel pnPausedPlan;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnPausedPlan;
        private System.Windows.Forms.PictureBox pcPausedPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblPausedPlan;
    }
}