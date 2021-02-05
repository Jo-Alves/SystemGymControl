using Bussiness;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        public bool ExitDirectory(string path)
        {
            return Directory.Exists(path) ? true : false;
        }

        public bool ExitFile(string fileName)
        {
            return File.Exists(fileName) ? true : false;
        }

        private void btnGenerateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDirectory.Text))
                {
                    MessageBox.Show("Insira o diretório com o nome do arquivo para a criação do arquivo de backup!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ExitFile(txtDirectory.Text.Trim()))
                {
                    MessageBox.Show("Backup negado! Já existe um arquivo com este nome. Troque o nome do arquivo", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                new Backup().Generatebackup(txtDirectory.Text);


                if (!string.IsNullOrEmpty(Settings.Default["email"].ToString()))
                {
                    try
                    {
                        string message = "<html><body> <h3>Backup - System GYM Control</h3> <br> <br>" +
                            $"<p>Enviado em anexo o arquivo de backup realizado no(a) {DateTime.Now.ToLongDateString()}</p></body></html>";

                        Email.Submit(Settings.Default["email"].ToString(), "Arquivo de Backup enviado por System GYM Control'", txtDirectory.Text, message);
                    }
                    catch {}
                }

                this.Close();

            }
            catch
            {
                MessageBox.Show("Ops... Houve algum problema. Verifique se o arquivo de backup será inserido em um disco. Se não é isso, há algum problema no sistema de gerenciamento do banco de dados.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Resources.icons8_close_window_32px_enter1;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Resources.icons8_close_window_32px_leavee;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmBackup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                txtDirectory.Text = saveFileDialog.FileName;
            }
        }
    }
}
