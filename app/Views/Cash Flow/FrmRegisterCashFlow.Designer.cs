
namespace SystemGymControl
{
    partial class FrmRegisterCashFlow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateFinally = new System.Windows.Forms.DateTimePicker();
            this.dtDateInitial = new System.Windows.Forms.DateTimePicker();
            this.rbSearchRegisterPeriod = new System.Windows.Forms.RadioButton();
            this.rbSearchAllRegister = new System.Windows.Forms.RadioButton();
            this.dgvDataRegisterCashFlow = new System.Windows.Forms.DataGridView();
            this.printRegister = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueInformed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashValueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputValueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValueTotalBoxInformed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValueTotalExit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBalances = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblValueTotalEntry = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRegisterCashFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbSearchRegisterPeriod);
            this.groupBox1.Controls.Add(this.rbSearchAllRegister);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchRegister);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtDateFinally);
            this.groupBox2.Controls.Add(this.dtDateInitial);
            this.groupBox2.Location = new System.Drawing.Point(506, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // btnSearchRegister
            // 
            this.btnSearchRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSearchRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRegister.Enabled = false;
            this.btnSearchRegister.FlatAppearance.BorderSize = 0;
            this.btnSearchRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSearchRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSearchRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRegister.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRegister.ForeColor = System.Drawing.Color.White;
            this.btnSearchRegister.Location = new System.Drawing.Point(255, 38);
            this.btnSearchRegister.Name = "btnSearchRegister";
            this.btnSearchRegister.Size = new System.Drawing.Size(214, 39);
            this.btnSearchRegister.TabIndex = 27;
            this.btnSearchRegister.Text = "Buscar";
            this.btnSearchRegister.UseVisualStyleBackColor = false;
            this.btnSearchRegister.Click += new System.EventHandler(this.btnSearchRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // dtDateFinally
            // 
            this.dtDateFinally.Enabled = false;
            this.dtDateFinally.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFinally.Location = new System.Drawing.Point(146, 44);
            this.dtDateFinally.Name = "dtDateFinally";
            this.dtDateFinally.Size = new System.Drawing.Size(103, 29);
            this.dtDateFinally.TabIndex = 1;
            // 
            // dtDateInitial
            // 
            this.dtDateInitial.Enabled = false;
            this.dtDateInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateInitial.Location = new System.Drawing.Point(6, 44);
            this.dtDateInitial.Name = "dtDateInitial";
            this.dtDateInitial.Size = new System.Drawing.Size(109, 29);
            this.dtDateInitial.TabIndex = 0;
            // 
            // rbSearchRegisterPeriod
            // 
            this.rbSearchRegisterPeriod.AutoSize = true;
            this.rbSearchRegisterPeriod.Location = new System.Drawing.Point(261, 63);
            this.rbSearchRegisterPeriod.Name = "rbSearchRegisterPeriod";
            this.rbSearchRegisterPeriod.Size = new System.Drawing.Size(239, 26);
            this.rbSearchRegisterPeriod.TabIndex = 2;
            this.rbSearchRegisterPeriod.Text = "Buscar registro por período";
            this.rbSearchRegisterPeriod.UseVisualStyleBackColor = true;
            this.rbSearchRegisterPeriod.CheckedChanged += new System.EventHandler(this.rbSearchRegisterPeriod_CheckedChanged);
            // 
            // rbSearchAllRegister
            // 
            this.rbSearchAllRegister.AutoSize = true;
            this.rbSearchAllRegister.Checked = true;
            this.rbSearchAllRegister.Location = new System.Drawing.Point(25, 63);
            this.rbSearchAllRegister.Name = "rbSearchAllRegister";
            this.rbSearchAllRegister.Size = new System.Drawing.Size(222, 26);
            this.rbSearchAllRegister.TabIndex = 1;
            this.rbSearchAllRegister.TabStop = true;
            this.rbSearchAllRegister.Text = "Buscar todos os registros";
            this.rbSearchAllRegister.UseVisualStyleBackColor = true;
            this.rbSearchAllRegister.CheckedChanged += new System.EventHandler(this.rbSearchAllRegister_CheckedChanged);
            // 
            // dgvDataRegisterCashFlow
            // 
            this.dgvDataRegisterCashFlow.AllowUserToAddRows = false;
            this.dgvDataRegisterCashFlow.AllowUserToDeleteRows = false;
            this.dgvDataRegisterCashFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataRegisterCashFlow.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataRegisterCashFlow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataRegisterCashFlow.ColumnHeadersHeight = 35;
            this.dgvDataRegisterCashFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataRegisterCashFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printRegister,
            this.id,
            this.openingDate,
            this.openingTime,
            this.valueInformed,
            this.cashValueTotal,
            this.outputValueTotal,
            this.balance,
            this.closingDate,
            this.closingTime});
            this.dgvDataRegisterCashFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataRegisterCashFlow.EnableHeadersVisualStyles = false;
            this.dgvDataRegisterCashFlow.Location = new System.Drawing.Point(55, 151);
            this.dgvDataRegisterCashFlow.MultiSelect = false;
            this.dgvDataRegisterCashFlow.Name = "dgvDataRegisterCashFlow";
            this.dgvDataRegisterCashFlow.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataRegisterCashFlow.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataRegisterCashFlow.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvDataRegisterCashFlow.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataRegisterCashFlow.Size = new System.Drawing.Size(1002, 262);
            this.dgvDataRegisterCashFlow.TabIndex = 18;
            this.dgvDataRegisterCashFlow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataRegisterCashFlow_CellClick);
            this.dgvDataRegisterCashFlow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataRegisterCashFlow_CellDoubleClick);
            // 
            // printRegister
            // 
            this.printRegister.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.printRegister.HeaderText = "Imprimir Registro";
            this.printRegister.Name = "printRegister";
            this.printRegister.ReadOnly = true;
            this.printRegister.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.printRegister.Width = 149;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "Nº Caixa";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 78;
            // 
            // openingDate
            // 
            this.openingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.openingDate.HeaderText = "Data de entrada";
            this.openingDate.Name = "openingDate";
            this.openingDate.ReadOnly = true;
            this.openingDate.Width = 158;
            // 
            // openingTime
            // 
            this.openingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.openingTime.HeaderText = "Hora da entrada";
            this.openingTime.Name = "openingTime";
            this.openingTime.ReadOnly = true;
            this.openingTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.openingTime.Width = 141;
            // 
            // valueInformed
            // 
            this.valueInformed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueInformed.HeaderText = "Valor informado no caixa";
            this.valueInformed.Name = "valueInformed";
            this.valueInformed.ReadOnly = true;
            this.valueInformed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueInformed.Width = 206;
            // 
            // cashValueTotal
            // 
            this.cashValueTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashValueTotal.HeaderText = "Valor de entradas";
            this.cashValueTotal.Name = "cashValueTotal";
            this.cashValueTotal.ReadOnly = true;
            this.cashValueTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cashValueTotal.Width = 151;
            // 
            // outputValueTotal
            // 
            this.outputValueTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.outputValueTotal.HeaderText = "Valor total de saídas";
            this.outputValueTotal.Name = "outputValueTotal";
            this.outputValueTotal.ReadOnly = true;
            this.outputValueTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.outputValueTotal.Width = 170;
            // 
            // balance
            // 
            this.balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balance.HeaderText = "saldo";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.balance.Width = 57;
            // 
            // closingDate
            // 
            this.closingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.closingDate.HeaderText = "Data de Saída";
            this.closingDate.Name = "closingDate";
            this.closingDate.ReadOnly = true;
            this.closingDate.Width = 139;
            // 
            // closingTime
            // 
            this.closingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.closingTime.HeaderText = "Hora da saída";
            this.closingTime.Name = "closingTime";
            this.closingTime.ReadOnly = true;
            this.closingTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.closingTime.Width = 121;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Valor total informado no caixa:";
            // 
            // lblValueTotalBoxInformed
            // 
            this.lblValueTotalBoxInformed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueTotalBoxInformed.AutoSize = true;
            this.lblValueTotalBoxInformed.Location = new System.Drawing.Point(331, 416);
            this.lblValueTotalBoxInformed.Name = "lblValueTotalBoxInformed";
            this.lblValueTotalBoxInformed.Size = new System.Drawing.Size(0, 22);
            this.lblValueTotalBoxInformed.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor total das entradas:";
            // 
            // lblValueTotalExit
            // 
            this.lblValueTotalExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueTotalExit.AutoSize = true;
            this.lblValueTotalExit.Location = new System.Drawing.Point(253, 460);
            this.lblValueTotalExit.Name = "lblValueTotalExit";
            this.lblValueTotalExit.Size = new System.Drawing.Size(0, 22);
            this.lblValueTotalExit.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(57, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valor total de saidas:";
            // 
            // lblBalances
            // 
            this.lblBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBalances.AutoSize = true;
            this.lblBalances.Location = new System.Drawing.Point(134, 484);
            this.lblBalances.Name = "lblBalances";
            this.lblBalances.Size = new System.Drawing.Size(0, 22);
            this.lblBalances.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(57, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Saldos:";
            // 
            // lblValueTotalEntry
            // 
            this.lblValueTotalEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueTotalEntry.AutoSize = true;
            this.lblValueTotalEntry.Location = new System.Drawing.Point(284, 438);
            this.lblValueTotalEntry.Name = "lblValueTotalEntry";
            this.lblValueTotalEntry.Size = new System.Drawing.Size(0, 22);
            this.lblValueTotalEntry.TabIndex = 27;
            // 
            // FrmRegisterCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1131, 523);
            this.Controls.Add(this.lblValueTotalEntry);
            this.Controls.Add(this.lblBalances);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblValueTotalExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValueTotalBoxInformed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDataRegisterCashFlow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegisterCashFlow";
            this.Text = "FrmResgisterCashFlow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRegisterCashFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateFinally;
        private System.Windows.Forms.DateTimePicker dtDateInitial;
        private System.Windows.Forms.RadioButton rbSearchRegisterPeriod;
        private System.Windows.Forms.RadioButton rbSearchAllRegister;
        private System.Windows.Forms.Button btnSearchRegister;
        private System.Windows.Forms.DataGridView dgvDataRegisterCashFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValueTotalBoxInformed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValueTotalExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBalances;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblValueTotalEntry;
        private System.Windows.Forms.DataGridViewImageColumn printRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueInformed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashValueTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputValueTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingTime;
    }
}