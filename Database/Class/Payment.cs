using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Payment
    {
        private int id;
        private int portion;
        private string dueDate;
        private string payday;
        private string paymentTime;
        private int planID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _portion
        {
            get { return portion; }
            set { portion = value; }
        }
        public string _dueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public string _payday
        {
            get { return payday; }
            set { payday = value; }
        }
        public string _paymentTime
        {
            get { return paymentTime; }
            set { paymentTime = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO payments VALUES (@portion, @dueDate, @payday, @paymentTime, @planID)";
                else
                    _sql = "UPDATE payments SET portions = @portion, dueDate = @dueDate, payday = @payday, payment_time = @paymentTime, plan_id = @planID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@portion", _portion);
                command.Parameters.AddWithValue("@dueDate", _dueDate);
                command.Parameters.AddWithValue("@payday", _payday);
                command.Parameters.AddWithValue("@paymentTime", _paymentTime);
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
            }
        }

        public DataTable SearchID(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM payments WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM payments WHERE id = @id";
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
        }
    }
}
