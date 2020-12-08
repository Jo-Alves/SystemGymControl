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
    public partial class FrmOptionsSave : Form
    {
        public FrmOptionsSave()
        {
            InitializeComponent();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (new Student().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmStudent(), this);
                else
                    OpenForm.ShowForm(new FrmSaveStudent(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Package().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPackage(), this);
                else
                    OpenForm.ShowForm(new FrmSavePackage(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (new User().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmUser(), this);
                else
                    OpenForm.ShowForm(new FrmSaveUser(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}