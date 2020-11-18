using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl
{
    class Payment
    {
        private int id;
        private int portion;
        private string dueDate;
        private string payday;
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
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO payments VALUES (@portion, @dueDate, @payday, @planID)";
            else
                _sql = "UPDATE payments SET portions = @portion, dueDate = @dueDate, payday = @payday, plan_id = @planID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@portion", _portion);
            command.Parameters.AddWithValue("@dueDate", _dueDate);
            command.Parameters.AddWithValue("@payday", _payday);
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
                _sql = "SELECT * FROM payments WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _portion = int.Parse(dr["portion"].ToString());
                    _dueDate = dr["dueDate"].ToString();
                    _payday = dr["payday"].ToString();
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
        }

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
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
