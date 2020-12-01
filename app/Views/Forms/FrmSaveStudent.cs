using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmSaveStudent : Form
    {

        Student student = new Student();
        ResponsibleStudent responsible = new ResponsibleStudent();
        bool theDataSelected = false, hasResponsible;
        ErrorProvider error = new ErrorProvider();
        string nameResponsible, cpfResponsible, Kinship, phone;
        int idResponsible, studendtIdResponsible, id;
        DialogResult dr;
        bool goSaveResponsible = false, isEdition;

        public FrmSaveStudent()
        {
            InitializeComponent();
        }
        public FrmSaveStudent(int id)
        {
            InitializeComponent();

            var DataStudent = student.SearchID(id);
            
            mkCPF.Enabled = false;
            txtId.Text = id.ToString();
            txtName.Text = DataStudent.Rows[0]["name"].ToString();
            mkCPF.Text = DataStudent.Rows[0]["cpf"].ToString();
            dtBirth.Text = DataStudent.Rows[0]["birth"].ToString();
            mkCEP.Text = DataStudent.Rows[0]["cep"].ToString();
            mkPhone.Text = DataStudent.Rows[0]["phone"].ToString();
            txtDistrict.Text = DataStudent.Rows[0]["district"].ToString();
            txtAddress.Text = DataStudent.Rows[0]["address"].ToString();
            ndNumber.Value = decimal.Parse(DataStudent.Rows[0]["number"].ToString());
            txtCity.Text = DataStudent.Rows[0]["city"].ToString();
            cbState.Text = DataStudent.Rows[0]["state"].ToString();
            if (!string.IsNullOrEmpty(DataStudent.Rows[0]["photo"].ToString()))
            {
                image = DataStudent.Rows[0]["photo"].ToString();
                pcPhoto.ImageLocation = image;
                pcPhoto.Load();
            }

            if(responsible.SearchID(id).Rows.Count > 0)
            {
                hasResponsible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (student.SearchAll().Rows.Count > 0)
            {
                OpenFormAndUser.OpenForm(new FrmStudent());
            }
            else
                OpenFormAndUser.OpenForm(new FrmOptionsSave());

        }

        string path = @"C:\System-GYM-Control\Galery";

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
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                    student._id = int.Parse(txtId.Text);

                student._name = txtName.Text.Trim();
                student._birth = dtBirth.Text;

                if (mkCPF.Text.Length == 14)
                    student._cpf = mkCPF.Text.Trim();
                else
                    student._cpf = "";

                if (mkPhone.Text.Length == 15)
                    student._phone = mkPhone.Text;
                else
                    student._phone = "";


                if (mkCEP.Text.Length == 10)
                    student._cep = mkCEP.Text;
                else
                    student._cep = "";

                student._address = txtAddress.Text.Trim();
                student._district = txtDistrict.Text.Trim();
                student._number = int.Parse(ndNumber.Value.ToString());
                student._city = txtCity.Text.Trim();
                student._state = cbState.Text.Trim();
               
                if (ValidateFields())
                {
                    if (!CheckedHigherStudent())
                    {
                        if (student._id == 0)
                        {
                            dr = MessageBox.Show("O aluno é menor de idade. Deseja Cadastrar o nome do responsável?", "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.Yes)
                            {
                                var responsible = new FrmResponsiblesStudent();
                                responsible.ShowDialog();
                                if (!string.IsNullOrEmpty(responsible.name))
                                {
                                    nameResponsible = responsible.name;
                                    cpfResponsible = responsible.cpf;
                                    Kinship = responsible.kinship;
                                    phone = responsible.phone;
                                    goSaveResponsible = true;
                                }
                                else
                                    return;
                            }
                        }
                        else
                        {
                            string message;

                            if (hasResponsible)
                                message = "Deseja alterar os dados do responsável?";
                            else
                                message = "Deseja adicionar os dados do responsável?";


                            dr = MessageBox.Show(message, "System GYM Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.Yes)
                            {
                                var responsible = new FrmResponsiblesStudent(student._id);
                                responsible.ShowDialog();
                                if (!string.IsNullOrEmpty(responsible.name))
                                {
                                    id = responsible.id;
                                    nameResponsible = responsible.name;
                                    cpfResponsible = responsible.cpf;
                                    Kinship = responsible.kinship;
                                    phone = responsible.phone;
                                    idResponsible = responsible.id;
                                    studendtIdResponsible = responsible.stundetID;
                                    isEdition = true;
                                    goSaveResponsible = true;
                                }
                                else
                                    return;
                            }
                        }
                    }

                    if (image != "")
                        CopyImageOuterDirectory();

                    student._photo = image;

                    student.Save();
                    if (!CheckedHigherStudent() && goSaveResponsible)
                    {
                        responsible._name = nameResponsible;
                        responsible._cpf = cpfResponsible;
                        responsible._kinship = Kinship;
                        responsible._phone = phone;
                        responsible._id = idResponsible;                        
                        if(isEdition)
                            responsible._studentID = student._id;

                        if (student._id == 0 && !isEdition)
                            responsible._studentID = student.GetMaxID();

                        responsible.Save();
                    }

                    this.Close();
                    OpenFormAndUser.OpenForm(new FrmStudent());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyImageOuterDirectory()
        {
            CreateDirectory();

            string nameImage = Path.GetFileName(image);
            string pathImage = $@"{path}\{nameImage}";

            if (!File.Exists(pathImage))
            {
                FileInfo fileInfo = new FileInfo(image);
                fileInfo.CopyTo($@"{path}\{nameImage}");
                image = $@"{path}\{nameImage}";
            }
            else
                image = pathImage; 
        }

        private bool ValidateFields()
        {
            bool theFieldsHaveBeenValidated = false;

            if (!string.IsNullOrEmpty(student.ValidateFieldsandGetMessage()))
            {
                error.Clear();

                if (student.ValidateFieldsandGetMessage() == "Campo Nome obrigatório!")
                {
                    MessageBox.Show("Campo Nome obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtName, "Campo Nome obrigatório!");
                    txtName.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Campo CPF obrigatório!")
                {
                    MessageBox.Show("Campo CPF obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Campo CPF obrigatório!");
                    mkCPF.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Campo Bairro obrigatório!")
                {
                    MessageBox.Show("Campo Bairro obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtDistrict, "Campo Bairro obrigatório!");
                    txtDistrict.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Campo Endereço obrigatório!")
                {
                    MessageBox.Show("Campo Endereço obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtAddress, "Campo Endereço obrigatório!");
                    txtAddress.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Campo Cidade obrigatório!")
                {
                    MessageBox.Show("Campo Cidade obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(txtCity, "Campo Cidade obrigatório!");
                    txtCity.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Campo Estado obrigatório!")
                {
                    MessageBox.Show("Campo Estado obrigatório!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(cbState, "Campo Estado obrigatório!");
                    cbState.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "CPF inválido!")
                {
                    MessageBox.Show("CPF inválido!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "CPF inválido!");
                    mkCPF.Focus();
                }
                else if (student.ValidateFieldsandGetMessage() == "Este CPF já está cadastrado!")
                {
                    MessageBox.Show("Este CPF já está cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(mkCPF, "Este CPF já está cadastrado!");
                    mkCPF.Focus();
                }
            }
            else if (!theDataSelected)
            {
                MessageBox.Show("Informe a data de nascimento!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error.SetError(dtBirth, "Informe a data de nascimento!");
                dtBirth.Focus();
            }
            else
            {
                theFieldsHaveBeenValidated = true;
            }

            return theFieldsHaveBeenValidated;
        }

        // Verifica se o estudante é de maior idade

        private bool CheckedHigherStudent()
        {
            // é de maior
            bool isItBigger = false;

            DateTime result = DateTime.MinValue;
            if (DateTime.TryParse(this.dtBirth.Text.Trim(), out result))
            {
                string Date = DateTime.Now.ToShortDateString();

                DateTime birth = Convert.ToDateTime(dtBirth.Text);
                DateTime today = Convert.ToDateTime(Date);
                TimeSpan time = today.Subtract(birth);

                int days = time.Days;
                int age = days / 365;

                if (age >= 18)
                {
                    isItBigger = true;
                }
            }

            return isItBigger;
        }

        private void FrmSaveStudent_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 617)
            {
                /* labels - Location */

                lblId.Location = new Point(53, 28);
                lblName.Location = new Point(53, 91);
                lblCPF.Location = new Point(773, 91);
                lblBirth.Location = new Point(53, 159);
                lblCEP.Location = new Point(233, 162);
                lblDistrict.Location = new Point(474, 162);
                lblAddress.Location = new Point(53, 236);
                lblNumber.Location = new Point(486, 236);
                lblCity.Location = new Point(596, 236);
                lblState.Location = new Point(1005, 236);
                lblPhone.Location = new Point(53, 304);

                /* textbox  - Location*/

                txtId.Location = new Point(57, 54);
                txtName.Location = new Point(57, 117);
                mkCPF.Location = new Point(768, 117);
                dtBirth.Location = new Point(57, 188);
                mkCEP.Location = new Point(228, 188);
                txtDistrict.Location = new Point(478, 188);
                txtAddress.Location = new Point(57, 262);
                ndNumber.Location = new Point(490, 262);
                txtCity.Location = new Point(600, 262);
                cbState.Location = new Point(1009, 263);
                mkPhone.Location = new Point(57, 330);

                /* Buttons - Location */
                btnCancel.Location = new Point(189, 378);
                btnSave.Location = new Point(57, 378);
                btnSearchCep.Location = new Point(355, 187);
                btnOpenImage.Location = new Point(967, 159);

                /* pictbox - Location */
                pcPhoto.Location = new Point(971, 18);

                /* textbox  - Size*/

                txtName.Size = new Size(693, 26);
                txtDistrict.Size = new Size(449, 26);
                txtCity.Size = new Size(403, 26);
            }
            else
            {
                /* labels - Location */

                lblId.Location = new Point(18, 30);
                lblName.Location = new Point(18, 93);
                lblCPF.Location = new Point(18, 161);
                lblBirth.Location = new Point(183, 161);
                lblCEP.Location = new Point(18, 229);
                lblDistrict.Location = new Point(268, 229);
                lblAddress.Location = new Point(18, 297);
                lblNumber.Location = new Point(458, 297);
                lblCity.Location = new Point(18, 363);
                lblState.Location = new Point(456, 363);
                lblPhone.Location = new Point(18, 430);

                /* textbox  - Location*/

                txtId.Location = new Point(22, 56);
                txtName.Location = new Point(22, 119);
                mkCPF.Location = new Point(22, 187);
                dtBirth.Location = new Point(187, 187);
                mkCEP.Location = new Point(22, 255);
                txtDistrict.Location = new Point(272, 255);
                txtAddress.Location = new Point(22, 323);
                ndNumber.Location = new Point(462, 323);
                txtCity.Location = new Point(22, 389);
                cbState.Location = new Point(460, 390);
                mkPhone.Location = new Point(22, 456);

                /* Buttons - Location */
                btnCancel.Location = new Point(154, 504);
                btnSave.Location = new Point(22, 504);
                btnSearchCep.Location = new Point(149, 254);
                btnOpenImage.Location = new Point(426, 165);

                /* pictbox - Location */
                pcPhoto.Location = new Point(430, 24);

                /* textbox  - Size*/

                txtName.Size = new Size(378, 26);
                txtDistrict.Size = new Size(294, 26);
                txtCity.Size = new Size(427, 26);
            }
        }

        string image = "";

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {
            error.Clear();
            if (dtBirth.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                theDataSelected = true;
            }
        }

        private void mkCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchCep_Click(sender, e);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            var OpenImage = new OpenFileDialog();
            OpenImage.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF*";
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                image = OpenImage.FileName;
                pcPhoto.ImageLocation = image;
                pcPhoto.Load();
            }
        }

        private void btnSearchCep_Click(object sender, EventArgs e)
        {
            try
            {
                using (var wsMail = new WsMail.AtendeClienteClient())
                {
                    var searchCep = wsMail.consultaCEP(mkCEP.Text);
                    txtAddress.Text = searchCep.end;
                    txtDistrict.Text = searchCep.bairro;
                    txtCity.Text = searchCep.cidade;
                    cbState.Text = searchCep.uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
