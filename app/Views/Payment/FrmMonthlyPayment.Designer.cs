
namespace SystemGymControl
{
    partial class FrmMonthlyPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyPayment));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDataPlan = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receive = new System.Windows.Forms.DataGridViewImageColumn();
            this.receipt = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPortion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePortion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtSearch.Location = new System.Drawing.Point(185, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = true;
            this.txtSearch.Size = new System.Drawing.Size(709, 33);
            this.txtSearch.TabIndex = 9;
            // 
            // dgvDataPlan
            // 
            this.dgvDataPlan.AllowUserToAddRows = false;
            this.dgvDataPlan.AllowUserToDeleteRows = false;
            this.dgvDataPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataPlan.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataPlan.ColumnHeadersHeight = 30;
            this.dgvDataPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receive,
            this.receipt,
            this.id,
            this.numberPortion,
            this.valuePortion,
            this.duedate,
            this.payday,
            this.paymentTime});
            this.dgvDataPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataPlan.EnableHeadersVisualStyles = false;
            this.dgvDataPlan.Location = new System.Drawing.Point(14, 96);
            this.dgvDataPlan.MultiSelect = false;
            this.dgvDataPlan.Name = "dgvDataPlan";
            this.dgvDataPlan.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataPlan.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvDataPlan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataPlan.Size = new System.Drawing.Size(1001, 330);
            this.dgvDataPlan.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 14F);
            this.textBox1.Location = new System.Drawing.Point(79, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 33);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome";
            // 
            // receive
            // 
            this.receive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.receive.HeaderText = "Receber";
            this.receive.Name = "receive";
            this.receive.ReadOnly = true;
            this.receive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receive.Width = 78;
            // 
            // receipt
            // 
            this.receipt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.receipt.HeaderText = "Gerar recibo";
            this.receipt.Name = "receipt";
            this.receipt.ReadOnly = true;
            this.receipt.Width = 112;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 69;
            // 
            // numberPortion
            // 
            this.numberPortion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberPortion.HeaderText = "Portion";
            this.numberPortion.Name = "numberPortion";
            this.numberPortion.ReadOnly = true;
            this.numberPortion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberPortion.Width = 73;
            // 
            // valuePortion
            // 
            this.valuePortion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valuePortion.HeaderText = "Valor da Parcela";
            this.valuePortion.Name = "valuePortion";
            this.valuePortion.ReadOnly = true;
            this.valuePortion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valuePortion.Width = 139;
            // 
            // duedate
            // 
            this.duedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duedate.HeaderText = "Data de vencimento";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            this.duedate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duedate.Width = 168;
            // 
            // payday
            // 
            this.payday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.payday.HeaderText = "Data de pagamento";
            this.payday.Name = "payday";
            this.payday.ReadOnly = true;
            this.payday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.payday.Width = 166;
            // 
            // paymentTime
            // 
            this.paymentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentTime.HeaderText = "Hora do pagamento";
            this.paymentTime.Name = "paymentTime";
            this.paymentTime.ReadOnly = true;
            this.paymentTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentTime.Width = 169;
            // 
            // FrmMonthlyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1027, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDataPlan);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMonthlyPayment";
            this.Text = "FrmPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDataPlan;
        private System.Windows.Forms.DataGridViewImageColumn receive;
        private System.Windows.Forms.DataGridViewImageColumn receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPortion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePortion;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn payday;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}