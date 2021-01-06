using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class User
    {
        private int id;
        private string name;
        private string user;
        private string email;
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
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public string _email
        {
            get { return email; }
            set { email = value; }
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
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO users VALUES (@name, @user, @email, @password, @question, @answer, @avatar, @dateRegistion)";
                else
                    _sql = "UPDATE users SET name = @name, name_user = @user, email = @email, password = @password, question = @question, answer = @answer, avatar = @avatar, date_registion = @dateRegistion WHERE name_user = @user";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@user", _user);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@email", _email);
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
            }
        }

        public bool CheckedEmailUserExist(string email)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM users WHERE email  = @email";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        return true;
                    else
                        return false;
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Delete(int idUser)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "DELETE FROM users WHERE id = @id";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", idUser);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable SearchAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
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
        }

        public DataTable SearchUser(string user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM users WHERE name_user LIKE '%{user}%'";
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
        
        public DataTable GetUserOrName(string user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM users WHERE name_user = @user OR email = @email";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@user", user);
                    adapter.SelectCommand.Parameters.AddWithValue("@email", user);
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

        public bool CheckedNameUserExist(string nameUser)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM users WHERE name_user  = @user";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@user", nameUser);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        return true;
                    else
                        return false;
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable SearchID(int idUser)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM users WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idUser);
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

        public bool ExitNameOrUser(string user)
        {
            bool exitUser = false;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM users WHERE email = @email OR name_user = @user";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@email", user);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        exitUser = true;
                }
                catch
                {
                    throw;
                }
            }

            return exitUser;
        }

        public bool Logout(string user, string password)
        {
            bool existUser = false;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM users WHERE email = @email OR name_user = @user AND password = @password";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@email", user);
                    command.Parameters.AddWithValue("@password", password);
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
            }

            return existUser;
        }

        public bool CheckedAnswerSecurity(string name, string answer)
        {
            bool answerCorrect = false;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM users WHERE (name_user = @user OR email = @email) AND answer = @answer";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@user", name);
                    command.Parameters.AddWithValue("@email", name);
                    command.Parameters.AddWithValue("@answer", answer);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {                       
                        answerCorrect = true;
                    }
                }
                catch
                {
                    throw;
                }
            }

            return answerCorrect;
        }

        public void ResetSecurity()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE users SET password = @password WHERE name_user = @name OR email = @email";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@name", _user);
                command.Parameters.AddWithValue("@email", _user);
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
            }
        }
    }
}
