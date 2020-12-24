
namespace SystemGymControl
{
    partial class FrmPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlan));
            this.dgvDataPlan = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.pcPlan = new System.Windows.Forms.PictureBox();
            this.btnPlan = new System.Windows.Forms.Button();
            this.showDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.renewPlan = new System.Windows.Forms.DataGridViewImageColumn();
            this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemsPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituationPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionModality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionformOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchasePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePurchasePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTerminalPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTerminalPlanLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInactivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deactivationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataPlan
            // 
            this.dgvDataPlan.AllowUserToAddRows = false;
            this.dgvDataPlan.AllowUserToDeleteRows = false;
            this.dgvDataPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataPlan.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataPlan.ColumnHeadersHeight = 30;
            this.dgvDataPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showDetails,
            this.renewPlan,
            this.idStudent,
            this.idPlan,
            this.idModality,
            this.idItemsPackage,
            this.idPackage,
            this.idFormOfPayment,
            this.idSituationPlan,
            this.name,
            this.descriptionModality,
            this.valuePlan,
            this.descriptionformOfPayment,
            this.descriptionPackage,
            this.datePurchasePlan,
            this.timePurchasePlan,
            this.dateTerminalPlan,
            this.dateTerminalPlanLast,
            this.situation,
            this.timeInactivated,
            this.deactivationDate});
            this.dgvDataPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataPlan.EnableHeadersVisualStyles = false;
            this.dgvDataPlan.Location = new System.Drawing.Point(28, 215);
            this.dgvDataPlan.MultiSelect = false;
            this.dgvDataPlan.Name = "dgvDataPlan";
            this.dgvDataPlan.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataPlan.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvDataPlan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataPlan.Size = new System.Drawing.Size(987, 218);
            this.dgvDataPlan.TabIndex = 17;
            this.dgvDataPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellClick);
            this.dgvDataPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtSearch.Location = new System.Drawing.Point(133, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(693, 33);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 65);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlan.ForeColor = System.Drawing.Color.Black;
            this.lblPlan.Location = new System.Drawing.Point(34, 99);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(58, 22);
            this.lblPlan.TabIndex = 25;
            this.lblPlan.Text = "Plano";
            // 
            // pcPlan
            // 
            this.pcPlan.Image = global::SystemGymControl.Properties.Resources.icons8_floor_plan_64px;
            this.pcPlan.Location = new System.Drawing.Point(28, 25);
            this.pcPlan.Name = "pcPlan";
            this.pcPlan.Size = new System.Drawing.Size(64, 64);
            this.pcPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPlan.TabIndex = 24;
            this.pcPlan.TabStop = false;
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlan.FlatAppearance.BorderSize = 0;
            this.btnPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlan.ForeColor = System.Drawing.Color.White;
            this.btnPlan.Location = new System.Drawing.Point(113, 38);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(252, 42);
            this.btnPlan.TabIndex = 26;
            this.btnPlan.Text = "Realizar novo plano";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // showDetails
            // 
            this.showDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.showDetails.HeaderText = "Exibir Detalhes";
            this.showDetails.Name = "showDetails";
            this.showDetails.ReadOnly = true;
            this.showDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.showDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showDetails.ToolTipText = "Exibe os detalhes do plano";
            this.showDetails.Width = 148;
            // 
            // renewPlan
            // 
            this.renewPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.renewPlan.HeaderText = "Renovar Plano";
            this.renewPlan.Name = "renewPlan";
            this.renewPlan.ReadOnly = true;
            this.renewPlan.ToolTipText = "Redireciona ao usuário a tela para renovar o plano do aluno";
            this.renewPlan.Width = 126;
            // 
            // idStudent
            // 
            this.idStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idStudent.HeaderText = "idStudent";
            this.idStudent.Name = "idStudent";
            this.idStudent.ReadOnly = true;
            this.idStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idStudent.Visible = false;
            this.idStudent.Width = 109;
            // 
            // idPlan
            // 
            this.idPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPlan.HeaderText = "idPlan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idPlan.Visible = false;
            this.idPlan.Width = 63;
            // 
            // idModality
            // 
            this.idModality.HeaderText = "idModality";
            this.idModality.Name = "idModality";
            this.idModality.ReadOnly = true;
            this.idModality.Visible = false;
            // 
            // idItemsPackage
            // 
            this.idItemsPackage.HeaderText = "idItemsPackage";
            this.idItemsPackage.Name = "idItemsPackage";
            this.idItemsPackage.ReadOnly = true;
            this.idItemsPackage.Visible = false;
            // 
            // idPackage
            // 
            this.idPackage.HeaderText = "idPackage";
            this.idPackage.Name = "idPackage";
            this.idPackage.ReadOnly = true;
            this.idPackage.Visible = false;
            // 
            // idFormOfPayment
            // 
            this.idFormOfPayment.HeaderText = "idFormOfPayment";
            this.idFormOfPayment.Name = "idFormOfPayment";
            this.idFormOfPayment.ReadOnly = true;
            this.idFormOfPayment.Visible = false;
            // 
            // idSituationPlan
            // 
            this.idSituationPlan.HeaderText = "idSituationPlan";
            this.idSituationPlan.Name = "idSituationPlan";
            this.idSituationPlan.ReadOnly = true;
            this.idSituationPlan.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.name.Width = 81;
            // 
            // descriptionModality
            // 
            this.descriptionModality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionModality.HeaderText = "Modalidade";
            this.descriptionModality.Name = "descriptionModality";
            this.descriptionModality.ReadOnly = true;
            this.descriptionModality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descriptionModality.Width = 105;
            // 
            // valuePlan
            // 
            this.valuePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valuePlan.HeaderText = "Valor";
            this.valuePlan.Name = "valuePlan";
            this.valuePlan.ReadOnly = true;
            this.valuePlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valuePlan.Width = 56;
            // 
            // descriptionformOfPayment
            // 
            this.descriptionformOfPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionformOfPayment.HeaderText = "Forma de Pagamento";
            this.descriptionformOfPayment.Name = "descriptionformOfPayment";
            this.descriptionformOfPayment.ReadOnly = true;
            this.descriptionformOfPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descriptionformOfPayment.Width = 179;
            // 
            // descriptionPackage
            // 
            this.descriptionPackage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionPackage.HeaderText = "Pacote";
            this.descriptionPackage.Name = "descriptionPackage";
            this.descriptionPackage.ReadOnly = true;
            this.descriptionPackage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descriptionPackage.Width = 68;
            // 
            // datePurchasePlan
            // 
            this.datePurchasePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datePurchasePlan.HeaderText = "Data da ativação da plano";
            this.datePurchasePlan.Name = "datePurchasePlan";
            this.datePurchasePlan.ReadOnly = true;
            this.datePurchasePlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datePurchasePlan.Width = 212;
            // 
            // timePurchasePlan
            // 
            this.timePurchasePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timePurchasePlan.HeaderText = "Hora da ativação do plano";
            this.timePurchasePlan.Name = "timePurchasePlan";
            this.timePurchasePlan.ReadOnly = true;
            this.timePurchasePlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timePurchasePlan.Width = 215;
            // 
            // dateTerminalPlan
            // 
            this.dateTerminalPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateTerminalPlan.HeaderText = "Data final do Plano";
            this.dateTerminalPlan.Name = "dateTerminalPlan";
            this.dateTerminalPlan.ReadOnly = true;
            this.dateTerminalPlan.Width = 178;
            // 
            // dateTerminalPlanLast
            // 
            this.dateTerminalPlanLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateTerminalPlanLast.HeaderText = "Data final do plano prorrogado";
            this.dateTerminalPlanLast.Name = "dateTerminalPlanLast";
            this.dateTerminalPlanLast.ReadOnly = true;
            this.dateTerminalPlanLast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateTerminalPlanLast.Visible = false;
            this.dateTerminalPlanLast.Width = 252;
            // 
            // situation
            // 
            this.situation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.situation.HeaderText = "Situação do Plano";
            this.situation.Name = "situation";
            this.situation.ReadOnly = true;
            this.situation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.situation.Width = 152;
            // 
            // timeInactivated
            // 
            this.timeInactivated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeInactivated.HeaderText = "Tempo do plano desativado";
            this.timeInactivated.Name = "timeInactivated";
            this.timeInactivated.ReadOnly = true;
            this.timeInactivated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timeInactivated.Visible = false;
            this.timeInactivated.Width = 227;
            // 
            // deactivationDate
            // 
            this.deactivationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deactivationDate.HeaderText = "Data da desativação do plano";
            this.deactivationDate.Name = "deactivationDate";
            this.deactivationDate.ReadOnly = true;
            this.deactivationDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deactivationDate.Visible = false;
            this.deactivationDate.Width = 240;
            // 
            // FrmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1027, 462);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.pcPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDataPlan);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmPlan";
            this.Text = "FrmPurchasePlan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDataPlan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.PictureBox pcPlan;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.DataGridViewImageColumn showDetails;
        private System.Windows.Forms.DataGridViewImageColumn renewPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModality;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemsPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituationPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionModality;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionformOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePurchasePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTerminalPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTerminalPlanLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn situation;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInactivated;
        private System.Windows.Forms.DataGridViewTextBoxColumn deactivationDate;
    }
}