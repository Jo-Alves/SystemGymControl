using System.Data;
using System.Data.SqlClient;

namespace SystemGymControl
{
    class User
    {
        private int id;
        private string user;
        private string password;
        private string question;
        private string answer;
        private string avatar;
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
        public string _question
        {
            get { return question; }
            set { question = value; }
        }
        public string _answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public string _avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public string _dateRegistion
        {
            get { return dateRegistion; }
            set { dateRegistion = value; }
        }


        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO users VALUES (@user, @password, @question, @answer, @avatar, @dateRegistion)";
            else
                _sql = "UPDATE users SET user = @user, password = @password, question = @question, answer = @answer, avatar = @avatar, dateRegistion = @dateRegistion WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@user", _user);
            command.Parameters.AddWithValue("@question", _question);
            command.Parameters.AddWithValue("@answer", _answer);
            command.Parameters.AddWithValue("@avatar", _avatar);
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
            _sql = "DELETE FROM users WHERE user = @user and password = @password";
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

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM users";
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

        public bool SearchUser()
        {
            bool existUser = false;

            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
 
            try
            {
                _sql = "SELECT * FROM users WHERE user = @user and password = @password";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@user", _user);
                command.Parameters.AddWithValue("@password", _password);
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    _id = int.Parse(dr["id"].ToString());
                    existUser = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return existUser;
        }
    }
}
