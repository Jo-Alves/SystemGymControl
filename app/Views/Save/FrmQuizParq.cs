using Bussiness;
using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmQuizParq : Form
    {

        QuizParq quizParq = new QuizParq();
        int idParQ, studentId;

        public FrmQuizParq(int studentId, string name)
        {
            InitializeComponent();
            
            this.studentId = studentId;

            LoadLabelQuestion(name);
            LoadAnswerHaveDataQuizParQ();
        }

        private void LoadAnswerHaveDataQuizParQ()
        {
            try
            {
                var dataParQ = quizParq.GetParQId(studentId);
                if (dataParQ.Rows.Count > 0)
                {
                    if (dataParQ.Rows[0]["answer1"].ToString().ToLower().Equals("sim"))
                        rbYes1.Checked = true;
                    else
                        rbNot1.Checked = true;

                    if (dataParQ.Rows[0]["answer2"].ToString().ToLower().Equals("sim"))
                        rbYes2.Checked = true;
                    else
                        rbNot2.Checked = true;

                    if (dataParQ.Rows[0]["answer3"].ToString().ToLower().Equals("sim"))
                        rbYes3.Checked = true;
                    else
                        rbNot3.Checked = true;

                    if (dataParQ.Rows[0]["answer4"].ToString().ToLower().Equals("sim"))
                        rbYes4.Checked = true;
                    else
                        rbNot4.Checked = true;

                    if (dataParQ.Rows[0]["answer5"].ToString().ToLower().Equals("sim"))
                        rbYes5.Checked = true;
                    else
                        rbNot5.Checked = true;

                    if (dataParQ.Rows[0]["answer6"].ToString().ToLower().Equals("sim"))
                        rbYes6.Checked = true;
                    else
                        rbNot6.Checked = true;

                    if (dataParQ.Rows[0]["answer7"].ToString().ToLower().Equals("sim"))
                        rbYes7.Checked = true;
                    else
                        rbNot7.Checked = true;

                    idParQ = int.Parse(dataParQ.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLabelQuestion(string name)
        {
            lblQuestion1.Text = $"Algum médico já disse que você ({name.ToUpper()}) possui algum problema de coração e que só deveria realizar atividade física supervisionado por profissionais de saúde";
            lblQuestion2.Text = $"Você ({name.ToUpper()}) sente dores no peito quando pratica atividade física?  ";
            lblQuestion3.Text = $"No último mês, você ({name.ToUpper()}) sentiu dores no peito quando praticou atividade física?  ";
            lblQuestion4.Text = $"Você ({name.ToUpper()}) apresenta desequilíbrio devido à tontura e/ ou perda de consciência?";
            lblQuestion5.Text = $"Você ({name.ToUpper()}) possui algum problema ósseo ou articular que poderia ser piorado pela atividade física?";
            lblQuestion6.Text = $"Você ({name.ToUpper()}) toma atualmente algum medicamento para pressão arterial e/ou problema de coração?";
            lblQuestion7.Text = $"Sabe de alguma outra razão pela qual você ({name.ToUpper()}) não deve praticar atividade física?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmStudents(), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                quizParq._answer1 = rbYes1.Checked ? "Sim" : "Não";
                quizParq._answer2 = rbYes2.Checked ? "Sim" : "Não";
                quizParq._answer3 = rbYes3.Checked ? "Sim" : "Não";
                quizParq._answer4 = rbYes4.Checked ? "Sim" : "Não";
                quizParq._answer5 = rbYes5.Checked ? "Sim" : "Não";
                quizParq._answer6 = rbYes6.Checked ? "Sim" : "Não";
                quizParq._answer7 = rbYes7.Checked ? "Sim" : "Não";
                quizParq._id = idParQ;
                quizParq._studentID = studentId;
                quizParq.Save();
                OpenForm.ShowForm(new FrmStudents(), this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
