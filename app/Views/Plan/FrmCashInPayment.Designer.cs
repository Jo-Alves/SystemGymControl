﻿
namespace SystemGymControl
{
    partial class FrmCashInPayment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPaidOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblDiscountMoney = new System.Windows.Forms.Label();
            this.txtDiscountMoney = new System.Windows.Forms.TextBox();
            this.lblValueWithDiscount = new System.Windows.Forms.Label();
            this.txtValueWithDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValuePackage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(621, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // txtPaidOut
            // 
            this.txtPaidOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidOut.Location = new System.Drawing.Point(20, 62);
            this.txtPaidOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPaidOut.Name = "txtPaidOut";
            this.txtPaidOut.Size = new System.Drawing.Size(148, 29);
            this.txtPaidOut.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor Pago";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(24, 108);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(148, 40);
            this.btnDiscount.TabIndex = 19;
            this.btnDiscount.TabStop = false;
            this.btnDiscount.Text = "Desconto";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.ForeColor = System.Drawing.Color.White;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(175, 91);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(109, 22);
            this.lblDiscountPercentage.TabIndex = 21;
            this.lblDiscountPercentage.Text = "Desconto - %";
            this.lblDiscountPercentage.Visible = false;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPercentage.Location = new System.Drawing.Point(179, 119);
            this.txtDiscountPercentage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(148, 29);
            this.txtDiscountPercentage.TabIndex = 20;
            this.txtDiscountPercentage.Visible = false;
            // 
            // lblDiscountMoney
            // 
            this.lblDiscountMoney.AutoSize = true;
            this.lblDiscountMoney.ForeColor = System.Drawing.Color.White;
            this.lblDiscountMoney.Location = new System.Drawing.Point(331, 91);
            this.lblDiscountMoney.Name = "lblDiscountMoney";
            this.lblDiscountMoney.Size = new System.Drawing.Size(115, 22);
            this.lblDiscountMoney.TabIndex = 23;
            this.lblDiscountMoney.Text = "Desconto - R$";
            this.lblDiscountMoney.Visible = false;
            // 
            // txtDiscountMoney
            // 
            this.txtDiscountMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountMoney.Location = new System.Drawing.Point(335, 119);
            this.txtDiscountMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountMoney.Name = "txtDiscountMoney";
            this.txtDiscountMoney.Size = new System.Drawing.Size(148, 29);
            this.txtDiscountMoney.TabIndex = 22;
            this.txtDiscountMoney.Visible = false;
            // 
            // lblValueWithDiscount
            // 
            this.lblValueWithDiscount.AutoSize = true;
            this.lblValueWithDiscount.ForeColor = System.Drawing.Color.White;
            this.lblValueWithDiscount.Location = new System.Drawing.Point(487, 91);
            this.lblValueWithDiscount.Name = "lblValueWithDiscount";
            this.lblValueWithDiscount.Size = new System.Drawing.Size(145, 22);
            this.lblValueWithDiscount.TabIndex = 25;
            this.lblValueWithDiscount.Text = "Valor c/ Desconto";
            this.lblValueWithDiscount.Visible = false;
            // 
            // txtValueWithDiscount
            // 
            this.txtValueWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueWithDiscount.Location = new System.Drawing.Point(491, 119);
            this.txtValueWithDiscount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValueWithDiscount.Name = "txtValueWithDiscount";
            this.txtValueWithDiscount.Size = new System.Drawing.Size(148, 29);
            this.txtValueWithDiscount.TabIndex = 24;
            this.txtValueWithDiscount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Troco";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(24, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 29);
            this.textBox1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 40);
            this.button1.TabIndex = 28;
            this.button1.TabStop = false;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(179, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 40);
            this.button2.TabIndex = 29;
            this.button2.TabStop = false;
            this.button2.Text = "Gerar Recibo";
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnCancel.Location = new System.Drawing.Point(335, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(216, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor do plano";
            // 
            // lblValuePackage
            // 
            this.lblValuePackage.AutoSize = true;
            this.lblValuePackage.ForeColor = System.Drawing.Color.White;
            this.lblValuePackage.Location = new System.Drawing.Point(216, 64);
            this.lblValuePackage.Name = "lblValuePackage";
            this.lblValuePackage.Size = new System.Drawing.Size(0, 22);
            this.lblValuePackage.TabIndex = 32;
            // 
            // FrmCashInPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(654, 310);
            this.Controls.Add(this.lblValuePackage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValueWithDiscount);
            this.Controls.Add(this.txtValueWithDiscount);
            this.Controls.Add(this.lblDiscountMoney);
            this.Controls.Add(this.txtDiscountMoney);
            this.Controls.Add(this.lblDiscountPercentage);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaidOut);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmCashInPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCashInPayment";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCashInPayment_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPaidOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountMoney;
        private System.Windows.Forms.TextBox txtDiscountMoney;
        private System.Windows.Forms.Label lblValueWithDiscount;
        private System.Windows.Forms.TextBox txtValueWithDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValuePackage;
    }
}