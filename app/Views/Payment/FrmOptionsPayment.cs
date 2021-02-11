using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmOptionsPayment : Form
    {
        public FrmOptionsPayment()
        {
            InitializeComponent();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (new Student().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmStudents(), this);
                else
                    OpenForm.ShowForm(new FrmSaveStudent(), this);

                FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Cadastro - Aluno";
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
                    OpenForm.ShowForm(new FrmPackages(), this);
                else
                    OpenForm.ShowForm(new FrmSavePackage(), this);

                FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Cadastro - Pacote";
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
                    OpenForm.ShowForm(new FrmUsers(), this);
                else
                    OpenForm.ShowForm(new FrmSaveUser(), this);

                FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Cadastro - Usuário";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (new Plan().SearchAllWhereMoney().Rows.Count == 0)
            {
                MessageBox.Show("Não há aquisição do plano mensal registrados no sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Pagamentos Mensais";
            OpenForm.ShowForm(new FrmPayments(), this);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (new Payment().GetHistoryPaymentDifferencesMonthly().Rows.Count == 0)
            {
                MessageBox.Show("Não há aquisição de outros planos registrados no sistema!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmGymControl.Instance._lblTitle.Text = "EXPLOSION ACADEMIA --- Histórico de Pagamentos";
            OpenForm.ShowForm(new FrmPaymentHistory(), this);
        }
    }
}