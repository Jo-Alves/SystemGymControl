using System.Data;
using System.Data.SqlClient;

namespace SystemGymControl
{
    class ResponsiblesStudent : Person
    {
        private string kinship;
        private int studentID;
        string _sql;

        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
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
            if (_id > 0)
                _sql = "INSERT INTO responsibles_student VALUES (@name, @cpf, @kinship, @studentID)";
            else
                _sql = "UPDATE responsibles_student SET name = @name, cpf = @cpf, kinship = @kinship, student_id = @studentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@name", _name);
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

        public override DataTable SearchID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM students INNER JOIN responsibles_student ON responsibles_student.student_id = students.id WHERE students.id = @studentID";
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