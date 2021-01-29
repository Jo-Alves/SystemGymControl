
namespace SystemGymControl
{
    partial class FrmReportReceipt
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
            this.rvReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvReceipt
            // 
            this.rvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvReceipt.LocalReport.ReportEmbeddedResource = "SystemGymControl.Views.Report.Recibo de Pagamento.rdlc";
            this.rvReceipt.Location = new System.Drawing.Point(0, 0);
            this.rvReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.rvReceipt.Name = "rvReceipt";
            this.rvReceipt.ServerReport.BearerToken = null;
            this.rvReceipt.Size = new System.Drawing.Size(656, 410);
            this.rvReceipt.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(520, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmReportReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 469);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rvReceipt);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReportReceipt";
            this.Text = "FrmReportReceipt";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReceipt;
        private System.Windows.Forms.Button btnBack;
    }
}