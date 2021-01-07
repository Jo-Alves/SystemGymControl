using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmReportTipPassword : Form
    {
        string question, name;

        public FrmReportTipPassword()
        {
            InitializeComponent();
        }

        public FrmReportTipPassword(string name, string question)
        {
            InitializeComponent();
            this.name = name;
            this.question = question;
            txtQuestionSecurity.Text = question;
        }

        public string answerSecurity { get; set; }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Bussiness.User().CheckedAnswerSecurity(name, txtAnswerSecurity.Text.Trim()))
                {
                    var resetPassword = new FrmResetPassword(name);
                    resetPassword.ShowDialog();

                    if (resetPassword.hasBeenReset)
                        this.Close();
                }
                else
                    MessageBox.Show("A resposta está incorreta! Tente novamente...", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmReportTipPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
