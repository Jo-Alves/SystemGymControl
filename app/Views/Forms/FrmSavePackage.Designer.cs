﻿
namespace SystemGymControl
{
    partial class FrmSavePackage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.ndDuration = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbPercentageInterest = new System.Windows.Forms.RadioButton();
            this.rbValueInterest = new System.Windows.Forms.RadioButton();
            this.txtValueInterest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPercentagePenalty = new System.Windows.Forms.RadioButton();
            this.rbValuePenalty = new System.Windows.Forms.RadioButton();
            this.txtValuePenalty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFormOfPagament = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.formOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFormOfPayement = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormOfPagament)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(21, 71);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(601, 33);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(169, 118);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 26);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duração";
            // 
            // ndDuration
            // 
            this.ndDuration.Enabled = false;
            this.ndDuration.Location = new System.Drawing.Point(174, 147);
            this.ndDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndDuration.Name = "ndDuration";
            this.ndDuration.Size = new System.Drawing.Size(120, 33);
            this.ndDuration.TabIndex = 5;
            this.ndDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnCancel.Location = new System.Drawing.Point(153, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(21, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 52;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "Período";
            // 
            // cbPeriod
            // 
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Diário",
            "Mensal",
            "Bimestral",
            "Trimestral",
            "Semestral",
            "Anual",
            "Quinzena",
            "Quarentena",
            "Outros"});
            this.cbPeriod.Location = new System.Drawing.Point(21, 147);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(147, 34);
            this.cbPeriod.TabIndex = 54;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 207);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbPercentageInterest);
            this.panel2.Controls.Add(this.rbValueInterest);
            this.panel2.Controls.Add(this.txtValueInterest);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 81);
            this.panel2.TabIndex = 1;
            // 
            // rbPercentageInterest
            // 
            this.rbPercentageInterest.AutoSize = true;
            this.rbPercentageInterest.Location = new System.Drawing.Point(451, 31);
            this.rbPercentageInterest.Name = "rbPercentageInterest";
            this.rbPercentageInterest.Size = new System.Drawing.Size(149, 30);
            this.rbPercentageInterest.TabIndex = 62;
            this.rbPercentageInterest.Text = "Porcentagem";
            this.rbPercentageInterest.UseVisualStyleBackColor = true;
            // 
            // rbValueInterest
            // 
            this.rbValueInterest.AutoSize = true;
            this.rbValueInterest.Checked = true;
            this.rbValueInterest.Location = new System.Drawing.Point(334, 31);
            this.rbValueInterest.Name = "rbValueInterest";
            this.rbValueInterest.Size = new System.Drawing.Size(111, 30);
            this.rbValueInterest.TabIndex = 61;
            this.rbValueInterest.TabStop = true;
            this.rbValueInterest.Text = "Valor(R$)";
            this.rbValueInterest.UseVisualStyleBackColor = true;
            // 
            // txtValueInterest
            // 
            this.txtValueInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueInterest.Location = new System.Drawing.Point(179, 28);
            this.txtValueInterest.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueInterest.Name = "txtValueInterest";
            this.txtValueInterest.Size = new System.Drawing.Size(143, 33);
            this.txtValueInterest.TabIndex = 60;
            this.txtValueInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueInterest_KeyPress);
            this.txtValueInterest.Leave += new System.EventHandler(this.txtValueInterest_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 59;
            this.label5.Text = "Juros Diários";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPercentagePenalty);
            this.panel1.Controls.Add(this.rbValuePenalty);
            this.panel1.Controls.Add(this.txtValuePenalty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 88);
            this.panel1.TabIndex = 0;
            // 
            // rbPercentagePenalty
            // 
            this.rbPercentagePenalty.AutoSize = true;
            this.rbPercentagePenalty.Location = new System.Drawing.Point(446, 26);
            this.rbPercentagePenalty.Name = "rbPercentagePenalty";
            this.rbPercentagePenalty.Size = new System.Drawing.Size(149, 30);
            this.rbPercentagePenalty.TabIndex = 60;
            this.rbPercentagePenalty.Text = "Porcentagem";
            this.rbPercentagePenalty.UseVisualStyleBackColor = true;
            // 
            // rbValuePenalty
            // 
            this.rbValuePenalty.AutoSize = true;
            this.rbValuePenalty.Checked = true;
            this.rbValuePenalty.Location = new System.Drawing.Point(329, 26);
            this.rbValuePenalty.Name = "rbValuePenalty";
            this.rbValuePenalty.Size = new System.Drawing.Size(111, 30);
            this.rbValuePenalty.TabIndex = 59;
            this.rbValuePenalty.TabStop = true;
            this.rbValuePenalty.Text = "Valor(R$)";
            this.rbValuePenalty.UseVisualStyleBackColor = true;
            // 
            // txtValuePenalty
            // 
            this.txtValuePenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValuePenalty.Location = new System.Drawing.Point(179, 26);
            this.txtValuePenalty.Margin = new System.Windows.Forms.Padding(4);
            this.txtValuePenalty.Name = "txtValuePenalty";
            this.txtValuePenalty.Size = new System.Drawing.Size(143, 33);
            this.txtValuePenalty.TabIndex = 58;
            this.txtValuePenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValuePenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValuePenalty_KeyPress);
            this.txtValuePenalty.Leave += new System.EventHandler(this.txtValuePenalty_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Multa p/ atraso";
            // 
            // dgvFormOfPagament
            // 
            this.dgvFormOfPagament.AllowUserToAddRows = false;
            this.dgvFormOfPagament.AllowUserToDeleteRows = false;
            this.dgvFormOfPagament.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFormOfPagament.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormOfPagament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFormOfPagament.ColumnHeadersHeight = 30;
            this.dgvFormOfPagament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFormOfPagament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete,
            this.formOfPayment,
            this.value});
            this.dgvFormOfPagament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFormOfPagament.EnableHeadersVisualStyles = false;
            this.dgvFormOfPagament.Location = new System.Drawing.Point(630, 71);
            this.dgvFormOfPagament.MultiSelect = false;
            this.dgvFormOfPagament.Name = "dgvFormOfPagament";
            this.dgvFormOfPagament.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormOfPagament.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFormOfPagament.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvFormOfPagament.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFormOfPagament.Size = new System.Drawing.Size(480, 257);
            this.dgvFormOfPagament.TabIndex = 57;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 91;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Excluir";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 97;
            // 
            // formOfPayment
            // 
            this.formOfPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.formOfPayment.HeaderText = "Forma de Pagamento";
            this.formOfPayment.Name = "formOfPayment";
            this.formOfPayment.ReadOnly = true;
            this.formOfPayment.Width = 230;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.value.DefaultCellStyle = dataGridViewCellStyle6;
            this.value.HeaderText = "Valor";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 83;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(630, 405);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(126, 43);
            this.btnInsert.TabIndex = 58;
            this.btnInsert.TabStop = false;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(775, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 26);
            this.label6.TabIndex = 62;
            this.label6.Text = "Forma de pagamento";
            // 
            // cbFormOfPayement
            // 
            this.cbFormOfPayement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormOfPayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormOfPayement.FormattingEnabled = true;
            this.cbFormOfPayement.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito"});
            this.cbFormOfPayement.Location = new System.Drawing.Point(780, 361);
            this.cbFormOfPayement.Name = "cbFormOfPayement";
            this.cbFormOfPayement.Size = new System.Drawing.Size(330, 34);
            this.cbFormOfPayement.TabIndex = 61;
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(630, 361);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(143, 33);
            this.txtValue.TabIndex = 60;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.Leave += new System.EventHandler(this.txtValue_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(625, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Valor";
            // 
            // FrmSavePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1131, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFormOfPayement);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvFormOfPagament);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ndDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FrmSavePackage";
            this.Text = "FrmSavePackage";
            ((System.ComponentModel.ISupportInitialize)(this.ndDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormOfPagament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown ndDuration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbPercentageInterest;
        private System.Windows.Forms.RadioButton rbValueInterest;
        private System.Windows.Forms.TextBox txtValueInterest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPercentagePenalty;
        private System.Windows.Forms.RadioButton rbValuePenalty;
        private System.Windows.Forms.TextBox txtValuePenalty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFormOfPagament;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn formOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFormOfPayement;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label7;
    }
}