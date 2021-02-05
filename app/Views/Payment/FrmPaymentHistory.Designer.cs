
namespace SystemGymControl
{
    partial class FrmPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentHistory));
            this.dgvDataPayment = new System.Windows.Forms.DataGridView();
            this.receipt = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataPayment
            // 
            this.dgvDataPayment.AllowUserToAddRows = false;
            this.dgvDataPayment.AllowUserToDeleteRows = false;
            this.dgvDataPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataPayment.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataPayment.ColumnHeadersHeight = 35;
            this.dgvDataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receipt,
            this.id,
            this.name,
            this.description,
            this.valueTotal,
            this.valueDiscount,
            this.payday,
            this.paymentTime});
            this.dgvDataPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataPayment.EnableHeadersVisualStyles = false;
            this.dgvDataPayment.Location = new System.Drawing.Point(14, 112);
            this.dgvDataPayment.MultiSelect = false;
            this.dgvDataPayment.Name = "dgvDataPayment";
            this.dgvDataPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataPayment.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvDataPayment.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataPayment.Size = new System.Drawing.Size(791, 363);
            this.dgvDataPayment.TabIndex = 30;
            this.dgvDataPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellClick);
            this.dgvDataPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPlan_CellDoubleClick);
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
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Aluno";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 60;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Pacote";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 68;
            // 
            // valueTotal
            // 
            this.valueTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valueTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.valueTotal.HeaderText = "Valor Total";
            this.valueTotal.Name = "valueTotal";
            this.valueTotal.ReadOnly = true;
            this.valueTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueTotal.Width = 98;
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
            this.valueDiscount.Width = 89;
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
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 80);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtSearch.Location = new System.Drawing.Point(109, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(554, 33);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDataPayment);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPaymentHistory";
            this.Text = "FrmPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDataPayment;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.DataGridViewImageColumn receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payday;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}