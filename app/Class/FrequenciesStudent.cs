using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl.Class
{
    class FrequenciesStudent
    {
        private int id;
        private string situation;
        private string date;
        private int studentID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _situation
        {
            get { return situation; }
            set { situation = value; }
        }
        public string _date
        {
            get { return date; }
            set { date = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO frequencies_student VALUES (@situation, @date, @studentID)";
            else
                _sql = "UPDATE frequencies_student SET situation = @situation, date = @date, student_id = @studentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@date", _date);
            command.Parameters.AddWithValue("@studentID", _studentID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SearchID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM frequencies_student WHERE student_id = @studentID";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@studentID", _studentID);
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
