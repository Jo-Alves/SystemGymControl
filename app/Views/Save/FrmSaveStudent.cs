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
        string nameResponsible, cpfResponsible, Kinship, phone;
        int idResponsible, studendtIdResponsible, id;
        DialogResult dr;
        bool goSaveResponsible = false, isEdition;

        public FrmSaveStudent()
        {
            InitializeComponent();
            txtName.Focus();
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
            txtEmail.Text = DataStudent.Rows[0]["email"].ToString();
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
            try
            {
                if (student.SearchAll().Rows.Count > 0)
                {
                    OpenForm.ShowForm(new FrmStudent(), this);
                }
                else
                {
                    FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA";
                    OpenForm.ShowForm(new FrmOptionsSave(), this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string path = @"C:\System-GYM-Control\Galery\Students";

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
                student._email = txtEmail.Text.Trim();
               
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

                    OpenForm.ShowForm(new FrmStudent(), this);
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
            string messageValidateFields = student.ValidateFieldsAndGetMessage();

            if (!string.IsNullOrEmpty(messageValidateFields))
            {
                if (messageValidateFields == "Campo Nome obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    txtName.Focus();
                }
                else if (messageValidateFields == "Campo CPF obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    mkCPF.Focus();
                }
                else if (messageValidateFields == "Campo Bairro obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    txtDistrict.Focus();
                }
                else if (messageValidateFields == "Campo Endereço obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    txtAddress.Focus();
                }
                else if (messageValidateFields == "Campo Cidade obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    txtCity.Focus();
                }
                else if (messageValidateFields == "Campo Estado obrigatório!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    cbState.Focus();
                }
                else if (messageValidateFields == "Email inválido!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    txtEmail.Focus();
                }
                else if (messageValidateFields == "CPF inválido!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    mkCPF.Focus();
                }
                else if (messageValidateFields == "Este CPF já está cadastrado!")
                {
                    MessageBox.Show(messageValidateFields, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    mkCPF.Focus();
                }
            }
            else if (!theDataSelected)
            {
                MessageBox.Show("Informe a data de nascimento!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
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

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            image = "";
            pcPhoto.Image = null;
        }

        string image = "";

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {
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
