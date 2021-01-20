using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Notification
    {
        private int id;
        private string situation;
        private string message;
        private string dateNotification;

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
        public string _message
        {
            get { return message; }
            set { message = value; }
        }

        public string _dateNotification
        {
            get { return dateNotification; }
            set { dateNotification = value; }
        }

        public void GerateMessage()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();

                    _sql = "INSERT INTO notification VALUES (@situation, @message, @dateNotification)";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@situation", _situation);
                    command.Parameters.AddWithValue("@message", _message);
                    command.Parameters.AddWithValue("@dateNotification", _dateNotification);

                    command.ExecuteNonQuery();

                }
                catch
                {
                    throw;
                }
            }
        }

        public void MarctMessage(int id, string situationNotification)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();

                    _sql = "UPDATE notification SET situation = @situation WHERE id = @id";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@situation", situationNotification);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable GetNotification()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM notification WHERE date_notification = '{DateTime.Now.ToShortDateString()}'";
                    var adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable GetDataNotificationNotRead()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM notification WHERE date_notification = '{DateTime.Now.ToShortDateString()}' AND situation <> 'Lida'";
                    var adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable GetSituationNotification(int id)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM notification WHERE id = @id";
                    var adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
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

        public DataTable SearchAll()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM notification";
                    var adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
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

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();

                    _sql = "DELETE FROM notification WHERE id = @id";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", id);

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
