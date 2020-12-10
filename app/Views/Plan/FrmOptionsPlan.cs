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
    public partial class FrmOptionsPlan : Form
    {
        public FrmOptionsPlan()
        {
            InitializeComponent();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Package().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPlan(), this);
                else
                    MessageBox.Show("Não há pacotes cadastrado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPausedPlan_Click(object sender, EventArgs e)
        {
            try
            {
                //if (new Package().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPackage(), this);
                //else
                    //OpenForm.ShowForm(new FrmSavePackage(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}