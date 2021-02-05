using Bussiness;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmLoadSystem : Form
    {
        public FrmLoadSystem()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbLoadProgress.Value < 100)
            {
                pbLoadProgress.Value += 2;
            }
            else
            {   
                try
                {
                    if (!database.ExistsDatabase())
                    {
                        database.CreateDatabase();
                        database.CreateTables();
                    }

                    timer.Enabled = false;
                    this.Visible = false;

                    if (CheckedExistUsers())
                    {
                        using (var authentication = new FrmAuthentication())
                        {
                            authentication.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var gymControl = new FrmGymControl("nenhum usuário"))
                        {
                            gymControl.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckedExistUsers()
        {
            return new Bussiness.User().SearchAll().Rows.Count > 0 ? true : false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
