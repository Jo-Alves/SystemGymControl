using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl
{
    class OutgoingCashFlow
    {
        private int id;
        private string exitDate;
        private string exitTime;
        private string descriptionExit;
        private decimal valueOutput;
        private int cashFlowID;

 // [exit_date] VARCHAR(10) NOT NULL,

 //   [exit_time] VARCHAR(10) NOT NULL,

 //   [description_exit] VARCHAR(MAX) NOT NULL,

 //   [value_output] DECIMAL(18,2) NOT NULL,

 //   [cash_flow_id] INT NOT NULL,

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
         public string _exitDate
        {
            get { return exitDate; }
            set { exitDate = value; }
        } 
        public string _exitTime
        {
            get { return exitTime; }
            set { exitTime = value; }
        }
         public string _descriptionExit
        {
            get { return descriptionExit; }
            set { descriptionExit = value; }
        }  
        public decimal _valueOutput
        {
            get { return valueOutput; }
            set { valueOutput = value; }
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
                _sql = "INSERT INTO outgoing_cash_flow VALUES (@exitDate, @exitTime, @descriptionExit, @valueOutput, @closingTime, @cashFlowID)";
            else
                _sql = "UPDATE outgoing_cash_flow SET exit_date = @exitDate, exit_time = @exitTime, description_exit = @descriptionExit, value_output = @valueOutput, cash_flow_id = @cashFlowID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@exitDate", _exitDate);
            command.Parameters.AddWithValue("@exitTime", _exitTime);
            command.Parameters.AddWithValue("@descriptionExit", _descriptionExit);
            command.Parameters.AddWithValue("@valueOutput", _valueOutput);
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
                _sql = "SELECT * FROM outgoing_cash_flow WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _exitDate = dr["exit_date"].ToString();
                    _exitTime = dr["exit_time"].ToString();
                    _valueOutput = decimal.Parse(dr["value_output"].ToString());
                    _descriptionExit = dr["description_exit"].ToString();
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
                _sql = "SELECT * FROM outgoing_cash_flow WHERE id = @id";
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
