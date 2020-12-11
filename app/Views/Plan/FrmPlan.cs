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
            //LoadDataPackages();
        }

        //private void LoadDataPackages()
        //{
        //    //dgvDataPlan.Rows.Clear();

        //    //DataTable DataPackages;
         
        //    //if (string.IsNullOrEmpty(txtSearch.Text))
        //    //    DataPackages = package.SearchAllItemsAndPackage();
        //    //else
        //    //    DataPackages = package.SearchDescriptionPackageAndItems(txtSearch.Text);

        //    //    foreach (DataRow dr in DataPackages.Rows)
        //    //    {
        //    //        int addRow = dgvDataPlan.Rows.Add();
        //    //        dgvDataPlan.Rows[addRow].Cells["id"].Value = dr["id"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["description"].Value = dr["description"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["duration"].Value = dr["duration"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["period"].Value = dr["period"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["value"].Value = $"R$ {dr["value"].ToString()}";
        //    //        dgvDataPlan.Rows[addRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();
        //    //        dgvDataPlan.Rows[addRow].Cells["idItemsPackage"].Value = dr["idItems"].ToString();

        //    //        dgvDataPlan.Rows[addRow].MinimumHeight = 30;
        //    //    }

        //    //dgvDataPlan.ClearSelection();
        //}

        //int idItems;

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                //idItems = int.Parse(dgvDataPlan.CurrentRow.Cells["idItemsPackage"].Value.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadDataPackages();
        }
    }
}
