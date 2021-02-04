namespace SystemGymControl
{
    partial class FrmSearchStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchStudent));
            this.dgvDataStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kinship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.pcStudent = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataStudent
            // 
            this.dgvDataStudent.AllowUserToAddRows = false;
            this.dgvDataStudent.AllowUserToDeleteRows = false;
            this.dgvDataStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDataStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataStudent.ColumnHeadersHeight = 35;
            this.dgvDataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.CPF,
            this.birth,
            this.phone,
            this.email,
            this.CEP,
            this.district,
            this.address,
            this.number,
            this.city,
            this.state,
            this.responsible,
            this.cpfResponsible,
            this.kinship,
            this.phoneResponsible});
            this.dgvDataStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDataStudent.EnableHeadersVisualStyles = false;
            this.dgvDataStudent.Location = new System.Drawing.Point(12, 194);
            this.dgvDataStudent.MultiSelect = false;
            this.dgvDataStudent.Name = "dgvDataStudent";
            this.dgvDataStudent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataStudent.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvDataStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataStudent.Size = new System.Drawing.Size(793, 419);
            this.dgvDataStudent.TabIndex = 6;
            this.dgvDataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataStudent_CellClick);
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
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 62;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CPF.Width = 44;
            // 
            // birth
            // 
            this.birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birth.HeaderText = "Data de Nascimento";
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.birth.Width = 170;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.HeaderText = "Telefone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.phone.Width = 81;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.email.Width = 57;
            // 
            // CEP
            // 
            this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CEP.Width = 45;
            // 
            // district
            // 
            this.district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.district.HeaderText = "Bairro";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.district.Width = 63;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.HeaderText = "Endereço";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.address.Width = 88;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.HeaderText = "Número";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 79;
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.city.HeaderText = "Cidade";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.city.Width = 68;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.state.Width = 68;
            // 
            // responsible
            // 
            this.responsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsible.HeaderText = "Responsável";
            this.responsible.Name = "responsible";
            this.responsible.ReadOnly = true;
            this.responsible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.responsible.Width = 111;
            // 
            // cpfResponsible
            // 
            this.cpfResponsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpfResponsible.HeaderText = "CPF";
            this.cpfResponsible.Name = "cpfResponsible";
            this.cpfResponsible.ReadOnly = true;
            this.cpfResponsible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cpfResponsible.Width = 44;
            // 
            // kinship
            // 
            this.kinship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kinship.HeaderText = "Grau de Parentesco";
            this.kinship.Name = "kinship";
            this.kinship.ReadOnly = true;
            this.kinship.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kinship.Width = 167;
            // 
            // phoneResponsible
            // 
            this.phoneResponsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneResponsible.HeaderText = "phone";
            this.phoneResponsible.Name = "phoneResponsible";
            this.phoneResponsible.ReadOnly = true;
            this.phoneResponsible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.phoneResponsible.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchName.BackColor = System.Drawing.Color.White;
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtSearchName.Location = new System.Drawing.Point(109, 37);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(556, 33);
            this.txtSearchName.TabIndex = 9;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(18, 83);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(59, 22);
            this.lblStudent.TabIndex = 9;
            this.lblStudent.Text = "Aluno";
            // 
            // pcStudent
            // 
            this.pcStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pcStudent.Image = global::SystemGymControl.Properties.Resources.icons8_client_management_64px_1;
            this.pcStudent.Location = new System.Drawing.Point(12, 12);
            this.pcStudent.Name = "pcStudent";
            this.pcStudent.Size = new System.Drawing.Size(64, 64);
            this.pcStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcStudent.TabIndex = 8;
            this.pcStudent.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemGymControl.Properties.Resources.icons8_close_window_32px_leavee;
            this.btnClose.Location = new System.Drawing.Point(784, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // FrmSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(817, 625);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.pcStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDataStudent);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSearchStudent_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDataStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.PictureBox pcStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfResponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn kinship;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneResponsible;
    }
}
