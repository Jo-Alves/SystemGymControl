using Bussiness;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmRenewPlan : Form
    {
        Package package = new Package();
        Modality modality = new Modality();
        Plan plan = new Plan();
        Student student = new Student();
        SituationsPlan situationsPlan = new SituationsPlan();
        CashPayment cashPayment = new CashPayment();
        CardPayment cardPayment = new CardPayment();

        public FrmRenewPlan()
        {
            InitializeComponent();
        }

        public FrmRenewPlan(int idPlan)
        {
            InitializeComponent();

            DataTable dataPlan = plan.SearchID(idPlan);
            int idPackage = int.Parse(dataPlan.Rows[0]["idPackage"].ToString());
            txtCodigoStudent.Text = idPlan.ToString();
            txtNameStudent.Text = dataPlan.Rows[0]["name"].ToString();
            txtPackage.Text = dataPlan.Rows[0]["descriptionPackage"].ToString();
            txtValue.Text = dataPlan.Rows[0]["valueItemsPackage"].ToString();
            txtModality.Text = dataPlan.Rows[0]["descriptionModality"].ToString();
            foreach (DataRow dr in package.SearchPackageAndItemsPackageId(int.Parse(dataPlan.Rows[0]["IdPackage"].ToString())).Rows)
            {
                cbFormOfPayment.Items.Add(dr["description"].ToString());
            }
            cbFormOfPayment.Text = dataPlan.Rows[0]["descriptionFormOfPayment"].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPurchasePlan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_32px_leavee;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmRenewPlan_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
