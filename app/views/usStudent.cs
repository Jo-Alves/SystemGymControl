using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGynControl
{
    public partial class usStudent : UserControl
    {
        public usStudent()
        {
            InitializeComponent();
            LoadGrid();
            //DataGridViewRow row = dgvDateStudent.Rows[0];
            //row.Height = 45;
            //row.MinimumHeight = 45;
            dgvDateStudent.ClearSelection();
        }

        private void LoadGrid()
        {
            dgvDateStudent.Rows.Add("1", "Valdirene Aparecida Ferreira", "99090", "10/10/1000", "99090", "99090", "99090", "99090", "99090", "99090", Properties.Resources.icons8_pencil_25px, Properties.Resources.icons8_trash_25px);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if (!FrmGymControl.Instance.PnPageContainer.Controls.ContainsKey("usSaveStudent"))
            {
                usSaveStudent student = new usSaveStudent();
                student.Dock = DockStyle.Fill;
                FrmGymControl.Instance.PnPageContainer.Controls.Add(student);
            }

            FrmGymControl.Instance.PnPageContainer.Controls["usSaveStudent"].BringToFront();
        }
    }
}
