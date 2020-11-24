namespace SystemGynControl
{
    partial class FrmClass
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
            this.dgvDateStudent = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDateStudent
            // 
            this.dgvDateStudent.AllowUserToAddRows = false;
            this.dgvDateStudent.AllowUserToDeleteRows = false;
            this.dgvDateStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDateStudent.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(168)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDateStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDateStudent.ColumnHeadersHeight = 30;
            this.dgvDateStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDateStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.CPF,
            this.birth,
            this.CEP,
            this.district,
            this.address,
            this.number,
            this.city,
            this.state,
            this.photo,
            this.edit,
            this.delete});
            this.dgvDateStudent.EnableHeadersVisualStyles = false;
            this.dgvDateStudent.Location = new System.Drawing.Point(12, 109);
            this.dgvDateStudent.Name = "dgvDateStudent";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDateStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDateStudent.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.dgvDateStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDateStudent.Size = new System.Drawing.Size(593, 358);
            this.dgvDateStudent.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(168)))), ((int)(((byte)(246)))));
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(12, 32);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(168, 42);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Novo";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 94;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 85;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 66;
            // 
            // birth
            // 
            this.birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birth.HeaderText = "Data de Nascimento";
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.Width = 207;
            // 
            // CEP
            // 
            this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 67;
            // 
            // district
            // 
            this.district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.district.HeaderText = "Bairro";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Width = 88;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.HeaderText = "Endereço";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 115;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.HeaderText = "Número";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 104;
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.city.HeaderText = "Cidade";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 93;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 93;
            // 
            // photo
            // 
            this.photo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photo.HeaderText = "Foto";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.photo.Width = 73;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 86;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Excluir";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 92;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(617, 479);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dgvDateStudent);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClass";
            this.Text = "FrmClass";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}