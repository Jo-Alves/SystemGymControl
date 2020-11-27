namespace SystemGymControl
{
    partial class UsSaveStudent
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ndNumber = new System.Windows.Forms.NumericUpDown();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.btnSearchCep = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mkCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkPhone = new System.Windows.Forms.MaskedTextBox();
            this.mkCEP = new System.Windows.Forms.MaskedTextBox();
            this.pcPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Black;
            this.lblCEP.Location = new System.Drawing.Point(18, 230);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 22);
            this.lblCEP.TabIndex = 52;
            this.lblCEP.Text = "CEP";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(154, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 51;
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
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(22, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 50;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(22, 56);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(112, 33);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.WordWrap = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(18, 30);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 22);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "Código";
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbState.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RR",
            "RO",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbState.Location = new System.Drawing.Point(460, 390);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(111, 34);
            this.cbState.TabIndex = 10;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(456, 363);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 22);
            this.lblState.TabIndex = 46;
            this.lblState.Text = "Estado";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(22, 389);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(427, 33);
            this.txtCity.TabIndex = 9;
            this.txtCity.WordWrap = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(18, 363);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(68, 22);
            this.lblCity.TabIndex = 44;
            this.lblCity.Text = "Cidade";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImage.FlatAppearance.BorderSize = 0;
            this.btnOpenImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.ForeColor = System.Drawing.Color.White;
            this.btnOpenImage.Location = new System.Drawing.Point(426, 165);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(140, 33);
            this.btnOpenImage.TabIndex = 43;
            this.btnOpenImage.TabStop = false;
            this.btnOpenImage.Text = "Abrir Imagem";
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.ForeColor = System.Drawing.Color.Black;
            this.lblBirth.Location = new System.Drawing.Point(183, 161);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(156, 22);
            this.lblBirth.TabIndex = 42;
            this.lblBirth.Text = "Data Nascimento";
            // 
            // dtBirth
            // 
            this.dtBirth.CalendarFont = new System.Drawing.Font("Open Sans", 14F);
            this.dtBirth.Font = new System.Drawing.Font("Open Sans", 14F);
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirth.Location = new System.Drawing.Point(187, 187);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBirth.Size = new System.Drawing.Size(162, 33);
            this.dtBirth.TabIndex = 3;
            this.dtBirth.ValueChanged += new System.EventHandler(this.dtBirth_ValueChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(458, 297);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(79, 22);
            this.lblNumber.TabIndex = 39;
            this.lblNumber.Text = "Número";
            // 
            // ndNumber
            // 
            this.ndNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ndNumber.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndNumber.Location = new System.Drawing.Point(462, 323);
            this.ndNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndNumber.Name = "ndNumber";
            this.ndNumber.Size = new System.Drawing.Size(104, 33);
            this.ndNumber.TabIndex = 8;
            this.ndNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(22, 323);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(427, 33);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(18, 297);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(110, 22);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Logradouro";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.White;
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrict.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtDistrict.Location = new System.Drawing.Point(272, 255);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(294, 33);
            this.txtDistrict.TabIndex = 5;
            this.txtDistrict.WordWrap = false;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.Black;
            this.lblDistrict.Location = new System.Drawing.Point(268, 229);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(63, 22);
            this.lblDistrict.TabIndex = 34;
            this.lblDistrict.Text = "Bairro";
            // 
            // btnSearchCep
            // 
            this.btnSearchCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSearchCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCep.FlatAppearance.BorderSize = 0;
            this.btnSearchCep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSearchCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCep.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchCep.ForeColor = System.Drawing.Color.White;
            this.btnSearchCep.Location = new System.Drawing.Point(149, 254);
            this.btnSearchCep.Name = "btnSearchCep";
            this.btnSearchCep.Size = new System.Drawing.Size(117, 35);
            this.btnSearchCep.TabIndex = 4;
            this.btnSearchCep.TabStop = false;
            this.btnSearchCep.Text = "Buscar CEP";
            this.btnSearchCep.UseVisualStyleBackColor = false;
            this.btnSearchCep.Click += new System.EventHandler(this.btnSearchCep_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(18, 161);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 22);
            this.lblCPF.TabIndex = 31;
            this.lblCPF.Text = "CPF";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(22, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 33);
            this.txtName.TabIndex = 1;
            this.txtName.WordWrap = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(18, 93);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 22);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Nome";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(18, 430);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 22);
            this.lblPhone.TabIndex = 54;
            this.lblPhone.Text = "Telefone";
            // 
            // mkCPF
            // 
            this.mkCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkCPF.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPF.Location = new System.Drawing.Point(22, 187);
            this.mkCPF.Mask = "000,000,000-00";
            this.mkCPF.Name = "mkCPF";
            this.mkCPF.Size = new System.Drawing.Size(159, 33);
            this.mkCPF.TabIndex = 2;
            this.mkCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkPhone
            // 
            this.mkPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkPhone.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPhone.Location = new System.Drawing.Point(22, 456);
            this.mkPhone.Mask = "(99) 99999-9999";
            this.mkPhone.Name = "mkPhone";
            this.mkPhone.Size = new System.Drawing.Size(159, 33);
            this.mkPhone.TabIndex = 11;
            this.mkPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkCEP
            // 
            this.mkCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkCEP.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCEP.Location = new System.Drawing.Point(22, 255);
            this.mkCEP.Mask = "00,000-000";
            this.mkCEP.Name = "mkCEP";
            this.mkCEP.Size = new System.Drawing.Size(121, 33);
            this.mkCEP.TabIndex = 4;
            this.mkCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mkCEP_KeyUp);
            // 
            // pcPhoto
            // 
            this.pcPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcPhoto.Location = new System.Drawing.Point(430, 24);
            this.pcPhoto.Name = "pcPhoto";
            this.pcPhoto.Size = new System.Drawing.Size(130, 135);
            this.pcPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPhoto.TabIndex = 40;
            this.pcPhoto.TabStop = false;
            // 
            // UsSaveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.mkCEP);
            this.Controls.Add(this.mkPhone);
            this.Controls.Add(this.mkCPF);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.pcPhoto);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.ndNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.btnSearchCep);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsSaveStudent";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Size = new System.Drawing.Size(617, 570);
            this.ClientSizeChanged += new System.EventHandler(this.usSaveStudent_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ndNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.PictureBox pcPhoto;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.NumericUpDown ndNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Button btnSearchCep;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mkCPF;
        private System.Windows.Forms.MaskedTextBox mkPhone;
        private System.Windows.Forms.MaskedTextBox mkCEP;
    }
}
