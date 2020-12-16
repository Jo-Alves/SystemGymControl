using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        CashPayment cashPayment = new CashPayment();

        public FrmPurchasePlan()
        {
            InitializeComponent();
            LoadDataPackages();
            lblDateTerminalPlan.Text = $"Data de término do plano: {DateTime.Now.ToShortDateString()}";
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
                dgvDataPlan.Rows[addRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItems"].ToString();

                dgvDataPlan.Rows[addRow].MinimumHeight = 30;
            }

            dgvDataPlan.ClearSelection();
        }

        int idItems;
        

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idItems = int.Parse(dgvDataPlan.CurrentRow.Cells["idItemsPackage"].Value.ToString());
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
                    OpenForm.ShowForm(new FrmPlan(), this);
                else
                    OpenForm.ShowForm(new FrmHome(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        FrmCashInPayment cashInPayment;
        string datePlan = DateTime.Now.ToShortDateString(), timePlan = DateTime.Now.ToLongTimeString();
        private void btnPurchasePlan_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidateFields())
                    return;

                if (dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString().ToLower() == "dinheiro" || dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString().ToLower() == "cheque")
                {
                    cashInPayment = new FrmCashInPayment(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(dgvDataPlan.CurrentRow.Cells["value"].Value.ToString())));

                    cashInPayment.ShowDialog();

                    if (!cashInPayment.paymentCancel) return;



                }

                SavePlan();

                idMaxPlan = plan.GetMaxId();

                SaveModality();

                SaveSituationPlan();

                SaveCashPayment(cashInPayment.DiscountMoney, cashInPayment.valueDiscount);
                OpenForm.ShowForm(new FrmPlan(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCashPayment(decimal discountMoney, decimal valueDiscount)
        {
            cashPayment._valueTotal = valueDiscount;
            cashPayment._valueDiscount = discountMoney;
            cashPayment._payday = datePlan;
            cashPayment._paymentTime = timePlan;
            cashPayment._planID = idMaxPlan;
            cashPayment.Save();
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

        int idMaxPlan;

        private void SavePlan()
        {
            plan._datePurchasePlan = datePlan;
            plan._timePurchasePlan = timePlan;
            plan._dateTerminalPlan = dateTerminalPlan;
            plan._itemsPackageID = idItems;
            plan._studentID = int.Parse(txtCodigoStudent.Text);
            plan.Save();
        }

        private void SaveModality()
        {
            modality._description = cbModalities.Text;
            modality._planID = idMaxPlan;
            modality.Save();
        }
        
        private void SaveSituationPlan()
        {
            situationsPlan._situation = "Ativo";
            situationsPlan._observation = "";
            situationsPlan._planID = idMaxPlan;
            situationsPlan.Save();
        }

        private bool checkedDgvSelected()
        {
            bool isDgvSelected = false;

            foreach(DataGridViewRow row in dgvDataPlan.Rows)
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
