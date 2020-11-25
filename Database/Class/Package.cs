using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class Package
    {
        private int id;
        private string description;
        private int duration;
        private int team;

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
        public int _duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public int _team
        {
            get { return team; }
            set { team = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO packages VALUES (@description, @duration, @team)";
            else
                _sql = "UPDATE packages SET description = @description, duration = @duration, team = @team WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@description", _description);
            command.Parameters.AddWithValue("@duration", _duration);
            command.Parameters.AddWithValue("@team", _team);
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

        public void Delete()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            _sql = "DELETE FROM packages WHERE id = @id";
            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
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

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM packages";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", _id);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw;
            }
        }


        public void SearchID()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            try
            {
                connection.Open();
                _sql = "SELECT * FROM packages WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _description = dr["description"].ToString();
                    _duration = int.Parse(dr["duration"].ToString());
                    _team = int.Parse(dr["team"].ToString());
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
