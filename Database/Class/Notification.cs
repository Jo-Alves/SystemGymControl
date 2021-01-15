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

        public string _dateNotification {
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

        public void MarctMessage(int id)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();

                    _sql = "UPDATE notification SET situation = @situation WHERE id = @id";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@situation", _situation);
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
