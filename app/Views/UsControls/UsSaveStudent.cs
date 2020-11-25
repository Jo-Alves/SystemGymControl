﻿using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class UsSaveStudent : UserControl
    {

        Student student = new Student();

        public UsSaveStudent()
        {
            InitializeComponent();
        } 
        public UsSaveStudent(int id)
        {
            InitializeComponent();
            
            student._id = id;
            student.SearchID();

            txtId.Text = id.ToString();
            txtName.Text = student.SearchID().Rows[0]["name"].ToString();
            txtCPF.Text = student.SearchID().Rows[0]["cpf"].ToString();
            dtBirth.Text = student.SearchID().Rows[0]["birth"].ToString();
            txtCEP.Text = student.SearchID().Rows[0]["cep"].ToString();
            txtDistrict.Text = student.SearchID().Rows[0]["district"].ToString();
            txtAddress.Text = student.SearchID().Rows[0]["address"].ToString();
            ndNumber.Value = decimal.Parse(student.SearchID().Rows[0]["number"].ToString());
            txtCity.Text = student.SearchID().Rows[0]["city"].ToString();
            cbState.Text = student.SearchID().Rows[0]["state"].ToString();
            if (!string.IsNullOrEmpty(student.SearchID().Rows[0]["photo"].ToString()))
            {
                pcPhoto.ImageLocation = student.SearchID().Rows[0]["photo"].ToString();
                pcPhoto.Load();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmGymControl.Instance.PnPageContainer.Controls.Clear();
            OpenFormAndUser.OpenUserControl(new UsStudent(), "UsStudent");
        }

        ErrorProvider error = new ErrorProvider();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                    student._id = int.Parse(txtId.Text);

                student._name = txtName.Text.Trim();
                student._cpf = txtCPF.Text.Trim();
                student._birth = dtBirth.Text;
                student._cep = txtCEP.Text;
                student._address = txtAddress.Text.Trim();
                student._district = txtDistrict.Text.Trim();
                student._number = int.Parse(ndNumber.Value.ToString());
                student._city = txtCity.Text.Trim();
                student._state = cbState.Text.Trim();
                student._photo = image;

                if (string.IsNullOrEmpty(student.ValidationBox()))
                    student.SaveStudent();
                else
                {
                    if(student.ValidationBox() == "Campo Nome obrigatório!")
                    {
                        MessageBox.Show("Campo Nome obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtName, "Campo Nome obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo CPF obrigatório!")
                    {
                        MessageBox.Show("Campo CPF obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtCPF, "Campo CPF obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo CEP obrigatório!")
                    {
                        MessageBox.Show("Campo CEP obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtCEP, "Campo CEP obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo Bairro obrigatório!")
                    {
                        MessageBox.Show("Campo Bairro obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtDistrict, "Campo Bairro obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo Endereço obrigatório!")
                    {
                        MessageBox.Show("Campo Endereço obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtAddress, "Campo Endereço obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo Cidade obrigatório!")
                    {
                        MessageBox.Show("Campo Cidade obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtCity, "Campo Cidade obrigatório!");
                        txtName.Focus();
                        return;
                    }
                    else if(student.ValidationBox() == "Campo Estado obrigatório!")
                    {
                        MessageBox.Show("Campo Estado obrigatório!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(cbState, "Campo Estado obrigatório!");
                        txtName.Focus();
                        return;
                    }   
                    else if(student.ValidationBox() == "Este CPF já está cadastrado!")
                    {
                        MessageBox.Show("Este CPF já está cadastrado!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error.SetError(txtCEP, "Este CPF já está cadastrado!");
                        txtName.Focus();
                        return;
                    }
                }

                FrmGymControl.Instance.PnPageContainer.Controls.Clear();
                OpenFormAndUser.OpenUserControl(new UsStudent(), "UsStudent");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usSaveStudent_ClientSizeChanged(object sender, EventArgs e)
        {
            if(this.Width > 617)
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

                /* textbox  - Location*/

                txtId.Location = new Point(57, 54);
                txtName.Location = new Point(57, 117);
                txtCPF.Location = new Point(768, 117);
                dtBirth.Location = new Point(57, 188);
                txtCEP.Location = new Point(228, 188);
                txtDistrict.Location = new Point(478, 188);
                txtAddress.Location = new Point(57, 262);
                ndNumber.Location = new Point(490, 261);
                txtCity.Location = new Point(600, 262);
                cbState.Location = new Point(1009, 260);
                

                /* Buttons - Location */
                btnCancel.Location = new Point(189, 324);
                btnSave.Location = new Point(57, 324);
                btnSearchCep.Location = new Point(355, 183);
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
                lblCPF.Location = new Point(27, 161);
                lblBirth.Location = new Point(183, 161);
                lblCEP.Location = new Point(27, 229);
                lblDistrict.Location = new Point(268, 229);
                lblAddress.Location = new Point(18, 297);
                lblNumber.Location = new Point(458, 297);
                lblCity.Location = new Point(18, 363);
                lblState.Location = new Point(456, 363);

                /* textbox  - Location*/

                txtId.Location = new Point(22, 56);
                txtName.Location = new Point(22, 119);
                txtCPF.Location = new Point(22, 187);
                dtBirth.Location = new Point(187, 187);
                txtCEP.Location = new Point(22, 255);
                txtDistrict.Location = new Point(272, 255);
                txtAddress.Location = new Point(22, 323);
                ndNumber.Location = new Point(462, 321);
                txtCity.Location = new Point(22, 389);
                cbState.Location = new Point(460, 387);


                /* Buttons - Location */
                btnCancel.Location = new Point(154, 445);
                btnSave.Location = new Point(22, 445);
                btnSearchCep.Location = new Point(149, 250);
                btnOpenImage.Location = new Point(426, 165);

                /* pictbox - Location */
                pcPhoto.Location = new Point(430, 24);

                /* textbox  - Size*/

                txtName.Size = new Size(378, 26);
                txtDistrict.Size = new Size(294, 26);
                txtCity.Size = new Size(427, 26);
            }
        }

        string image = null;
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
    }
}
