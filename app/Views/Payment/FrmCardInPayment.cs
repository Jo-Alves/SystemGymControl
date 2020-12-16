using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmCardInPayment : Form
    {

        public bool paymentCancel { get; set; }
        public DataTable dataPortion { get; set; }
        public FrmCardInPayment()
        {
            InitializeComponent();           
        } 
        public FrmCardInPayment(decimal valuePackage, int numberPortions)
        {
            InitializeComponent();
            lblvalueTotal.Text = $"R$ {valuePackage}";
            txtNumberPortions.Text = numberPortions.ToString();
            parcelValue(valuePackage, numberPortions);
            dgvPortions.ClearSelection();
        }

        private void parcelValue(decimal valuePackage, int numberPortions)
        {
            for(int i = 1; i <= numberPortions; i++)
            {
                DateTime dateCurrent = DateTime.Now;
                dgvPortions.Rows.Add(i, dateCurrent.AddMonths(i).ToShortDateString(), $"R$ {(valuePackage / numberPortions).ToString("0.00")}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            dataPortion = new DataTable();
            dataPortion.Columns.Add("portion", typeof(string));
            dataPortion.Columns.Add("dueDate", typeof(string));
            dataPortion.Columns.Add("value", typeof(string));
            foreach(DataGridViewRow row in dgvPortions.Rows)
            {
                dataPortion.Rows.Add(row.Cells["portion"].Value.ToString(), row.Cells["dueDate"].Value.ToString(), row.Cells["valuePortion"].Value.ToString());
            }

            paymentCancel = true;
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmCardInPayment_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
