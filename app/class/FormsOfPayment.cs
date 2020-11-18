using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl
{
    class FormsOfPayments
    {
        private int id;
        private string description;
        private int paymentID;

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
        public int _paymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO forms_of_payment VALUES (@description, @paymentID)";
            else
                _sql = "UPDATE forms_of_payment SET description = @description, payment_id = @paymentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@description", _description);
            command.Parameters.AddWithValue("@paymentID", _paymentID);
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
                _sql = "SELECT * FROM forms_of_payment WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
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
                _sql = "SELECT * FROM forms_of_payment WHERE id = @id";
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
