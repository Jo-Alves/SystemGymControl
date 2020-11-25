using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class modality
    {
        private int id;
        private string description;
        private int student_id;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _description
        {
            get { return description; }
            set { description = value; }
        }
        public int _studentID
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO modalities VALUES (@description, @student_id, @studentID)";
            else
                _sql = "UPDATE modalities SET description = @description, student_id = @studentID, student_id = @studentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@description", _description);
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
                _sql = "SELECT * FROM modalities WHERE student_id = @studentID";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@studentID", _studentID);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _description = dr["description"].ToString();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
