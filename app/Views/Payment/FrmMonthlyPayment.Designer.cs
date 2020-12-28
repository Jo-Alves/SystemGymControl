
namespace SystemGymControl
{
    partial class FrmMonthlyPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyPayment));
            this.dgvDataPlan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.receive = new System.Windows.Forms.DataGridViewImageColumn();
            this.receipt = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.receive,
            this.receipt,
            this.id,
            this.idCash,
            this.valueTotal,
            this.valueDiscount,
            this.Situation,
            this.duedate,
            this.payday,
            this.paymentTime});
            this.dgvDataPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataPlan.EnableHeadersVisualStyles = false;
            this.dgvDataPlan.Location = new System.Drawing.Point(14, 185);
            this.dgvDataPlan.MultiSelect = false;
            this.dgvDataPlan.Name = "dgvDataPlan";
            this.dgvDataPlan.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataPlan.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvDataPlan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataPlan.Size = new System.Drawing.Size(1001, 326);
            this.dgvDataPlan.TabIndex = 30;
            this.dgvDataPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellClick);
            this.dgvDataPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdStudent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(177, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdStudent.BackColor = System.Drawing.Color.White;
            this.txtIdStudent.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtIdStudent.Location = new System.Drawing.Point(75, 47);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.ReadOnly = true;
            this.txtIdStudent.Size = new System.Drawing.Size(100, 33);
            this.txtIdStudent.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtName.Location = new System.Drawing.Point(181, 48);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(709, 33);
            this.txtName.TabIndex = 34;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::SystemGymControl.Properties.Resources.icons8_back_arrow_32px;
            this.btnBack.Location = new System.Drawing.Point(23, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 61;
            this.btnBack.TabStop = false;
            this.metroToolTip.SetToolTip(this.btnBack, "Voltar a janela anterior");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // receive
            // 
            this.receive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.receive.HeaderText = "Receber";
            this.receive.Name = "receive";
            this.receive.ReadOnly = true;
            this.receive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receive.Width = 78;
            // 
            // receipt
            // 
            this.receipt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.receipt.HeaderText = "Gerar recibo";
            this.receipt.Name = "receipt";
            this.receipt.ReadOnly = true;
            this.receipt.Width = 112;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 69;
            // 
            // idCash
            // 
            this.idCash.HeaderText = "idCach";
            this.idCash.Name = "idCash";
            this.idCash.ReadOnly = true;
            this.idCash.Visible = false;
            // 
            // valueTotal
            // 
            this.valueTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valueTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.valueTotal.HeaderText = "Valor Total";
            this.valueTotal.Name = "valueTotal";
            this.valueTotal.ReadOnly = true;
            this.valueTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueTotal.Width = 98;
            // 
            // valueDiscount
            // 
            this.valueDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valueDiscount.DefaultCellStyle = dataGridViewCellStyle4;
            this.valueDiscount.HeaderText = "Desconto";
            this.valueDiscount.Name = "valueDiscount";
            this.valueDiscount.ReadOnly = true;
            this.valueDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueDiscount.Width = 89;
            // 
            // Situation
            // 
            this.Situation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Situation.HeaderText = "Situação";
            this.Situation.Name = "Situation";
            this.Situation.ReadOnly = true;
            this.Situation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Situation.Width = 81;
            // 
            // duedate
            // 
            this.duedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duedate.HeaderText = "Data de vencimento";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            this.duedate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duedate.Width = 168;
            // 
            // payday
            // 
            this.payday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.payday.HeaderText = "Data de pagamento";
            this.payday.Name = "payday";
            this.payday.ReadOnly = true;
            this.payday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.payday.Width = 166;
            // 
            // paymentTime
            // 
            this.paymentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentTime.HeaderText = "Hora do pagamento";
            this.paymentTime.Name = "paymentTime";
            this.paymentTime.ReadOnly = true;
            this.paymentTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentTime.Width = 169;
            // 
            // FrmMonthlyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDataPlan);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMonthlyPayment";
            this.Text = "FrmPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDataPlan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBack;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.DataGridViewImageColumn receive;
        private System.Windows.Forms.DataGridViewImageColumn receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situation;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn payday;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTime;
    }
}