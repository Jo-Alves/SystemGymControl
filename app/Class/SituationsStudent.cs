using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl.Class
{
    class SituationsStudent
    {
        private int id;
        private string situation;
        private string observation;
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
        public string _observation
        {
            get { return observation; }
            set { observation = value; }
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
                _sql = "INSERT INTO situations_student VALUES (@situation, @observation, @studentID)";
            else
                _sql = "UPDATE situations_students SET situation = @situation, observation = @observation, student_id = @studentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@observation", _observation);
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

        public void SearchID()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            try
            {
                connection.Open();
                _sql = "SELECT * FROM situations_student WHERE student_id = @studentID";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@studentID", _studentID);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _situation = dr["situation"].ToString();
                    _observation = dr["observation"].ToString();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
