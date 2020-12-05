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
        string dateRegistion;

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
                idUser = int.Parse(dataUser.Rows[0]["id"].ToString());
                txtUser.Text = dataUser.Rows[0]["name_user"].ToString();
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
                if (messageValidateFields == "Campo 'Usuário' obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Focus();
                }
                else if (messageValidateFields == "O nome de usuário já existe!" && idUser == 0)
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Focus();
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

        //private void FrmSaveStudent_ClientSizeChanged(object sender, EventArgs e)
        //{
        //    //if (this.Width > 617)
        //    //{
        //    //    /* labels - Location */

        //    //    lblId.Location = new Point(53, 28);
        //    //    lblUser.Location = new Point(53, 91);
        //    //    lblCPF.Location = new Point(773, 91);
        //    //    lblBirth.Location = new Point(53, 159);
        //    //    lblCEP.Location = new Point(233, 162);
        //    //    lblDistrict.Location = new Point(474, 162);
        //    //    lblAddress.Location = new Point(53, 236);
        //    //    lblNumber.Location = new Point(486, 236);
        //    //    lblCity.Location = new Point(596, 236);
        //    //    lblState.Location = new Point(1005, 236);
        //    //    lblPhone.Location = new Point(53, 304);

        //    //    /* textbox  - Location*/

        //    //    txtId.Location = new Point(57, 54);
        //    //    txtUser.Location = new Point(57, 117);
        //    //    mkCPF.Location = new Point(768, 117);
        //    //    dtBirth.Location = new Point(57, 188);
        //    //    mkCEP.Location = new Point(228, 188);
        //    //    txtDistrict.Location = new Point(478, 188);
        //    //    txtAddress.Location = new Point(57, 262);
        //    //    ndNumber.Location = new Point(490, 262);
        //    //    txtCity.Location = new Point(600, 262);
        //    //    cbState.Location = new Point(1009, 263);
        //    //    mkPhone.Location = new Point(57, 330);

        //    //    /* Buttons - Location */
        //    //    btnCancel.Location = new Point(189, 378);
        //    //    btnSave.Location = new Point(57, 378);
        //    //    btnSearchCep.Location = new Point(355, 187);
        //    //    btnOpenAvatar.Location = new Point(967, 159);

        //    //    /* pictbox - Location */
        //    //    pcPhoto.Location = new Point(971, 18);

        //    //    /* textbox  - Size*/

        //    //    txtUser.Size = new Size(693, 26);
        //    //    txtDistrict.Size = new Size(449, 26);
        //    //    txtCity.Size = new Size(403, 26);
        //    //}
        //    //else
        //    //{
        //    //    /* labels - Location */

        //    //    lblId.Location = new Point(18, 30);
        //    //    lblUser.Location = new Point(18, 93);
        //    //    lblCPF.Location = new Point(18, 161);
        //    //    lblBirth.Location = new Point(183, 161);
        //    //    lblCEP.Location = new Point(18, 229);
        //    //    lblDistrict.Location = new Point(268, 229);
        //    //    lblAddress.Location = new Point(18, 297);
        //    //    lblNumber.Location = new Point(458, 297);
        //    //    lblCity.Location = new Point(18, 363);
        //    //    lblState.Location = new Point(456, 363);
        //    //    lblPhone.Location = new Point(18, 430);

        //    //    /* textbox  - Location*/

        //    //    txtId.Location = new Point(22, 56);
        //    //    txtUser.Location = new Point(22, 119);
        //    //    mkCPF.Location = new Point(22, 187);
        //    //    dtBirth.Location = new Point(187, 187);
        //    //    mkCEP.Location = new Point(22, 255);
        //    //    txtDistrict.Location = new Point(272, 255);
        //    //    txtAddress.Location = new Point(22, 323);
        //    //    ndNumber.Location = new Point(462, 323);
        //    //    txtCity.Location = new Point(22, 389);
        //    //    cbState.Location = new Point(460, 390);
        //    //    mkPhone.Location = new Point(22, 456);

        //    //    /* Buttons - Location */
        //    //    btnCancel.Location = new Point(154, 504);
        //    //    btnSave.Location = new Point(22, 504);
        //    //    btnSearchCep.Location = new Point(149, 254);
        //    //    btnOpenAvatar.Location = new Point(426, 165);

        //    //    /* pictbox - Location */
        //    //    pcPhoto.Location = new Point(430, 24);

        //    //    /* textbox  - Size*/

        //    //    txtUser.Size = new Size(378, 26);
        //    //    txtDistrict.Size = new Size(294, 26);
        //    //    txtCity.Size = new Size(427, 26);
        //    //}
        //}

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
