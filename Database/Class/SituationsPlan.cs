using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class SituationsPlan
    {
        private int id;
        private string situation;
        private int planID;


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
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO situations_plan VALUES (@situation, @planID)";
            else
                _sql = "UPDATE situations_plan SET situation = @situation WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@situation", _situation);
            command.Parameters.AddWithValue("@planID", _planID);
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
                _sql = "SELECT * FROM situations_plan WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _situation = dr["situation"].ToString();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
