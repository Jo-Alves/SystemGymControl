
namespace SystemGymControl
{
    partial class FrmClosingCashFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberBox = new System.Windows.Forms.Label();
            this.lblDateEntry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lblValueCardDeb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblValueCardCred = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblValueReceipt = new System.Windows.Forms.Label();
            this.lblValueReicept = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExitBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEntryBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDataHistoryPayment = new System.Windows.Forms.DataGridView();
            this.idCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValueTotalBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataHistoryPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa Nº";
            // 
            // lblNumberBox
            // 
            this.lblNumberBox.BackColor = System.Drawing.Color.White;
            this.lblNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberBox.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblNumberBox.ForeColor = System.Drawing.Color.Black;
            this.lblNumberBox.Location = new System.Drawing.Point(26, 48);
            this.lblNumberBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberBox.Name = "lblNumberBox";
            this.lblNumberBox.Size = new System.Drawing.Size(176, 32);
            this.lblNumberBox.TabIndex = 1;
            this.lblNumberBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateEntry
            // 
            this.lblDateEntry.BackColor = System.Drawing.Color.White;
            this.lblDateEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateEntry.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblDateEntry.ForeColor = System.Drawing.Color.Black;
            this.lblDateEntry.Location = new System.Drawing.Point(213, 48);
            this.lblDateEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEntry.Name = "lblDateEntry";
            this.lblDateEntry.Size = new System.Drawing.Size(238, 32);
            this.lblDateEntry.TabIndex = 3;
            this.lblDateEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(213, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de abertura";
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.lblValueCardDeb);
            this.gb.Controls.Add(this.label13);
            this.gb.Controls.Add(this.lblValueCardCred);
            this.gb.Controls.Add(this.label11);
            this.gb.Controls.Add(this.lblValueReceipt);
            this.gb.Controls.Add(this.lblValueReicept);
            this.gb.Controls.Add(this.label8);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.lblDiscount);
            this.gb.Controls.Add(this.label9);
            this.gb.Controls.Add(this.lblExitBox);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.lblEntryBox);
            this.gb.Controls.Add(this.label3);
            this.gb.ForeColor = System.Drawing.Color.Black;
            this.gb.Location = new System.Drawing.Point(20, 102);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(774, 182);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            this.gb.Text = "Movimentação do dia";
            // 
            // lblValueCardDeb
            // 
            this.lblValueCardDeb.BackColor = System.Drawing.Color.White;
            this.lblValueCardDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueCardDeb.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblValueCardDeb.ForeColor = System.Drawing.Color.Black;
            this.lblValueCardDeb.Location = new System.Drawing.Point(185, 138);
            this.lblValueCardDeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueCardDeb.Name = "lblValueCardDeb";
            this.lblValueCardDeb.Size = new System.Drawing.Size(152, 32);
            this.lblValueCardDeb.TabIndex = 19;
            this.lblValueCardDeb.Text = "R$ 0,00";
            this.lblValueCardDeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(185, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "V.  C. de débito";
            // 
            // lblValueCardCred
            // 
            this.lblValueCardCred.BackColor = System.Drawing.Color.White;
            this.lblValueCardCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueCardCred.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblValueCardCred.ForeColor = System.Drawing.Color.Black;
            this.lblValueCardCred.Location = new System.Drawing.Point(10, 138);
            this.lblValueCardCred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueCardCred.Name = "lblValueCardCred";
            this.lblValueCardCred.Size = new System.Drawing.Size(152, 32);
            this.lblValueCardCred.TabIndex = 17;
            this.lblValueCardCred.Text = "R$ 0,00";
            this.lblValueCardCred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "V.  C. de crédito";
            // 
            // lblValueReceipt
            // 
            this.lblValueReceipt.BackColor = System.Drawing.Color.White;
            this.lblValueReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueReceipt.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblValueReceipt.ForeColor = System.Drawing.Color.Red;
            this.lblValueReceipt.Location = new System.Drawing.Point(358, 138);
            this.lblValueReceipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueReceipt.Name = "lblValueReceipt";
            this.lblValueReceipt.Size = new System.Drawing.Size(152, 32);
            this.lblValueReceipt.TabIndex = 15;
            this.lblValueReceipt.Text = "R$ 0,00";
            this.lblValueReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValueReicept
            // 
            this.lblValueReicept.BackColor = System.Drawing.Color.White;
            this.lblValueReicept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueReicept.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblValueReicept.ForeColor = System.Drawing.Color.Green;
            this.lblValueReicept.Location = new System.Drawing.Point(528, 66);
            this.lblValueReicept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueReicept.Name = "lblValueReicept";
            this.lblValueReicept.Size = new System.Drawing.Size(152, 32);
            this.lblValueReicept.TabIndex = 13;
            this.lblValueReicept.Text = "R$ 0,00";
            this.lblValueReicept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(353, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor a receber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(523, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Recebido";
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.White;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(358, 66);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(152, 32);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "R$ 0,00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(353, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Desconto";
            // 
            // lblExitBox
            // 
            this.lblExitBox.BackColor = System.Drawing.Color.White;
            this.lblExitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExitBox.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblExitBox.ForeColor = System.Drawing.Color.Black;
            this.lblExitBox.Location = new System.Drawing.Point(181, 66);
            this.lblExitBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitBox.Name = "lblExitBox";
            this.lblExitBox.Size = new System.Drawing.Size(152, 32);
            this.lblExitBox.TabIndex = 5;
            this.lblExitBox.Text = "R$ 0,00";
            this.lblExitBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(176, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Retiradas no caixa";
            // 
            // lblEntryBox
            // 
            this.lblEntryBox.BackColor = System.Drawing.Color.White;
            this.lblEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntryBox.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblEntryBox.ForeColor = System.Drawing.Color.Black;
            this.lblEntryBox.Location = new System.Drawing.Point(10, 66);
            this.lblEntryBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryBox.Name = "lblEntryBox";
            this.lblEntryBox.Size = new System.Drawing.Size(152, 32);
            this.lblEntryBox.TabIndex = 3;
            this.lblEntryBox.Text = "R$ 0,00";
            this.lblEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrada do caixa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDataHistoryPayment);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico de pagamento";
            // 
            // dgvDataHistoryPayment
            // 
            this.dgvDataHistoryPayment.AllowUserToAddRows = false;
            this.dgvDataHistoryPayment.AllowUserToDeleteRows = false;
            this.dgvDataHistoryPayment.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataHistoryPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataHistoryPayment.ColumnHeadersHeight = 35;
            this.dgvDataHistoryPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataHistoryPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCash,
            this.description,
            this.value,
            this.valueDiscount,
            this.formPayment,
            this.payday,
            this.paymentTime});
            this.dgvDataHistoryPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataHistoryPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataHistoryPayment.EnableHeadersVisualStyles = false;
            this.dgvDataHistoryPayment.Location = new System.Drawing.Point(3, 29);
            this.dgvDataHistoryPayment.MultiSelect = false;
            this.dgvDataHistoryPayment.Name = "dgvDataHistoryPayment";
            this.dgvDataHistoryPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataHistoryPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataHistoryPayment.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvDataHistoryPayment.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataHistoryPayment.Size = new System.Drawing.Size(768, 258);
            this.dgvDataHistoryPayment.TabIndex = 31;
            this.dgvDataHistoryPayment.TabStop = false;
            // 
            // idCash
            // 
            this.idCash.HeaderText = "idCach";
            this.idCash.Name = "idCash";
            this.idCash.ReadOnly = true;
            this.idCash.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Pacote";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.value.DefaultCellStyle = dataGridViewCellStyle2;
            this.value.HeaderText = "Valor pago";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.value.Width = 113;
            // 
            // valueDiscount
            // 
            this.valueDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valueDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            this.valueDiscount.HeaderText = "Desconto";
            this.valueDiscount.Name = "valueDiscount";
            this.valueDiscount.ReadOnly = true;
            this.valueDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueDiscount.Width = 102;
            // 
            // formPayment
            // 
            this.formPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.formPayment.HeaderText = "Forma de Pagamento";
            this.formPayment.Name = "formPayment";
            this.formPayment.ReadOnly = true;
            this.formPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.formPayment.Width = 211;
            // 
            // payday
            // 
            this.payday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.payday.HeaderText = "Data de pagamento";
            this.payday.Name = "payday";
            this.payday.ReadOnly = true;
            this.payday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.payday.Width = 197;
            // 
            // paymentTime
            // 
            this.paymentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentTime.HeaderText = "Hora do pagamento";
            this.paymentTime.Name = "paymentTime";
            this.paymentTime.ReadOnly = true;
            this.paymentTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentTime.Width = 198;
            // 
            // txtValueTotalBox
            // 
            this.txtValueTotalBox.Location = new System.Drawing.Point(44, 628);
            this.txtValueTotalBox.Name = "txtValueTotalBox";
            this.txtValueTotalBox.Size = new System.Drawing.Size(158, 33);
            this.txtValueTotalBox.TabIndex = 0;
            this.txtValueTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueTotalBox.TextChanged += new System.EventHandler(this.txtValueTotalBox_TextChanged);
            this.txtValueTotalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueTotalBox_KeyPress);
            this.txtValueTotalBox.Leave += new System.EventHandler(this.txtValueTotalBox_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(39, 592);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 26);
            this.label14.TabIndex = 9;
            this.label14.Text = "Valor em caixa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(213, 592);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 26);
            this.label15.TabIndex = 11;
            this.label15.Text = "Saldo";
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
            this.btnCancel.Location = new System.Drawing.Point(563, 625);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(378, 625);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Fechar caixa";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(218, 628);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(152, 33);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(459, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Operador(a)";
            // 
            // lblOperator
            // 
            this.lblOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperator.BackColor = System.Drawing.Color.White;
            this.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperator.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblOperator.ForeColor = System.Drawing.Color.Black;
            this.lblOperator.Location = new System.Drawing.Point(459, 48);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(332, 32);
            this.lblOperator.TabIndex = 5;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmClosingCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 680);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValueTotalBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDateEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumberBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmClosingCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClosingCashFlow";
            this.Load += new System.EventHandler(this.FrmClosingCashFlow_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataHistoryPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberBox;
        private System.Windows.Forms.Label lblDateEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExitBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEntryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDataHistoryPayment;
        private System.Windows.Forms.TextBox txtValueTotalBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblValueReicept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn formPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn payday;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTime;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblValueReceipt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValueCardDeb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblValueCardCred;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOperator;
    }
}