namespace SystemGymControl
{
    partial class FrmReportCashFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDataBox = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxClosure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxExit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBalancePrevious = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataBank = new System.Windows.Forms.DataGridView();
            this.bankDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBankEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBankExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBankClosure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankExit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBankEntry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankBalancePrevious = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtValueInitial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValueInBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBank)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtValueInBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtValueInitial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dgvDataBox);
            this.groupBox1.Controls.Add(this.txtBoxClosure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBalanceCurrent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxExit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxEntry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxBalancePrevious);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa";
            // 
            // dgvDataBox
            // 
            this.dgvDataBox.AllowUserToAddRows = false;
            this.dgvDataBox.AllowUserToDeleteRows = false;
            this.dgvDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBox.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataBox.ColumnHeadersHeight = 35;
            this.dgvDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.description,
            this.valueEntry,
            this.ValueExit});
            this.dgvDataBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataBox.EnableHeadersVisualStyles = false;
            this.dgvDataBox.Location = new System.Drawing.Point(29, 120);
            this.dgvDataBox.MultiSelect = false;
            this.dgvDataBox.Name = "dgvDataBox";
            this.dgvDataBox.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvDataBox.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDataBox.Size = new System.Drawing.Size(977, 167);
            this.dgvDataBox.TabIndex = 19;
            this.dgvDataBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBox_CellClick);
            this.dgvDataBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBox_CellDoubleClick);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 52;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Descrição";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 91;
            // 
            // valueEntry
            // 
            this.valueEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueEntry.HeaderText = "Valor de Entrada";
            this.valueEntry.Name = "valueEntry";
            this.valueEntry.ReadOnly = true;
            this.valueEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueEntry.Width = 143;
            // 
            // ValueExit
            // 
            this.ValueExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValueExit.HeaderText = "Valor da Saída";
            this.ValueExit.Name = "ValueExit";
            this.ValueExit.ReadOnly = true;
            this.ValueExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValueExit.Width = 124;
            // 
            // txtBoxClosure
            // 
            this.txtBoxClosure.Location = new System.Drawing.Point(865, 66);
            this.txtBoxClosure.Name = "txtBoxClosure";
            this.txtBoxClosure.ReadOnly = true;
            this.txtBoxClosure.Size = new System.Drawing.Size(132, 29);
            this.txtBoxClosure.TabIndex = 9;
            this.txtBoxClosure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(861, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fechamento";
            // 
            // txtBalanceCurrent
            // 
            this.txtBalanceCurrent.Location = new System.Drawing.Point(589, 66);
            this.txtBalanceCurrent.Name = "txtBalanceCurrent";
            this.txtBalanceCurrent.ReadOnly = true;
            this.txtBalanceCurrent.Size = new System.Drawing.Size(132, 29);
            this.txtBalanceCurrent.TabIndex = 7;
            this.txtBalanceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(585, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo atual";
            // 
            // txtBoxExit
            // 
            this.txtBoxExit.Location = new System.Drawing.Point(451, 66);
            this.txtBoxExit.Name = "txtBoxExit";
            this.txtBoxExit.ReadOnly = true;
            this.txtBoxExit.Size = new System.Drawing.Size(132, 29);
            this.txtBoxExit.TabIndex = 5;
            this.txtBoxExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(451, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saída";
            // 
            // txtBoxEntry
            // 
            this.txtBoxEntry.Location = new System.Drawing.Point(313, 66);
            this.txtBoxEntry.Name = "txtBoxEntry";
            this.txtBoxEntry.ReadOnly = true;
            this.txtBoxEntry.Size = new System.Drawing.Size(132, 29);
            this.txtBoxEntry.TabIndex = 3;
            this.txtBoxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(309, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // txtBoxBalancePrevious
            // 
            this.txtBoxBalancePrevious.Location = new System.Drawing.Point(37, 66);
            this.txtBoxBalancePrevious.Name = "txtBoxBalancePrevious";
            this.txtBoxBalancePrevious.ReadOnly = true;
            this.txtBoxBalancePrevious.Size = new System.Drawing.Size(132, 29);
            this.txtBoxBalancePrevious.TabIndex = 1;
            this.txtBoxBalancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo anterior";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDataBank);
            this.groupBox2.Controls.Add(this.txtBankClosure);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBankBalanceCurrent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBankExit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBankEntry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBankBalancePrevious);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(24, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 284);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banco";
            // 
            // dgvDataBank
            // 
            this.dgvDataBank.AllowUserToAddRows = false;
            this.dgvDataBank.AllowUserToDeleteRows = false;
            this.dgvDataBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBank.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDataBank.ColumnHeadersHeight = 35;
            this.dgvDataBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankDateEntry,
            this.bankDescription,
            this.valueBankEntry,
            this.valueBankExit});
            this.dgvDataBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataBank.EnableHeadersVisualStyles = false;
            this.dgvDataBank.Location = new System.Drawing.Point(29, 110);
            this.dgvDataBank.MultiSelect = false;
            this.dgvDataBank.Name = "dgvDataBank";
            this.dgvDataBank.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataBank.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvDataBank.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDataBank.Size = new System.Drawing.Size(977, 168);
            this.dgvDataBank.TabIndex = 20;
            // 
            // bankDateEntry
            // 
            this.bankDateEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bankDateEntry.HeaderText = "Data";
            this.bankDateEntry.Name = "bankDateEntry";
            this.bankDateEntry.ReadOnly = true;
            this.bankDateEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bankDateEntry.Width = 52;
            // 
            // bankDescription
            // 
            this.bankDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bankDescription.HeaderText = "Descrição";
            this.bankDescription.Name = "bankDescription";
            this.bankDescription.ReadOnly = true;
            this.bankDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bankDescription.Width = 91;
            // 
            // valueBankEntry
            // 
            this.valueBankEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueBankEntry.HeaderText = "Valor da Entrada";
            this.valueBankEntry.Name = "valueBankEntry";
            this.valueBankEntry.ReadOnly = true;
            this.valueBankEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueBankEntry.Width = 143;
            // 
            // valueBankExit
            // 
            this.valueBankExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueBankExit.HeaderText = "Valor da Saída";
            this.valueBankExit.Name = "valueBankExit";
            this.valueBankExit.ReadOnly = true;
            this.valueBankExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueBankExit.Width = 124;
            // 
            // txtBankClosure
            // 
            this.txtBankClosure.Location = new System.Drawing.Point(759, 65);
            this.txtBankClosure.Name = "txtBankClosure";
            this.txtBankClosure.ReadOnly = true;
            this.txtBankClosure.Size = new System.Drawing.Size(176, 29);
            this.txtBankClosure.TabIndex = 9;
            this.txtBankClosure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(755, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fechamento";
            // 
            // txtBankBalanceCurrent
            // 
            this.txtBankBalanceCurrent.Location = new System.Drawing.Point(575, 65);
            this.txtBankBalanceCurrent.Name = "txtBankBalanceCurrent";
            this.txtBankBalanceCurrent.ReadOnly = true;
            this.txtBankBalanceCurrent.Size = new System.Drawing.Size(176, 29);
            this.txtBankBalanceCurrent.TabIndex = 7;
            this.txtBankBalanceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(571, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo atual";
            // 
            // txtBankExit
            // 
            this.txtBankExit.Location = new System.Drawing.Point(393, 65);
            this.txtBankExit.Name = "txtBankExit";
            this.txtBankExit.ReadOnly = true;
            this.txtBankExit.Size = new System.Drawing.Size(176, 29);
            this.txtBankExit.TabIndex = 5;
            this.txtBankExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(403, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Saída";
            // 
            // txtBankEntry
            // 
            this.txtBankEntry.Location = new System.Drawing.Point(211, 65);
            this.txtBankEntry.Name = "txtBankEntry";
            this.txtBankEntry.ReadOnly = true;
            this.txtBankEntry.Size = new System.Drawing.Size(176, 29);
            this.txtBankEntry.TabIndex = 3;
            this.txtBankEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(217, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Entrada";
            // 
            // txtBankBalancePrevious
            // 
            this.txtBankBalancePrevious.Location = new System.Drawing.Point(29, 65);
            this.txtBankBalancePrevious.Name = "txtBankBalancePrevious";
            this.txtBankBalancePrevious.ReadOnly = true;
            this.txtBankBalancePrevious.Size = new System.Drawing.Size(176, 29);
            this.txtBankBalancePrevious.TabIndex = 1;
            this.txtBankBalancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Saldo anterior";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(902, 640);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(193, 42);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtValueInitial
            // 
            this.txtValueInitial.Location = new System.Drawing.Point(175, 66);
            this.txtValueInitial.Name = "txtValueInitial";
            this.txtValueInitial.ReadOnly = true;
            this.txtValueInitial.Size = new System.Drawing.Size(132, 29);
            this.txtValueInitial.TabIndex = 21;
            this.txtValueInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(171, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Valor Inicial";
            // 
            // txtValueInBox
            // 
            this.txtValueInBox.Location = new System.Drawing.Point(727, 66);
            this.txtValueInBox.Name = "txtValueInBox";
            this.txtValueInBox.ReadOnly = true;
            this.txtValueInBox.Size = new System.Drawing.Size(132, 29);
            this.txtValueInBox.TabIndex = 23;
            this.txtValueInBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(723, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "Valor em caixa";
            // 
            // FrmReportCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1131, 706);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportCashFlow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxBalancePrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxClosure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalanceCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDataBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDataBank;
        private System.Windows.Forms.TextBox txtBankClosure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankBalanceCurrent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBankEntry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankBalancePrevious;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBankEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBankExit;
        private System.Windows.Forms.TextBox txtValueInitial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValueInBox;
        private System.Windows.Forms.Label label12;
    }
}