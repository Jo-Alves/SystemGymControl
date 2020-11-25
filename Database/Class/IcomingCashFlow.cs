using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class IcomingCashFlow
    {
        private int id;
        private string entryDate;
        private string entryTime;
        private decimal valueMoney;
        private decimal valueCard;
        private int cashFlowID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
         public string _entryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        } 
        public string _entryTime
        {
            get { return entryTime; }
            set { entryTime = value; }
        }
         public decimal _valueMoney
        {
            get { return valueMoney; }
            set { valueMoney = value; }
        }  
        public decimal _valueCard
        {
            get { return valueCard; }
            set { valueCard = value; }
        }
        public int _cashFlowID
        {
            get { return cashFlowID; }
            set { cashFlowID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO icoming_cash_flow VALUES (@entryDate, @entryTime, @valueMoney, @valueCard, @closingTime, @cashFlowID)";
            else
                _sql = "UPDATE icoming_cash_flow SET entry_date = @entryDate, entry_time = @entryTime, value_money = @valueMoney, value_card = @valueCard, cash_flow_id = @cashFlowID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@entryDate", _entryDate);
            command.Parameters.AddWithValue("@entryTime", _entryTime);
            command.Parameters.AddWithValue("@valueMoney", _valueMoney);
            command.Parameters.AddWithValue("@valueCard", _valueCard);
            command.Parameters.AddWithValue("@cashFlowID", _cashFlowID);
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
                _sql = "SELECT * FROM icoming_cash_flow WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _entryDate = dr["entry_date"].ToString();
                    _entryTime = dr["entry_time"].ToString();
                    _valueCard = decimal.Parse(dr["value_card"].ToString());
                    _valueMoney = decimal.Parse(dr["value_money"].ToString());
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
                _sql = "SELECT * FROM icoming_cash_flow WHERE id = @id";
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
