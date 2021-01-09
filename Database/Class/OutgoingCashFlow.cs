using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class OutgoingCashFlow
    {
        private int id;
        private string exitDate;
        private string exitTime;
        private string descriptionExit;
        private decimal valueOutput;
        private int cashFlowID;

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

        public void ExitMoney()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "INSERT INTO outgoing_cash_flow VALUES (@exitDate, @exitTime, @descriptionExit, @valueOutput, @cashFlowID)";
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(_sql, connection, transaction);
                command.Parameters.AddWithValue("@exitDate", _exitDate);
                command.Parameters.AddWithValue("@exitTime", _exitTime);
                command.Parameters.AddWithValue("@descriptionExit", _descriptionExit);
                command.Parameters.AddWithValue("@valueOutput", _valueOutput);
                command.Parameters.AddWithValue("@cashFlowID", _cashFlowID);
                try
                {
                    new CashFlow().UpdateValueTotalAndOutputValueOutgoingCash(_cashFlowID, valueOutput, transaction);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable SearchID(int idOutgoing)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM outgoing_cash_flow WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idOutgoing);
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
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT * FROM outgoing_cash_flow WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", _id);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
