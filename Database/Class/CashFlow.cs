using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class CashFlow
    {
        private int id;
        private string openingDate;
        private string openingTime;
        private decimal cashValueTotal;
        private decimal outputValueTotal;
        private string closingDate;
        private string closingTime;        

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
        public string _openingDate
        {
            get { return openingDate; }
            set { openingDate = value; }
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

        public void Save(IcomingCashFlow icomingCashFlow)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                _sql = "INSERT INTO cash_flow (opening_date, opening_time, cash_value_total, output_value_total, closing_date, closing_time) VALUES (@openingDate, @openingTime, @cashValueTotal, @outputValueTotal, @closingDate, @closingTime); SELECT @@IDENTITY";

                SqlCommand command = new SqlCommand(_sql, connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@openingTime", _openingTime);
                command.Parameters.AddWithValue("@openingDate", _openingDate);
                command.Parameters.AddWithValue("@cashValueTotal", _cashValueTotal);
                command.Parameters.AddWithValue("@outputValueTotal", _outputValueTotal);
                command.Parameters.AddWithValue("@closingDate", _closingDate);
                command.Parameters.AddWithValue("@closingTime", _closingTime);
                try
                {
                    icomingCashFlow._cashFlowID = Convert.ToInt32(command.ExecuteScalar());
                    icomingCashFlow.Save(transaction);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable SearchID(int idCashFlow)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM cash_flow WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idCashFlow);
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

        public int GetMaxCashFlowID()
        {
            int maxId = 0;

            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                _sql = "SELECT MAX(id) FROM cash_flow WHERE closing_date = ''";
                SqlCommand command = new SqlCommand(_sql, connection);
                if (command.ExecuteScalar() != DBNull.Value)
                    maxId = int.Parse(command.ExecuteScalar().ToString());

            }

            return maxId;
        }

        public void GetDateOpeningCashFlow()
        {

            try
            {
                using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    connection.Open();
                    _sql = "SELECT id, opening_date FROM cash_flow WHERE closing_date = ''";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        _openingDate = dr["opening_date"].ToString();
                        _id = int.Parse(dr["id"].ToString());
                    }
                }
         
            }
            catch
            {
                throw;
            }
        }

        public void UpdateValueTotalCashFlow(int id, decimal valueTotal, SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE cash_flow SET cash_value_total = cash_value_total + @cashValueTotal WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@cashValueTotal", valueTotal);
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

        public bool HaveCashFlowOpen()
        {
            bool haveCashFlowOpen = false;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM cash_flow WHERE closing_date = ''";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        haveCashFlowOpen = true;
                }
                catch
                {
                    throw;
                }
            }

            return haveCashFlowOpen;
        }   
        
        public void ClosingBox(decimal balance, int idCash)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                _sql = $"UPDATE cash_Flow SET balance = @balance, closing_date = '{DateTime.Now.ToShortDateString()}', closing_time = '{DateTime.Now.ToLongTimeString()}' WHERE id = @idCash";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@balance", balance);
                command.Parameters.AddWithValue("@idCash", idCash);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }
        
        public void UpdateValueTotalAndOutputValueOutgoingCash(int idCash, decimal valueOutput, SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = $"UPDATE cash_Flow SET cash_value_total = cash_value_total - @valueOutput, output_value_Total = output_value_Total + @valueOutput WHERE id = @idCash";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@valueOutput", valueOutput);
                command.Parameters.AddWithValue("@idCash", idCash);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool CheckedBoxClosing(int idCash)
        {
            bool boxItIsClosing = false;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM cash_flow WHERE closing_date <> '' AND id = {idCash}";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        boxItIsClosing = true;
                }
                catch
                {
                    throw;
                }
            }

            return boxItIsClosing;
        }
    }
}
