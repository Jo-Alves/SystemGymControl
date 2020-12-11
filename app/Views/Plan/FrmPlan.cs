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

            DataTable dataPlan;

            if (string.IsNullOrEmpty(txtSearch.Text))
                dataPlan = plan.SearchAll();
            else
                dataPlan = plan.SearchPlanNameStudent(txtSearch.Text);

            foreach (DataRow dr in dataPlan.Rows)
            {
                int addRow = dgvDataPlan.Rows.Add();
                dgvDataPlan.Rows[addRow].Cells["showDetails"].Value = Properties.Resources.icons8_details_32px;
                dgvDataPlan.Rows[addRow].Cells["idPlan"].Value = dr["idPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["datePurchasePlan"].Value = dr["date_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["timePurchasePlan"].Value = dr["time_purchase_plan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idStudent"].Value = dr["idStudent"].ToString();
                dgvDataPlan.Rows[addRow].Cells["name"].Value = dr["name"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idModality"].Value = dr["idModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionModality"].Value = dr["descriptionModality"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItemsPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["valuePlan"].Value = $"R$ {dr["valueItemsPackage"].ToString()}";
                dgvDataPlan.Rows[addRow].Cells["idFormOfPayment"].Value = dr["idFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionFormOfPayment"].Value = dr["descriptionFormOfPayment"].ToString();
                dgvDataPlan.Rows[addRow].Cells["IdPackage"].Value = dr["IdPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["descriptionPackage"].Value = dr["descriptionPackage"].ToString();
                dgvDataPlan.Rows[addRow].Cells["idSituationPlan"].Value = dr["idSituationPlan"].ToString();
                dgvDataPlan.Rows[addRow].Cells["situation"].Value = dr["situation"].ToString();

                dgvDataPlan.Rows[addRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
        }

        //int idItems;

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                //idItems = int.Parse(dgvDataPlan.CurrentRow.Cells["idItemsPackage"].Value.ToString());
                dgvDataPlan.ClearSelection();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataPackages();
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                dgvDataPlan.ClearSelection();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            if (new Bussiness.Package().SearchAll().Rows.Count > 0)
                OpenForm.ShowForm(new FrmPurchasePlan(), this);
            else
                MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
