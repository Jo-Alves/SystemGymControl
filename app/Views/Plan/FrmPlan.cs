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
    public partial class FrmPlan : Form
    {
        Package package = new Package();
        Modality modality = new Modality();
        Plan plan = new Plan();
        Student student = new Student();

        public FrmPlan()
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
            if(e.RowIndex > -1)
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
            OpenForm.ShowForm(new FrmOptionsPlan(), this);
        }

        private void btnPurchasePlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigoStudent.Text))
                {
                    MessageBox.Show("Informe os dados do aluno!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNameStudent.Focus();
                    return;
                }
                else if (!checkedDgvSelected())
                {
                    MessageBox.Show("Selecione o plano que o aluno irá adquirir!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (cbModalities.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione a modalidade!", "System Gym Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbModalities.Focus();
                    return;
                }

                SavePlan();

                SaveModality();

                OpenForm.ShowForm(new FrmOptionsPlan(), this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            modality._planID = plan.GetMaxId();
            modality.Save();
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
