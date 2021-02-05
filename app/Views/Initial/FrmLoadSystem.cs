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
                    timer.Enabled = false;

                    if (!database.ExistsDatabase())
                    {
                        DialogResult dr = MessageBox.Show("Não existe Base de dados. Caso você tenha o arquivo de backup clica no 'sim' para restauração do banco de dados.", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            var openFileBackup = new OpenFileDialog();
                            openFileBackup.Title = "Buscar arquivo 'bak' para restauração da base de dados.";
                            openFileBackup.Filter = "Backup |*.bak";
                            if (DialogResult.OK == openFileBackup.ShowDialog())
                            {
                                new Backup().RestoreDatabase(openFileBackup.FileName);
                            }
                            else
                            {
                                MessageBox.Show("O sistema será fechado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            database.CreateDatabase();
                            database.CreateTables();
                        }
                    }                  

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
            return new User().SearchAll().Rows.Count > 0 ? true : false;
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
