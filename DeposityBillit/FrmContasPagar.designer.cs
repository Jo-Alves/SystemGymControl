namespace DeposityBillit
{
    partial class FrmContasPagar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnPesquisar = new System.Windows.Forms.TabPage();
            this.dt_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Referente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.txt_ValorDocumento = new System.Windows.Forms.TextBox();
            this.txt_NumeroDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Beneficiario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ReferenteQuitar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Multa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DescontoQuitar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ValorDocumentoQuitar = new System.Windows.Forms.TextBox();
            this.txt_NumeroDocumentoQuitar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_BeneficiarioQuitar = new System.Windows.Forms.TextBox();
            this.mask_VencimentoQuitar = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.btnPesquisar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 386);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.btnPesquisar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPesquisar.Controls.Add(this.dt_Vencimento);
            this.btnPesquisar.Controls.Add(this.txt_Desconto);
            this.btnPesquisar.Controls.Add(this.label8);
            this.btnPesquisar.Controls.Add(this.txt_Referente);
            this.btnPesquisar.Controls.Add(this.label9);
            this.btnPesquisar.Controls.Add(this.btn_Gravar);
            this.btnPesquisar.Controls.Add(this.txt_ValorDocumento);
            this.btnPesquisar.Controls.Add(this.txt_NumeroDocumento);
            this.btnPesquisar.Controls.Add(this.label7);
            this.btnPesquisar.Controls.Add(this.label6);
            this.btnPesquisar.Controls.Add(this.label5);
            this.btnPesquisar.Controls.Add(this.txt_Beneficiario);
            this.btnPesquisar.Controls.Add(this.label3);
            this.btnPesquisar.Location = new System.Drawing.Point(4, 28);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Size = new System.Drawing.Size(591, 350);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Inserir Boletos a pagar";
            // 
            // dt_Vencimento
            // 
            this.dt_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Vencimento.Location = new System.Drawing.Point(201, 254);
            this.dt_Vencimento.Name = "dt_Vencimento";
            this.dt_Vencimento.Size = new System.Drawing.Size(99, 26);
            this.dt_Vencimento.TabIndex = 30;
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Desconto.Location = new System.Drawing.Point(473, 254);
            this.txt_Desconto.MaxLength = 10;
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.Size = new System.Drawing.Size(100, 26);
            this.txt_Desconto.TabIndex = 5;
            this.txt_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Desconto.TextChanged += new System.EventHandler(this.txt_Desconto_TextChanged);
            this.txt_Desconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Desconto_KeyDown);
            this.txt_Desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Desconto_KeyPress);
            this.txt_Desconto.Leave += new System.EventHandler(this.txt_Desconto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Desconto (R$):";
            // 
            // txt_Referente
            // 
            this.txt_Referente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Referente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Referente.Location = new System.Drawing.Point(25, 101);
            this.txt_Referente.MaxLength = 200;
            this.txt_Referente.Multiline = true;
            this.txt_Referente.Name = "txt_Referente";
            this.txt_Referente.Size = new System.Drawing.Size(555, 109);
            this.txt_Referente.TabIndex = 1;
            this.txt_Referente.TextChanged += new System.EventHandler(this.txt_Referente_TextChanged);
            this.txt_Referente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Referente_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Referente:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Gravar.FlatAppearance.BorderSize = 0;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.White;
            this.btn_Gravar.Location = new System.Drawing.Point(470, 293);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(110, 48);
            this.btn_Gravar.TabIndex = 6;
            this.btn_Gravar.Text = "Inserir";
            this.toolTip1.SetToolTip(this.btn_Gravar, "Gravar");
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // txt_ValorDocumento
            // 
            this.txt_ValorDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorDocumento.Location = new System.Drawing.Point(306, 254);
            this.txt_ValorDocumento.MaxLength = 10;
            this.txt_ValorDocumento.Name = "txt_ValorDocumento";
            this.txt_ValorDocumento.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorDocumento.TabIndex = 4;
            this.txt_ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorDocumento.TextChanged += new System.EventHandler(this.txt_ValorDocumento_TextChanged);
            this.txt_ValorDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ValorDocumento_KeyDown);
            this.txt_ValorDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorDocumento_KeyPress);
            this.txt_ValorDocumento.Leave += new System.EventHandler(this.txt_ValorDocumento_Leave);
            // 
            // txt_NumeroDocumento
            // 
            this.txt_NumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumeroDocumento.Location = new System.Drawing.Point(25, 254);
            this.txt_NumeroDocumento.Name = "txt_NumeroDocumento";
            this.txt_NumeroDocumento.Size = new System.Drawing.Size(141, 26);
            this.txt_NumeroDocumento.TabIndex = 2;
            this.txt_NumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NumeroDocumento.TextChanged += new System.EventHandler(this.txt_NumeroDocumento_TextChanged);
            this.txt_NumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroDocumento_KeyDown);
            this.txt_NumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroDocumento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor do documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número do documento:";
            // 
            // txt_Beneficiario
            // 
            this.txt_Beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Beneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Beneficiario.Location = new System.Drawing.Point(25, 38);
            this.txt_Beneficiario.MaxLength = 100;
            this.txt_Beneficiario.Name = "txt_Beneficiario";
            this.txt_Beneficiario.Size = new System.Drawing.Size(555, 26);
            this.txt_Beneficiario.TabIndex = 0;
            this.txt_Beneficiario.TextChanged += new System.EventHandler(this.txt_Beneficiario_TextChanged);
            this.txt_Beneficiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Beneficiario_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Beneficiário:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(591, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Boletos a vencer ou vencidos";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 32;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.recipient,
            this.refering,
            this.number,
            this.duedate,
            this.value,
            this.discount});
            this.dgv.Location = new System.Drawing.Point(4, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(578, 318);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.btn_Quitar);
            this.tabPage3.Controls.Add(this.txt_ValorPago);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txt_ReferenteQuitar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_Multa);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_DescontoQuitar);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txt_ValorDocumentoQuitar);
            this.tabPage3.Controls.Add(this.txt_NumeroDocumentoQuitar);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txt_BeneficiarioQuitar);
            this.tabPage3.Controls.Add(this.mask_VencimentoQuitar);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(591, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quitar Boletos";
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Quitar.FlatAppearance.BorderSize = 0;
            this.btn_Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quitar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitar.ForeColor = System.Drawing.Color.White;
            this.btn_Quitar.Location = new System.Drawing.Point(469, 291);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(110, 50);
            this.btn_Quitar.TabIndex = 35;
            this.btn_Quitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btn_Quitar, "Gravar");
            this.btn_Quitar.UseVisualStyleBackColor = false;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorPago.Location = new System.Drawing.Point(153, 294);
            this.txt_ValorPago.MaxLength = 10;
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorPago.TabIndex = 7;
            this.txt_ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorPago.TextChanged += new System.EventHandler(this.txt_ValorPago_TextChanged);
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            this.txt_ValorPago.Leave += new System.EventHandler(this.txt_ValorPago_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor Pago:";
            // 
            // txt_ReferenteQuitar
            // 
            this.txt_ReferenteQuitar.BackColor = System.Drawing.Color.White;
            this.txt_ReferenteQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReferenteQuitar.Location = new System.Drawing.Point(10, 94);
            this.txt_ReferenteQuitar.Multiline = true;
            this.txt_ReferenteQuitar.Name = "txt_ReferenteQuitar";
            this.txt_ReferenteQuitar.ReadOnly = true;
            this.txt_ReferenteQuitar.Size = new System.Drawing.Size(566, 92);
            this.txt_ReferenteQuitar.TabIndex = 1;
            this.txt_ReferenteQuitar.TextChanged += new System.EventHandler(this.txt_ReferenteQuitar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Referente:";
            // 
            // txt_Multa
            // 
            this.txt_Multa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Multa.Location = new System.Drawing.Point(10, 294);
            this.txt_Multa.MaxLength = 10;
            this.txt_Multa.Name = "txt_Multa";
            this.txt_Multa.Size = new System.Drawing.Size(100, 26);
            this.txt_Multa.TabIndex = 6;
            this.txt_Multa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Multa.TextChanged += new System.EventHandler(this.txt_Multa_TextChanged);
            this.txt_Multa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Multa_KeyPress);
            this.txt_Multa.Leave += new System.EventHandler(this.txt_Multa_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Multa:";
            // 
            // txt_DescontoQuitar
            // 
            this.txt_DescontoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_DescontoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DescontoQuitar.Location = new System.Drawing.Point(469, 229);
            this.txt_DescontoQuitar.Name = "txt_DescontoQuitar";
            this.txt_DescontoQuitar.ReadOnly = true;
            this.txt_DescontoQuitar.Size = new System.Drawing.Size(100, 26);
            this.txt_DescontoQuitar.TabIndex = 5;
            this.txt_DescontoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DescontoQuitar.TextChanged += new System.EventHandler(this.txt_DescontoQuitar_TextChanged);
            this.txt_DescontoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescontoQuitar_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(465, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Desconto (R$):";
            // 
            // txt_ValorDocumentoQuitar
            // 
            this.txt_ValorDocumentoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_ValorDocumentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorDocumentoQuitar.Location = new System.Drawing.Point(297, 229);
            this.txt_ValorDocumentoQuitar.Name = "txt_ValorDocumentoQuitar";
            this.txt_ValorDocumentoQuitar.ReadOnly = true;
            this.txt_ValorDocumentoQuitar.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorDocumentoQuitar.TabIndex = 4;
            this.txt_ValorDocumentoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorDocumentoQuitar.TextChanged += new System.EventHandler(this.txt_ValorDocumentoQuitar_TextChanged);
            this.txt_ValorDocumentoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorDocumentoQuitar_KeyPress);
            // 
            // txt_NumeroDocumentoQuitar
            // 
            this.txt_NumeroDocumentoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_NumeroDocumentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumeroDocumentoQuitar.Location = new System.Drawing.Point(10, 229);
            this.txt_NumeroDocumentoQuitar.Name = "txt_NumeroDocumentoQuitar";
            this.txt_NumeroDocumentoQuitar.ReadOnly = true;
            this.txt_NumeroDocumentoQuitar.Size = new System.Drawing.Size(141, 26);
            this.txt_NumeroDocumentoQuitar.TabIndex = 2;
            this.txt_NumeroDocumentoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NumeroDocumentoQuitar.TextChanged += new System.EventHandler(this.txt_NumeroDocumentoQuitar_TextChanged);
            this.txt_NumeroDocumentoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroDocumentoQuitar_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Vencimento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(293, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Valor do documento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Número do documento:";
            // 
            // txt_BeneficiarioQuitar
            // 
            this.txt_BeneficiarioQuitar.BackColor = System.Drawing.Color.White;
            this.txt_BeneficiarioQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BeneficiarioQuitar.Location = new System.Drawing.Point(10, 30);
            this.txt_BeneficiarioQuitar.Name = "txt_BeneficiarioQuitar";
            this.txt_BeneficiarioQuitar.ReadOnly = true;
            this.txt_BeneficiarioQuitar.Size = new System.Drawing.Size(566, 26);
            this.txt_BeneficiarioQuitar.TabIndex = 0;
            this.txt_BeneficiarioQuitar.TextChanged += new System.EventHandler(this.txt_BeneficiarioQuitar_TextChanged);
            // 
            // mask_VencimentoQuitar
            // 
            this.mask_VencimentoQuitar.BackColor = System.Drawing.Color.White;
            this.mask_VencimentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_VencimentoQuitar.Location = new System.Drawing.Point(185, 229);
            this.mask_VencimentoQuitar.Mask = "00/00/0000";
            this.mask_VencimentoQuitar.Name = "mask_VencimentoQuitar";
            this.mask_VencimentoQuitar.ReadOnly = true;
            this.mask_VencimentoQuitar.Size = new System.Drawing.Size(90, 26);
            this.mask_VencimentoQuitar.TabIndex = 3;
            this.mask_VencimentoQuitar.ValidatingType = typeof(System.DateTime);
            this.mask_VencimentoQuitar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_VencimentoQuitar_MaskInputRejected);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 19);
            this.label16.TabIndex = 18;
            this.label16.Text = "Beneficiário:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // recipient
            // 
            this.recipient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recipient.DataPropertyName = "recipient";
            this.recipient.HeaderText = "Destinatário";
            this.recipient.Name = "recipient";
            this.recipient.ReadOnly = true;
            this.recipient.Width = 106;
            // 
            // refering
            // 
            this.refering.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.refering.DataPropertyName = "refering";
            this.refering.HeaderText = "Referência";
            this.refering.Name = "refering";
            this.refering.ReadOnly = true;
            this.refering.Width = 98;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.DataPropertyName = "document_number";
            this.number.HeaderText = "Número do documento";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 175;
            // 
            // duedate
            // 
            this.duedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duedate.DataPropertyName = "due_date";
            this.duedate.HeaderText = "Vencimento";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            this.duedate.Width = 104;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.value.DataPropertyName = "document_value";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.value.DefaultCellStyle = dataGridViewCellStyle2;
            this.value.HeaderText = "Valor do documento";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 157;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.discount.DataPropertyName = "discount";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.discount.DefaultCellStyle = dataGridViewCellStyle3;
            this.discount.HeaderText = "Desconto";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 92;
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 386);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.FrmContasPagar_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.btnPesquisar.ResumeLayout(false);
            this.btnPesquisar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage btnPesquisar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_ValorDocumento;
        private System.Windows.Forms.TextBox txt_NumeroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Beneficiario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox txt_Referente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_ReferenteQuitar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Multa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_DescontoQuitar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ValorDocumentoQuitar;
        private System.Windows.Forms.TextBox txt_NumeroDocumentoQuitar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_BeneficiarioQuitar;
        private System.Windows.Forms.MaskedTextBox mask_VencimentoQuitar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dt_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn refering;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
    }
}