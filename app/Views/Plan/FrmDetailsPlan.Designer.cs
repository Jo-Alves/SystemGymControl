
namespace SystemGymControl
{
    partial class FrmDetailsPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.linkMoreDetails = new System.Windows.Forms.LinkLabel();
            this.pnMoreDetailsStudent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDateDeactive = new System.Windows.Forms.TextBox();
            this.lblDateDeactive = new System.Windows.Forms.Label();
            this.txtDateTerminalPlan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnObservation = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbExpired = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimePurchasePlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatePurchasePlan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.pcPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFormOfPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModality = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnMoreDetailsStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnObservation.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcPhoto);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.linkMoreDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 190);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::SystemGymControl.Properties.Resources.icons8_back_arrow_32px;
            this.btnBack.Location = new System.Drawing.Point(24, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 60;
            this.btnBack.TabStop = false;
            this.metroToolTip.SetToolTip(this.btnBack, "Voltar para a janela anterior");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtBirth);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.lblBirth);
            this.groupBox2.Controls.Add(this.lblCPF);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 120);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados iniciais";
            // 
            // txtBirth
            // 
            this.txtBirth.BackColor = System.Drawing.Color.White;
            this.txtBirth.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirth.Location = new System.Drawing.Point(312, 62);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.ReadOnly = true;
            this.txtBirth.Size = new System.Drawing.Size(115, 33);
            this.txtBirth.TabIndex = 91;
            this.txtBirth.TabStop = false;
            this.txtBirth.Text = "00/00/0000";
            this.txtBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(77, 62);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(156, 33);
            this.txtCPF.TabIndex = 90;
            this.txtCPF.TabStop = false;
            this.txtCPF.Text = "000.000.000-00";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(78, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(153, 33);
            this.txtId.TabIndex = 58;
            this.txtId.TabStop = false;
            this.txtId.WordWrap = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(2, 28);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 22);
            this.lblId.TabIndex = 65;
            this.lblId.Text = "Código";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.ForeColor = System.Drawing.Color.Black;
            this.lblBirth.Location = new System.Drawing.Point(233, 68);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(73, 22);
            this.lblBirth.TabIndex = 64;
            this.lblBirth.Text = "Data N.";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(29, 68);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 22);
            this.lblCPF.TabIndex = 63;
            this.lblCPF.Text = "CPF";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(311, 23);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(337, 33);
            this.txtName.TabIndex = 59;
            this.txtName.TabStop = false;
            this.txtName.WordWrap = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(246, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 22);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "Nome";
            // 
            // linkMoreDetails
            // 
            this.linkMoreDetails.AutoSize = true;
            this.linkMoreDetails.Location = new System.Drawing.Point(20, 163);
            this.linkMoreDetails.Name = "linkMoreDetails";
            this.linkMoreDetails.Size = new System.Drawing.Size(116, 22);
            this.linkMoreDetails.TabIndex = 58;
            this.linkMoreDetails.TabStop = true;
            this.linkMoreDetails.Text = "Mais Detalhes";
            this.linkMoreDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMoreDetails_Click);
            // 
            // pnMoreDetailsStudent
            // 
            this.pnMoreDetailsStudent.Controls.Add(this.groupBox1);
            this.pnMoreDetailsStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMoreDetailsStudent.Location = new System.Drawing.Point(0, 190);
            this.pnMoreDetailsStudent.Name = "pnMoreDetailsStudent";
            this.pnMoreDetailsStudent.Size = new System.Drawing.Size(817, 241);
            this.pnMoreDetailsStudent.TabIndex = 1;
            this.pnMoreDetailsStudent.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.lblDistrict);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço do aluno";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(304, 136);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(111, 33);
            this.txtState.TabIndex = 94;
            this.txtState.TabStop = false;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.White;
            this.txtNumber.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(118, 136);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(111, 33);
            this.txtNumber.TabIndex = 93;
            this.txtNumber.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(512, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(162, 33);
            this.txtPhone.TabIndex = 92;
            this.txtPhone.TabStop = false;
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.White;
            this.txtCEP.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(47, 19);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.ReadOnly = true;
            this.txtCEP.Size = new System.Drawing.Size(121, 33);
            this.txtCEP.TabIndex = 91;
            this.txtCEP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(118, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(648, 33);
            this.txtEmail.TabIndex = 81;
            this.txtEmail.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(422, 142);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 22);
            this.lblPhone.TabIndex = 88;
            this.lblPhone.Text = "Telefone";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Black;
            this.lblCEP.Location = new System.Drawing.Point(2, 25);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 22);
            this.lblCEP.TabIndex = 87;
            this.lblCEP.Text = "CEP";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(236, 142);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 22);
            this.lblState.TabIndex = 86;
            this.lblState.Text = "Estado";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(120, 97);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(646, 33);
            this.txtCity.TabIndex = 78;
            this.txtCity.TabStop = false;
            this.txtCity.WordWrap = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(45, 102);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(68, 22);
            this.lblCity.TabIndex = 85;
            this.lblCity.Text = "Cidade";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(31, 142);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(79, 22);
            this.lblNumber.TabIndex = 84;
            this.lblNumber.Text = "Número";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(120, 58);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(646, 33);
            this.txtAddress.TabIndex = 76;
            this.txtAddress.TabStop = false;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(3, 63);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(110, 22);
            this.lblAddress.TabIndex = 83;
            this.lblAddress.Text = "Logradouro";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistrict.BackColor = System.Drawing.Color.White;
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrict.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtDistrict.Location = new System.Drawing.Point(244, 20);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.ReadOnly = true;
            this.txtDistrict.Size = new System.Drawing.Size(522, 33);
            this.txtDistrict.TabIndex = 75;
            this.txtDistrict.TabStop = false;
            this.txtDistrict.WordWrap = false;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.Black;
            this.lblDistrict.Location = new System.Drawing.Point(175, 25);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(63, 22);
            this.lblDistrict.TabIndex = 82;
            this.lblDistrict.Text = "Bairro";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 320);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtFormOfPayment);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtModality);
            this.groupBox3.Controls.Add(this.txtDateDeactive);
            this.groupBox3.Controls.Add(this.lblDateDeactive);
            this.groupBox3.Controls.Add(this.txtDateTerminalPlan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtPackage);
            this.groupBox3.Controls.Add(this.txtValue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTimePurchasePlan);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDatePurchasePlan);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 308);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plano";
            // 
            // txtDateDeactive
            // 
            this.txtDateDeactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateDeactive.BackColor = System.Drawing.Color.White;
            this.txtDateDeactive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateDeactive.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateDeactive.ForeColor = System.Drawing.Color.Black;
            this.txtDateDeactive.Location = new System.Drawing.Point(630, 113);
            this.txtDateDeactive.Name = "txtDateDeactive";
            this.txtDateDeactive.ReadOnly = true;
            this.txtDateDeactive.Size = new System.Drawing.Size(139, 33);
            this.txtDateDeactive.TabIndex = 81;
            this.txtDateDeactive.TabStop = false;
            this.txtDateDeactive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateDeactive.Visible = false;
            this.txtDateDeactive.WordWrap = false;
            // 
            // lblDateDeactive
            // 
            this.lblDateDeactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDeactive.AutoSize = true;
            this.lblDateDeactive.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeactive.ForeColor = System.Drawing.Color.Black;
            this.lblDateDeactive.Location = new System.Drawing.Point(626, 87);
            this.lblDateDeactive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDeactive.Name = "lblDateDeactive";
            this.lblDateDeactive.Size = new System.Drawing.Size(132, 22);
            this.lblDateDeactive.TabIndex = 82;
            this.lblDateDeactive.Text = "Data da pausa";
            this.lblDateDeactive.Visible = false;
            // 
            // txtDateTerminalPlan
            // 
            this.txtDateTerminalPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTerminalPlan.BackColor = System.Drawing.Color.White;
            this.txtDateTerminalPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTerminalPlan.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTerminalPlan.ForeColor = System.Drawing.Color.Black;
            this.txtDateTerminalPlan.Location = new System.Drawing.Point(630, 51);
            this.txtDateTerminalPlan.Name = "txtDateTerminalPlan";
            this.txtDateTerminalPlan.ReadOnly = true;
            this.txtDateTerminalPlan.Size = new System.Drawing.Size(139, 33);
            this.txtDateTerminalPlan.TabIndex = 79;
            this.txtDateTerminalPlan.TabStop = false;
            this.txtDateTerminalPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateTerminalPlan.WordWrap = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(626, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 22);
            this.label9.TabIndex = 80;
            this.label9.Text = "Término do plano";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.pnObservation);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Location = new System.Drawing.Point(14, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 141);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Situação";
            // 
            // pnObservation
            // 
            this.pnObservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnObservation.Controls.Add(this.label8);
            this.pnObservation.Controls.Add(this.txtObservation);
            this.pnObservation.Location = new System.Drawing.Point(300, 22);
            this.pnObservation.Name = "pnObservation";
            this.pnObservation.Size = new System.Drawing.Size(473, 109);
            this.pnObservation.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 85;
            this.label8.Text = "Observação";
            // 
            // txtObservation
            // 
            this.txtObservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservation.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(15, 28);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(449, 78);
            this.txtObservation.TabIndex = 84;
            this.txtObservation.TextChanged += new System.EventHandler(this.txtObservation_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbExpired);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.rbActive);
            this.panel4.Controls.Add(this.rbInactive);
            this.panel4.Location = new System.Drawing.Point(19, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 109);
            this.panel4.TabIndex = 0;
            // 
            // rbExpired
            // 
            this.rbExpired.AutoSize = true;
            this.rbExpired.Enabled = false;
            this.rbExpired.Location = new System.Drawing.Point(172, 15);
            this.rbExpired.Name = "rbExpired";
            this.rbExpired.Size = new System.Drawing.Size(103, 26);
            this.rbExpired.TabIndex = 84;
            this.rbExpired.TabStop = true;
            this.rbExpired.Text = "Expirado";
            this.rbExpired.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(58, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 43);
            this.btnSave.TabIndex = 83;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(11, 15);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(71, 26);
            this.rbActive.TabIndex = 80;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Ativo";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(83, 15);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(86, 26);
            this.rbInactive.TabIndex = 81;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inativo";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackage.BackColor = System.Drawing.Color.White;
            this.txtPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackage.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackage.ForeColor = System.Drawing.Color.Black;
            this.txtPackage.Location = new System.Drawing.Point(308, 51);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.ReadOnly = true;
            this.txtPackage.Size = new System.Drawing.Size(186, 33);
            this.txtPackage.TabIndex = 76;
            this.txtPackage.TabStop = false;
            this.txtPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPackage.WordWrap = false;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Location = new System.Drawing.Point(500, 51);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(124, 33);
            this.txtValue.TabIndex = 72;
            this.txtValue.TabStop = false;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(496, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(304, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Pacote";
            // 
            // txtTimePurchasePlan
            // 
            this.txtTimePurchasePlan.BackColor = System.Drawing.Color.White;
            this.txtTimePurchasePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimePurchasePlan.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePurchasePlan.ForeColor = System.Drawing.Color.Black;
            this.txtTimePurchasePlan.Location = new System.Drawing.Point(163, 51);
            this.txtTimePurchasePlan.Name = "txtTimePurchasePlan";
            this.txtTimePurchasePlan.ReadOnly = true;
            this.txtTimePurchasePlan.Size = new System.Drawing.Size(139, 33);
            this.txtTimePurchasePlan.TabIndex = 68;
            this.txtTimePurchasePlan.TabStop = false;
            this.txtTimePurchasePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimePurchasePlan.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Hora do plano";
            // 
            // txtDatePurchasePlan
            // 
            this.txtDatePurchasePlan.BackColor = System.Drawing.Color.White;
            this.txtDatePurchasePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatePurchasePlan.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatePurchasePlan.ForeColor = System.Drawing.Color.Black;
            this.txtDatePurchasePlan.Location = new System.Drawing.Point(18, 51);
            this.txtDatePurchasePlan.Name = "txtDatePurchasePlan";
            this.txtDatePurchasePlan.ReadOnly = true;
            this.txtDatePurchasePlan.Size = new System.Drawing.Size(139, 33);
            this.txtDatePurchasePlan.TabIndex = 66;
            this.txtDatePurchasePlan.TabStop = false;
            this.txtDatePurchasePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDatePurchasePlan.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Data do plano";
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pcPhoto
            // 
            this.pcPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcPhoto.Location = new System.Drawing.Point(674, 50);
            this.pcPhoto.Name = "pcPhoto";
            this.pcPhoto.Size = new System.Drawing.Size(114, 110);
            this.pcPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPhoto.TabIndex = 67;
            this.pcPhoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(200, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 86;
            this.label7.Text = "Modalidade";
            // 
            // txtFormOfPayment
            // 
            this.txtFormOfPayment.BackColor = System.Drawing.Color.White;
            this.txtFormOfPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormOfPayment.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormOfPayment.ForeColor = System.Drawing.Color.Black;
            this.txtFormOfPayment.Location = new System.Drawing.Point(21, 113);
            this.txtFormOfPayment.Name = "txtFormOfPayment";
            this.txtFormOfPayment.ReadOnly = true;
            this.txtFormOfPayment.Size = new System.Drawing.Size(172, 33);
            this.txtFormOfPayment.TabIndex = 84;
            this.txtFormOfPayment.TabStop = false;
            this.txtFormOfPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFormOfPayment.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 85;
            this.label6.Text = "F/ de pagamento";
            // 
            // txtModality
            // 
            this.txtModality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModality.BackColor = System.Drawing.Color.White;
            this.txtModality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModality.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModality.ForeColor = System.Drawing.Color.Black;
            this.txtModality.Location = new System.Drawing.Point(199, 113);
            this.txtModality.Name = "txtModality";
            this.txtModality.ReadOnly = true;
            this.txtModality.Size = new System.Drawing.Size(420, 33);
            this.txtModality.TabIndex = 83;
            this.txtModality.TabStop = false;
            this.txtModality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModality.WordWrap = false;
            // 
            // FrmDetailsPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 773);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnMoreDetailsStudent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmDetailsPlan";
            this.Text = "FrmDetailsPlan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDetailsPlan_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnMoreDetailsStudent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.pnObservation.ResumeLayout(false);
            this.pnObservation.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMoreDetailsStudent;
        private System.Windows.Forms.LinkLabel linkMoreDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimePurchasePlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatePurchasePlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnObservation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDateTerminalPlan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDateDeactive;
        private System.Windows.Forms.Label lblDateDeactive;
        private System.Windows.Forms.RadioButton rbExpired;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.PictureBox pcPhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFormOfPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModality;
    }
}