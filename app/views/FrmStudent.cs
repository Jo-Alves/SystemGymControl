using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGynControl
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvDateStudent.Rows.Add("1", "Valdirene Aparecida Ferreira", "99090", "10/10/1000", "99090", "99090", "99090", "99090", "99090", "99090", "99090");
        }
    }
}
