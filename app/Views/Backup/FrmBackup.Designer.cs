
namespace SystemGymControl
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateBackup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(23, 48);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(451, 29);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diretório";
            // 
            // btnGenerateBackup
            // 
            this.btnGenerateBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnGenerateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBackup.FlatAppearance.BorderSize = 0;
            this.btnGenerateBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnGenerateBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnGenerateBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBackup.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBackup.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBackup.Location = new System.Drawing.Point(361, 91);
            this.btnGenerateBackup.Name = "btnGenerateBackup";
            this.btnGenerateBackup.Size = new System.Drawing.Size(170, 43);
            this.btnGenerateBackup.TabIndex = 325;
            this.btnGenerateBackup.TabStop = false;
            this.btnGenerateBackup.Text = "Gerar backup";
            this.btnGenerateBackup.UseVisualStyleBackColor = false;
            this.btnGenerateBackup.Click += new System.EventHandler(this.btnGenerateBackup_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(532, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 30);
            this.btnClose.TabIndex = 326;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
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
            this.btnOpenDirectory.Location = new System.Drawing.Point(480, 46);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(51, 36);
            this.btnOpenDirectory.TabIndex = 327;
            this.btnOpenDirectory.TabStop = false;
            this.btnOpenDirectory.Text = "...";
            this.btnOpenDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenDirectory.UseVisualStyleBackColor = false;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "bak|*.bak";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(559, 146);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectory);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmBackup_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateBackup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}