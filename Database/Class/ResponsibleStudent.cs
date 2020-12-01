using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class ResponsibleStudent : Person
    {
        private string kinship;
        private int studentID;
        string _sql;

        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        public override string _phone { get; set; }
        public string _kinship
        {
            get { return kinship; }
            set { kinship = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public override void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id == 0)
                _sql = "INSERT INTO responsibles_student VALUES (@name, @cpf, @kinship, @phone, @studentID)";
            else
                _sql = "UPDATE responsibles_student SET name = @name, cpf = @cpf, phone = @phone, kinship = @kinship, student_id = @studentID WHERE student_id = @studentID";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@name", _name);
            command.Parameters.AddWithValue("@phone", _phone);
            command.Parameters.AddWithValue("@cpf", _cpf);
            command.Parameters.AddWithValue("@kinship", _kinship);
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

        public override DataTable SearchID(int studentID)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM responsibles_student WHERE student_id = @studentID";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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