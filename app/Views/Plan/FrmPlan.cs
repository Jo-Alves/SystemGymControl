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
        Student student = new Student();

        public FrmPlan()
        {
            InitializeComponent();
            LoadDataPackages();
        }

        private void LoadDataPackages()
        {
            var DataPackages = package.SearchAllItemsAndPackage();

            foreach(DataRow dr in DataPackages.Rows)
            {
                int addRow = dgvDataPlan.Rows.Add();
                dgvDataPlan.Rows[addRow].Cells["id"].Value = dr["id"].ToString();
                dgvDataPlan.Rows[addRow].Cells["description"].Value = dr["description"].ToString();
                dgvDataPlan.Rows[addRow].Cells["duration"].Value = dr["duration"].ToString();
                dgvDataPlan.Rows[addRow].Cells["period"].Value = dr["period"].ToString();
                dgvDataPlan.Rows[addRow].Cells["value"].Value = $"R$ {dr["value"].ToString()}";
                dgvDataPlan.Rows[addRow].Cells["formOfPayment"].Value = dr["formOfPayment"].ToString();

                dgvDataPlan.Rows[addRow].MinimumHeight = 30;
            }
            dgvDataPlan.ClearSelection();
        }

        public decimal valuePackage { get; set; }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                valuePackage = decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(dgvDataPlan.CurrentRow.Cells["value"].Value.ToString()));
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
                MessageBox.Show("Não há aluno cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmOptionsPlan(), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameStudent.Text))
            {
                MessageBox.Show("Infome o Aluno que irá adquirir o plano!", "Systeme GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (valuePackage == 0)
            {
                MessageBox.Show("Selecione o Pacote!", "Systeme GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmCashInPayment cashInPayment = new FrmCashInPayment(valuePackage);
            cashInPayment.ShowDialog();
        }
    }
}
