namespace SystemGymControl
{
    partial class FrmHome
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
            this.pcLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcLogo
            // 
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLogo.Image = global::SystemGymControl.Properties.Resources.logo;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(634, 438);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogo.TabIndex = 2;
            this.pcLogo.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(634, 438);
            this.Controls.Add(this.pcLogo);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogo;
    }
}