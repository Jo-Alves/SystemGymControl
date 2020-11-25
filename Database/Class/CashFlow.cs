using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class CashFlow
    {
        private int id;
        private string openingTime;
        private decimal cashValueTotal;
        private decimal outputValueTotal;
        private string closingDate;
        private string closingTime;
        private int userID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
         public string _openingTime
        {
            get { return openingTime; }
            set { openingTime = value; }
        } 
        public decimal _cashValueTotal
        {
            get { return cashValueTotal; }
            set { cashValueTotal = value; }
        }
         public decimal _outputValueTotal
        {
            get { return outputValueTotal; }
            set { outputValueTotal = value; }
        }  
        public string _closingDate
        {
            get { return closingDate; }
            set { closingDate = value; }
        }
        public string _closingTime
        {
            get { return closingTime; }
            set { closingTime = value; }
        }
        public int _userID
        {
            get { return userID; }
            set { userID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO cash_flow VALUES (@openingTime, @cashValueTotal, @outputValueTotal, @closingDate, @closingTime, @userID)";
            else
                _sql = "UPDATE cash_flow SET opening_time = @openingTime, cash_value_total = @cashValueTotal, output_value_total = @outputValueTotal, closing_date = @closingDate, closing_time = @closingTime, user_id = @userID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@openingTime", _openingTime);
            command.Parameters.AddWithValue("@cashValueTotal", _cashValueTotal);
            command.Parameters.AddWithValue("@outputValueTotal", _outputValueTotal);
            command.Parameters.AddWithValue("@closingDate", _closingDate);
            command.Parameters.AddWithValue("@closingTime", _closingTime);
            command.Parameters.AddWithValue("@userID", _userID);
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
                _sql = "SELECT * FROM cash_flow WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _openingTime = dr["opening_time"].ToString();
                    _cashValueTotal = decimal.Parse(dr["cash_value_total"].ToString());
                    _outputValueTotal = decimal.Parse(dr["output_value_total"].ToString());
                    _closingDate = dr["closing_date"].ToString();
                    _closingTime = dr["closing_time"].ToString();

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
                _sql = "SELECT * FROM cash_flow WHERE id = @id";
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
