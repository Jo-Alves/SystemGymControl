namespace SystemGynControl
{
    partial class FrmStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnSearchCep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.ndNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pcPhoto = new System.Windows.Forms.PictureBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(22, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(412, 26);
            this.txtName.TabIndex = 3;
            this.txtName.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(22, 200);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(159, 26);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.Text = "000.000.000-00";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.WordWrap = false;
            // 
            // btnSearchCep
            // 
            this.btnSearchCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(168)))), ((int)(((byte)(246)))));
            this.btnSearchCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCep.FlatAppearance.BorderSize = 0;
            this.btnSearchCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSearchCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCep.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCep.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCep.Location = new System.Drawing.Point(149, 277);
            this.btnSearchCep.Name = "btnSearchCep";
            this.btnSearchCep.Size = new System.Drawing.Size(117, 35);
            this.btnSearchCep.TabIndex = 8;
            this.btnSearchCep.Text = "Buscar CEP";
            this.btnSearchCep.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(268, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bairro";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.White;
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistrict.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtDistrict.Location = new System.Drawing.Point(272, 280);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(321, 26);
            this.txtDistrict.TabIndex = 10;
            this.txtDistrict.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logradouro";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(22, 364);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(451, 26);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.WordWrap = false;
            // 
            // ndNumber
            // 
            this.ndNumber.Location = new System.Drawing.Point(479, 361);
            this.ndNumber.Name = "ndNumber";
            this.ndNumber.Size = new System.Drawing.Size(120, 29);
            this.ndNumber.TabIndex = 13;
            this.ndNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(475, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número";
            // 
            // pcPhoto
            // 
            this.pcPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcPhoto.Location = new System.Drawing.Point(463, 12);
            this.pcPhoto.Name = "pcPhoto";
            this.pcPhoto.Size = new System.Drawing.Size(130, 135);
            this.pcPhoto.TabIndex = 15;
            this.pcPhoto.TabStop = false;
            // 
            // dtBirth
            // 
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirth.Location = new System.Drawing.Point(187, 200);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBirth.Size = new System.Drawing.Size(162, 29);
            this.dtBirth.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(183, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Nascimento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(168)))), ((int)(((byte)(246)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(459, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Abrir Imagem";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(18, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cidade";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(22, 448);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(444, 26);
            this.txtCity.TabIndex = 20;
            this.txtCity.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(468, 416);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estado";
            // 
            // cbEstate
            // 
            this.cbEstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstate.FormattingEnabled = true;
            this.cbEstate.Location = new System.Drawing.Point(472, 448);
            this.cbEstate.Name = "cbEstate";
            this.cbEstate.Size = new System.Drawing.Size(121, 30);
            this.cbEstate.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(18, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(22, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 26);
            this.txtId.TabIndex = 24;
            this.txtId.WordWrap = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(168)))), ((int)(((byte)(246)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(22, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 43);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(154, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.Color.Black;
            this.txtCep.Location = new System.Drawing.Point(22, 280);
            this.txtCep.MaxLength = 10;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(121, 26);
            this.txtCep.TabIndex = 28;
            this.txtCep.Text = "00.000-000";
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCep.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "CEP";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(617, 586);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEstate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.pcPhoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ndNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchCep);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            ((System.ComponentModel.ISupportInitialize)(this.ndNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnSearchCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown ndNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcPhoto;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEstate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label3;
    }
}