using System.Data;
using System.Data.SqlClient;

namespace Database
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
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    if (_id == 0)
                        _sql = "INSERT INTO par_q VALUES (@answer1, @answer2, @answer3, @answer4, @answer5, @answer6, @answer7, @studentID)";
                    else
                        _sql = "UPDATE par_q SET answer1 = @answer1, answer2 = @answer2, answer3 = @answer3, answer4 = @answer4, answer5 = @answer5, answer6 = @answer6, answer7 = @answer7 where id = @ID";

                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", _id);
                    command.Parameters.AddWithValue("@answer1", _answer1);
                    command.Parameters.AddWithValue("@answer2", _answer2);
                    command.Parameters.AddWithValue("@answer3", _answer3);
                    command.Parameters.AddWithValue("@answer4", _answer4);
                    command.Parameters.AddWithValue("@answer5", _answer5);
                    command.Parameters.AddWithValue("@answer6", _answer6);
                    command.Parameters.AddWithValue("@answer7", _answer7);
                    command.Parameters.AddWithValue("@studentID", _studentID);

                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable GetParQId(int studentID)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM par_q WHERE student_id = @studentID";
                    var adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@studentID", studentID);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
