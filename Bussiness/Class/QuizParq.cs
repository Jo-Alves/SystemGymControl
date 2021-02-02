using System.Data;

namespace Bussiness
{
    public class QuizParq
    {
        private int id;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string answer5;
        private string answer6;
        private string answer7;
        private int studentID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }
        public string _answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }
        public string _answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }
        public string _answer4
        {
            get { return answer4; }
            set { answer4 = value; }
        }
        public string _answer5
        {
            get { return answer5; }
            set { answer5 = value; }
        }
        public string _answer6
        {
            get { return answer6; }
            set { answer6 = value; }
        }
        public string _answer7
        {
            get { return answer7; }
            set { answer7 = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save()
        {
            new Database.QuizParq()
            {
                _id = this._id,
                _answer1 = this._answer1,
                _answer2 = this._answer2,
                _answer3 = this._answer3,
                _answer4 = this.answer4,
                _answer5 = this._answer5,
                _answer6 = this._answer6,
                _answer7 = this._answer7,
                _studentID = this._studentID
            }
            .Save();
        }

        public DataTable GetParQId(int studentID)
        {
            return new Database.QuizParq().GetParQId(studentID);
        }
    }
}
