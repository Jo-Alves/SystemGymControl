using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmSaveUser : Form
    {

        User user = new User();
        int idUser;
        string dateRegistion, nameUser;

        DialogResult dr;

        public FrmSaveUser()
        {
            InitializeComponent();
            dateRegistion = DateTime.Now.ToShortDateString();
        }

        public FrmSaveUser(int id)
        {
            InitializeComponent();

            try
            {
                var dataUser = user.SearchID(id);
                txtUser.Enabled = false;
                idUser = int.Parse(dataUser.Rows[0]["id"].ToString());
                txtName.Text = dataUser.Rows[0]["name"].ToString();
                txtEmail.Text = dataUser.Rows[0]["email"].ToString();
                txtUser.Text = dataUser.Rows[0]["name_user"].ToString();
                txtPassword1.Text = dataUser.Rows[0]["password"].ToString();
                txtPassword2.Text = txtPassword1.Text;
                cbQuestion.Text = dataUser.Rows[0]["question"].ToString();
                txtAnswer.Text = dataUser.Rows[0]["answer"].ToString();
                dateRegistion = dataUser.Rows[0]["date_registion"].ToString();
                avatar = dataUser.Rows[0]["avatar"].ToString();
                if (!string.IsNullOrEmpty(avatar))
                {
                    pcAvatar.ImageLocation = avatar;
                    pcAvatar.Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.SearchAll().Rows.Count > 0)
                {
                    OpenForm.ShowForm(new FrmUser(), this);
                }
                else
                    OpenForm.ShowForm(new FrmOptionsSave(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string path = @"C:\System-GYM-Control\Galery\User";

        private void CreateDirectory()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                user._id = idUser;
                user._user = txtUser.Text.Trim();
                user._name = txtName.Text.Trim();
                user._email = txtEmail.Text.Trim();
                user._password = txtPassword1.Text.Trim();
                user._question = cbQuestion.Text.Trim();
                user._answer = txtAnswer.Text.Trim();
              
                user._dateRegistion = dateRegistion;

                if (ValidateFields())
                {
                    if (!string.IsNullOrWhiteSpace(avatar))
                        CopyAvatarOuterDirectory();

                    user._avatar = avatar;
                    user.Save();
                    OpenForm.ShowForm(new FrmUser(), this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyAvatarOuterDirectory()
        {
            CreateDirectory();

            string nameAvatar = Path.GetFileName(avatar);
            string pathAvatar = $@"{path}\{nameAvatar}";

            if (!File.Exists(pathAvatar))
            {
                FileInfo fileInfo = new FileInfo(avatar);
                fileInfo.CopyTo($@"{path}\{nameAvatar}");
                avatar = $@"{path}\{nameAvatar}";
            }
            else
                avatar = pathAvatar;
        }

        private bool ValidateFields()
        {
            bool theFieldsHaveBeenValidated = false;

            string messageValidateFields = user.ValidateFieldsAndGetMessage();

            if (!string.IsNullOrEmpty(messageValidateFields))
            {
                if (messageValidateFields == "Campo 'Nome' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else if (messageValidateFields == "Campo 'Usuário' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Focus();
                }
                else if (messageValidateFields == "O nome de usuário já existe!" && idUser == 0)
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Focus();
                }
                else if (messageValidateFields == "Email inválido!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }
                else if (messageValidateFields == "Campo 'Senha' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword1.Focus();
                }
                else if (messageValidateFields == "A senha deve ter no mínimo 5 cararacteres!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword1.Focus();
                }
                else if (messageValidateFields == "Campo 'Pergunta de Segurança' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbQuestion.Focus();
                }
                else if (messageValidateFields == "Campo 'Resposta de Segurança' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAnswer.Focus();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtPassword2.Text))
            {
                MessageBox.Show("Repita a senha informada acima", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword2.Focus();
            }
            else if (txtPassword1.Text.Trim() != txtPassword2.Text.Trim())
            {
                MessageBox.Show("Os caracteres não são compatíveis!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword2.Focus();
            }
            else
                theFieldsHaveBeenValidated = true;

            return theFieldsHaveBeenValidated;
        }

        string avatar = "";

        private void btnOpenAvatar_Click(object sender, EventArgs e)
        {
            var OpenAvatar = new OpenFileDialog();
            OpenAvatar.Filter = "Avatars (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF*";
            if (OpenAvatar.ShowDialog() == DialogResult.OK)
            {
                avatar = OpenAvatar.FileName;
                pcAvatar.ImageLocation = avatar;
                pcAvatar.Load();
            }
        }

        bool isPasswordHidden;
        ToolTip tool = new ToolTip();

        private void pcUpdateFormatPassword_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;

            switch (isPasswordHidden)
            {
                case true:
                    txtPassword1.UseSystemPasswordChar = false;
                    txtPassword2.UseSystemPasswordChar = false;
                    pcUpdateFormatPassword.Image = Properties.Resources.ocultar_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ocultar");
                    break;
                case false:
                    txtPassword1.UseSystemPasswordChar = true;
                    txtPassword2.UseSystemPasswordChar = true;
                    pcUpdateFormatPassword.Image = Properties.Resources.ver_32x32;
                    metroToolTip.SetToolTip(pcUpdateFormatPassword, "Ver");
                    break;
                    break;
            }

        }
    }
}