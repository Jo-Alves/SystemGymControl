using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmPurchasePlan : Form
    {
        Package package = new Package();
        Modality modality = new Modality();
        Plan plan = new Plan();
        Student student = new Student();
        SituationsPlan situationsPlan = new SituationsPlan();
        Payment payment = new Payment();
        IcomingCashFlow icomingCashFlow = new IcomingCashFlow();

        public FrmPurchasePlan()
        {
            InitializeComponent();
            LoadDataPackages();
        }

        private void LoadDataPackages()
        {
            dgvDataPlan.Rows.Clear();

            DataTable DataPackages;

            if (string.IsNullOrEmpty(txtSearch.Text))
                DataPackages = package.SearchAllItemsAndPackage();
            else
                DataPackages = package.SearchDescriptionPackageAndItems(txtSearch.Text);

            foreach (DataRow dr in DataPackages.Rows)
            {
                int addRow = dgvDataPlan.Rows.Add();
                dgvDataPlan.Rows[addRow].Cells["id"].Value = dr["id"].ToString();
                dgvDataPlan.Rows[addRow].Cells["description"].Value = dr["description"].ToString();
                dgvDataPlan.Rows[addRow].Cells["duration"].Value = dr["duration"].ToString();
                dgvDataPlan.Rows[addRow].Cells["period"].Value = dr["period"].ToString();
                dgvDataPlan.Rows[addRow].Cells["value"].Value = $"R$ {dr["value"].ToString()}";
                dgvDataPlan.Rows[addRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItems"].ToString();

                dgvDataPlan.Rows[addRow].MinimumHeight = 30;
            }

            dgvDataPlan.ClearSelection();
        }

        int idItems;
        string formPayment;

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idItems = int.Parse(dgvDataPlan.CurrentRow.Cells["idItemsPackage"].Value.ToString());
                formPayment = dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString();
                SetTerminalPeriod(dgvDataPlan.CurrentRow.Cells["period"].Value.ToString());
            }
        }

        string dateTerminalPlan = "";

        private void SetTerminalPeriod(string periodPackage)
        {
            DateTime dateNow = DateTime.Parse(DateTime.Now.ToShortDateString());
            lblDateTerminalPlan.Visible = true;
            TimeSpan time;

            switch (periodPackage.ToLower())
            {
                case "diário":
                    dateTerminalPlan = dateNow.ToShortDateString();
                    break;

                case "mensal":
                    time = dateNow.AddMonths(1) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;

                case "bimestral":
                    time = dateNow.AddMonths(2) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;

                case "trimestral":
                    time = dateNow.AddMonths(3) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;

                case "semestral":
                    time = dateNow.AddMonths(6) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;

                case "anual":
                    time = dateNow.AddYears(1) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays - 1).ToShortDateString();
                    break;

                case "quinzena":
                    time = dateNow.AddDays(15) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays).ToShortDateString();
                    break;

                case "quarentena":
                    time = dateNow.AddDays(40) - dateNow;
                    dateTerminalPlan = dateNow.AddDays(time.TotalDays).ToShortDateString();
                    break;
            }

            lblDateTerminalPlan.Text = $"Data de término do plano: {dateTerminalPlan}";
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (student.SearchAll().Rows.Count > 0)
            {
                FrmSearchStudent searchStudent = new FrmSearchStudent();
                searchStudent.ShowDialog();
                if (searchStudent.idStudent > 0)
                {
                    txtCodigoStudent.Text = searchStudent.idStudent.ToString();
                    txtNameStudent.Text = searchStudent.nameStudent;
                }
            }
            else
                MessageBox.Show("Não há aluno(a) cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (plan.SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPlans(), this);
                else
                    OpenForm.ShowForm(new FrmHome(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        FrmCashInPayment cashInPayment;
        FrmCardInPayment cardInPayment;
        DateTime datePlan;
        private void btnPurchasePlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                decimal valuePackage = decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(dgvDataPlan.CurrentRow.Cells["value"].Value.ToString()));

                if (plan.ModalitiesBeforePlanTerminalCurrentEqual(int.Parse(txtCodigoStudent.Text), cbModalities.Text))
                {
                    MessageBox.Show("O aluno não pode fazer a mesma modalidade antes do fim do plano!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (formPayment.ToLower() == "dinheiro")
                {
                    cashInPayment = new FrmCashInPayment(valuePackage);

                    cashInPayment.ShowDialog();

                    if (!cashInPayment.paymentCancel) return;
                }
                else
                {
                    cardInPayment = new FrmCardInPayment(valuePackage, int.Parse(dgvDataPlan.CurrentRow.Cells["duration"].Value.ToString()), dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString(), dgvDataPlan.CurrentRow.Cells["period"].Value.ToString());
                    cardInPayment.ShowDialog();

                    if (!cardInPayment.paymentCancel) return;
                }
                datePlan = DateTime.Now;

                PurchasePlan();

                OpenForm.ShowForm(new FrmPlans(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            bool isValited = false;

            if (string.IsNullOrWhiteSpace(txtCodigoStudent.Text))
            {
                MessageBox.Show("Informe os dados do aluno!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNameStudent.Focus();
            }
            else if (!checkedDgvSelected())
            {
                MessageBox.Show("Selecione o plano que o aluno irá adquirir!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbModalities.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a modalidade!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbModalities.Focus();
            }
            else
                isValited = true;

            return isValited;
        }

        private void PurchasePlan()
        {
            plan._datePurchasePlan = datePlan.ToShortDateString();
            plan._timePurchasePlan = datePlan.ToLongTimeString();
            plan._dateTerminalPlan = dateTerminalPlan;
            plan._itemsPackageID = idItems;
            plan._studentID = int.Parse(txtCodigoStudent.Text);



            modality._description = cbModalities.Text;

            situationsPlan._situation = "Ativo";
            situationsPlan._observation = "";
            situationsPlan._deactivationDate = "";

            DataTable dataCardPayment = null;

            payment._numberPortion = 1;
            string periodPackage = dgvDataPlan.CurrentRow.Cells["period"].Value.ToString().ToLower();

            if (formPayment.ToLower() == "dinheiro")
            {
                payment._valueTotal = cashInPayment.valueDiscount;
                payment._valueDiscount = cashInPayment.discountMoney;
                payment._paymentOnAccount = "yes";
                icomingCashFlow._valueMoney = payment._valueTotal;
            }
            else
            {
                dataCardPayment = cardInPayment.dataPortion;
            }

            payment._formPayment = formPayment;
            payment._payday = datePlan.ToShortDateString();
            payment._paymentTime = datePlan.ToLongTimeString();

            icomingCashFlow._valueCard = 0.00M;
            icomingCashFlow._entryDate = datePlan.ToShortDateString();
            icomingCashFlow._entryTime = datePlan.ToLongTimeString();
            icomingCashFlow._cashFlowID = FrmGymControl.Instance._IdCashFlow;
            plan.Save(modality, situationsPlan, dataCardPayment, payment, formPayment, periodPackage, icomingCashFlow);
        }

        private bool checkedDgvSelected()
        {
            bool isDgvSelected = false;

            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                if (row.Selected)
                {
                    isDgvSelected = true;
                    break;
                }
            }

            return isDgvSelected;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataPackages();
        }
    }
}
