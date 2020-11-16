using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl
{
    class User
    {
        private int id;
        private string user;
        private string password;
        private string dateRegistion;

        string _sql;
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _user
        {
            get { return user; }
            set { user = value; }
        }
        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        public string _dateRegistion
        {
            get { return dateRegistion; }
            set { dateRegistion = value; }
        }


        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if(_id > 0)
                _sql = "INSERT INTO user VALUES (@user, @password, @dateRegistion)";
            else
                _sql = "UPDATE user SET user = @user, v = @password, dateRegistion = @dateRegistion WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@user", _user);
            command.Parameters.AddWithValue("@password", _password);
            command.Parameters.AddWithValue("@dateRegistion", _dateRegistion);
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
            _sql = "DELETE FROM user WHERE user = @user and password = @password";
            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@user", _user);
            command.Parameters.AddWithValue("@password", _password);
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


        public DataTable Search()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM user";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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
