using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class CashFlow
    {
        private int id;
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

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO cash_flow VALUES (@openingTime, @cashValueTotal, @outputValueTotal, @closingDate, @closingTime)";
                else
                    _sql = "UPDATE cash_flow SET opening_time = @openingTime, cash_value_total = @cashValueTotal, output_value_total = @outputValueTotal, closing_date = @closingDate, closing_time = @closingTime WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@openingTime", _openingTime);
                command.Parameters.AddWithValue("@cashValueTotal", _cashValueTotal);
                command.Parameters.AddWithValue("@outputValueTotal", _outputValueTotal);
                command.Parameters.AddWithValue("@closingDate", _closingDate);
                command.Parameters.AddWithValue("@closingTime", _closingTime);
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

            using(var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                _sql = "SELECT MAX(id) FROM cash_flow WHERE closing_date = ''";
                SqlCommand command = new SqlCommand(_sql, connection);
                if (command.ExecuteScalar() != DBNull.Value)
                    maxId = int.Parse(command.ExecuteScalar().ToString());
                
            }

            return maxId;
        }
    }
}
