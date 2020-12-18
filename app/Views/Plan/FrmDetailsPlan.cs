using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmDetailsPlan : Form
    {
        int idSituationPlan, idPlan, idStudent;
        string situationPlan;

        public FrmDetailsPlan()
        {
            InitializeComponent();
        }
        DataTable dataPlan, dataStudent;

        public FrmDetailsPlan(int idPlan, int idStudent)
        {
            InitializeComponent();
            this.idPlan = idPlan;
            this.idStudent = idStudent;

            try
            {
                LoadFields();

                idSituationPlan = int.Parse(dataPlan.Rows[0]["idSituationPlan"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFields()
        {
            dataPlan = new Bussiness.Plan().SearchID(idPlan);
            dataStudent = new Bussiness.Student().SearchID(idStudent);

            txtId.Text = dataStudent.Rows[0]["id"].ToString();
            txtName.Text = dataStudent.Rows[0]["name"].ToString();
            txtCPF.Text = dataStudent.Rows[0]["cpf"].ToString();
            txtBirth.Text = dataStudent.Rows[0]["birth"].ToString();
            if (!string.IsNullOrEmpty(dataStudent.Rows[0]["photo"].ToString()))
            {
                pcPhoto.ImageLocation = dataStudent.Rows[0]["photo"].ToString();
                pcPhoto.Load();
            }
            txtCEP.Text = dataStudent.Rows[0]["cep"].ToString();
            txtDistrict.Text = dataStudent.Rows[0]["district"].ToString();
            txtAddress.Text = dataStudent.Rows[0]["address"].ToString();
            txtNumber.Text = dataStudent.Rows[0]["number"].ToString();
            txtCity.Text = dataStudent.Rows[0]["city"].ToString();
            txtState.Text = dataStudent.Rows[0]["state"].ToString();
            txtPhone.Text = dataStudent.Rows[0]["phone"].ToString();
            txtEmail.Text = dataStudent.Rows[0]["email"].ToString();

            txtDatePurchasePlan.Text = dataPlan.Rows[0]["date_purchase_plan"].ToString();
            txtTimePurchasePlan.Text = dataPlan.Rows[0]["time_purchase_plan"].ToString();
            txtModality.Text = dataPlan.Rows[0]["descriptionModality"].ToString();
            txtPackage.Text = dataPlan.Rows[0]["descriptionPackage"].ToString();
            txtValue.Text = $"R$ {dataPlan.Rows[0]["valueItemsPackage"].ToString()}";
            txtFormOfPayment.Text = dataPlan.Rows[0]["descriptionFormOfPayment"].ToString();
            txtDateDeactive.Text = dataPlan.Rows[0]["deactivation_date"].ToString();

            string columnDateTerminal = "";
            if (string.IsNullOrEmpty(dataPlan.Rows[0]["date_terminal_plan_last"].ToString()))
                columnDateTerminal = "date_terminal_plan";
            else
                columnDateTerminal = "date_terminal_plan_last";

            txtDateTerminalPlan.Text = dataPlan.Rows[0][columnDateTerminal].ToString();
            situationPlan = dataPlan.Rows[0]["situation"].ToString();

            if (situationPlan.ToLower() == "ativo")
            {
                rbActive.Checked = true;
                pnObservation.Visible = false;
            }
            else
            {
                lblDateDeactive.Visible = true;
                txtDateDeactive.Visible = true;
                rbInactive.Checked = true;
                descriptionObservation = dataPlan.Rows[0]["observation"].ToString();
                txtObservation.Text = descriptionObservation;
            }

        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            EnabledButtonSave(rbActive);
            lblDateDeactive.Visible = false;
            txtDateDeactive.Visible = false;
            pnObservation.Visible = false;
        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            EnabledButtonSave(rbInactive);
            if (!string.IsNullOrEmpty(txtDateDeactive.Text))
            {
                lblDateDeactive.Visible = true;
                txtDateDeactive.Visible = true;
            }
            pnObservation.Visible = true;
        }

        private void EnabledButtonSave(RadioButton radio)
        {
            if (situationPlan.ToLower() != radio.Text.ToLower())
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        string descriptionObservation = "";

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateFieldObservation()) return;

            Bussiness.SituationsPlan situations = new Bussiness.SituationsPlan();
            if (rbActive.Checked)
                txtObservation.Clear();

            situations._id = idSituationPlan;
            situations._observation = txtObservation.Text.Trim();
            if (rbActive.Checked)
            {
                situations._situation = rbActive.Text;
                situations._deactivationDate = "";
            }
            else
            {
                situations._situation = rbInactive.Text;
                situations._deactivationDate = DateTime.Now.ToShortDateString();
            }

            situations.Save();
            Bussiness.Plan plan = new Bussiness.Plan();

            if (rbInactive.Checked)
            {
                descriptionObservation = txtObservation.Text.Trim();
                lblDateDeactive.Visible = true;
                txtDateDeactive.Visible = true;
                txtDateDeactive.Text = DateTime.Now.ToShortDateString();
                plan._dateTerminalPlanLast = txtDateTerminalPlan.Text;
                plan.UpdateTerminalPlanLast(idPlan);
            }

            btnSave.Enabled = false;
            LoadFields();
        }

        private bool ValidateFieldObservation()
        {
            bool isFieldWhite = false;

            if (string.IsNullOrWhiteSpace(txtObservation.Text) && rbInactive.Checked)
            {
                MessageBox.Show("Descreva  por que o plano está sendo desativado.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtObservation.Focus();
            }
            else
                isFieldWhite = true;

            return isFieldWhite;
        }

        private void txtObservation_TextChanged(object sender, EventArgs e)
        {
            if (txtObservation.Text == descriptionObservation && situationPlan.ToLower() == "inativo")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        bool linkMoreDetailsClicked = false;

        private void linkMoreDetails_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkMoreDetailsClicked = !linkMoreDetailsClicked;
            switch (linkMoreDetailsClicked)
            {
                case true:
                    pnMoreDetailsStudent.Visible = true;
                    linkMoreDetails.Text = "Menos Detalhes";
                    break;
                case false:
                    pnMoreDetailsStudent.Visible = false;
                    linkMoreDetails.Text = "Mais Detalhes";
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmPlan(), this);
        }
    }
}