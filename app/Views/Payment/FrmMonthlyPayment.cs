using System.Data;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmMonthlyPayment : Form
    {
        Bussiness.Plan plan = new Bussiness.Plan();

        public FrmMonthlyPayment()
        {
            InitializeComponent();
        }

        public FrmMonthlyPayment(int idPlan)
        {
            InitializeComponent();
        }
    }
}
