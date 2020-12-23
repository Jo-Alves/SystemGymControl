﻿namespace SystemGymControl
{
    partial class FrmCardInPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardInPayment));
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.ndNumberPortions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPortions = new System.Windows.Forms.DataGridView();
            this.portion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePortion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblvalueTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumberPortions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortions)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParcelas
            // 
            this.gbParcelas.Controls.Add(this.ndNumberPortions);
            this.gbParcelas.Controls.Add(this.label1);
            this.gbParcelas.Controls.Add(this.dgvPortions);
            this.gbParcelas.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParcelas.ForeColor = System.Drawing.Color.White;
            this.gbParcelas.Location = new System.Drawing.Point(41, 109);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(536, 287);
            this.gbParcelas.TabIndex = 315;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // ndNumberPortions
            // 
            this.ndNumberPortions.Location = new System.Drawing.Point(20, 47);
            this.ndNumberPortions.Name = "ndNumberPortions";
            this.ndNumberPortions.Size = new System.Drawing.Size(120, 29);
            this.ndNumberPortions.TabIndex = 317;
            this.ndNumberPortions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndNumberPortions.ValueChanged += new System.EventHandler(this.ndNumberPortions_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 316;
            this.label1.Text = "Nº Parcela:";
            // 
            // dgvPortions
            // 
            this.dgvPortions.AllowUserToAddRows = false;
            this.dgvPortions.AllowUserToDeleteRows = false;
            this.dgvPortions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPortions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPortions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPortions.ColumnHeadersHeight = 30;
            this.dgvPortions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPortions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portion,
            this.dueDate,
            this.valuePortion});
            this.dgvPortions.EnableHeadersVisualStyles = false;
            this.dgvPortions.Location = new System.Drawing.Point(20, 82);
            this.dgvPortions.MultiSelect = false;
            this.dgvPortions.Name = "dgvPortions";
            this.dgvPortions.ReadOnly = true;
            this.dgvPortions.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvPortions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPortions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortions.Size = new System.Drawing.Size(497, 199);
            this.dgvPortions.TabIndex = 315;
            this.dgvPortions.TabStop = false;
            // 
            // portion
            // 
            this.portion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.portion.DefaultCellStyle = dataGridViewCellStyle2;
            this.portion.HeaderText = "Nº da parcela";
            this.portion.Name = "portion";
            this.portion.ReadOnly = true;
            this.portion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.portion.Width = 130;
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dueDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dueDate.HeaderText = "Vencimento";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            this.dueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dueDate.Width = 117;
            // 
            // valuePortion
            // 
            this.valuePortion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valuePortion.DefaultCellStyle = dataGridViewCellStyle4;
            this.valuePortion.HeaderText = "Valor da Parcela";
            this.valuePortion.Name = "valuePortion";
            this.valuePortion.ReadOnly = true;
            this.valuePortion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblvalueTotal
            // 
            this.lblvalueTotal.BackColor = System.Drawing.Color.White;
            this.lblvalueTotal.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblvalueTotal.ForeColor = System.Drawing.Color.Black;
            this.lblvalueTotal.Location = new System.Drawing.Point(214, 56);
            this.lblvalueTotal.Name = "lblvalueTotal";
            this.lblvalueTotal.Size = new System.Drawing.Size(155, 28);
            this.lblvalueTotal.TabIndex = 318;
            this.lblvalueTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(230, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 22);
            this.label10.TabIndex = 317;
            this.label10.Text = "Valor do plano";
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
            this.btnCancel.Location = new System.Drawing.Point(195, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 320;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(41, 402);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(148, 40);
            this.btnFinish.TabIndex = 319;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finalizar";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(596, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 321;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // FrmCardInPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(625, 457);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblvalueTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbParcelas);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCardInPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento a Cartão";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCardInPayment_MouseDown);
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumberPortions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPortions;
        private System.Windows.Forms.Label lblvalueTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn portion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePortion;
        private System.Windows.Forms.NumericUpDown ndNumberPortions;
    }
}