using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class UsStudent : UserControl
    {
        public UsStudent()
        {
            InitializeComponent();
            LoadGrid();

            foreach (DataGridViewRow row in dgvDateStudent.Rows)
            {
                row.MinimumHeight = 45;
            }
          
            dgvDateStudent.ClearSelection();
        }

        private void LoadGrid()
        {
            dgvDateStudent.Rows.Add(Properties.Resources.icons8_pencil_25px, Properties.Resources.icons8_trash_25px, "1", "Valdirene Aparecida Ferreira", "99090", "10/10/1000", "99090", "99090", "99090", "99090", "99090", "99090");
            dgvDateStudent.Rows.Add(Properties.Resources.icons8_pencil_25px, Properties.Resources.icons8_trash_25px, "1", "Valdirene Aparecida Ferreira", "99090", "10/10/1000", "99090", "99090", "99090", "99090", "99090", "99090");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmGymControl.Instance.PnPageContainer.Controls.Clear();
            OpenFormAndUser.OpenUserControl(new UsSaveStudent(), "UsSaveStudent");
        }

        private void dgvDateStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDateStudent.ClearSelection();
            }
        }

        private void dgvDateStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDateStudent.ClearSelection();
            }
        }
    }
}
