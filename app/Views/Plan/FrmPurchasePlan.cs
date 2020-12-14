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
            }
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

        private void btnPurchasePlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                if (dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString().ToLower() == "dinheiro" || dgvDataPlan.CurrentRow.Cells["formOfPayment"].Value.ToString().ToLower() == "cheque")
                {
                    FrmCashInPayment cashInPayment = new FrmCashInPayment(decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(dgvDataPlan.CurrentRow.Cells["value"].Value.ToString())));

                    cashInPayment.ShowDialog();

                    if (!cashInPayment.paymentCancel) return;
                }

                return;
               

                SavePlan();

                idMaxPlan = plan.GetMaxId();

                SaveModality();

                SaveSituationPlan();

                OpenForm.ShowForm(new FrmPlan(), this);
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

        int idMaxPlan;

        private void SavePlan()
        {
            plan._datePurchasePlan = DateTime.Now.ToShortDateString();
            plan._timePurchasePlan = DateTime.Now.ToLongTimeString();
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
