using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class IcomingCashFlow
    {
        private int id;
        private string entryDate;
        private string entryTime;
        private string descriptionIcoming;
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
        public string _descriptionIcoming
        {
            get { return descriptionIcoming; }
            set { descriptionIcoming = value; }
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

        public void Save(SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO icoming_cash_flow VALUES (@entryDate, @entryTime, @descriptionIcoming, @valueMoney, @valueCard, @cashFlowID)";
                else
                    _sql = "UPDATE icoming_cash_flow SET entry_date = @entryDate, entry_time = @entryTime, description_icoming = @descriptionIcoming, value_money = @valueMoney, value_card = @valueCard, cash_flow_id = @cashFlowID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@entryDate", _entryDate);
                command.Parameters.AddWithValue("@entryTime", _entryTime);
                command.Parameters.AddWithValue("@descriptionIcoming", _descriptionIcoming);
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
            }
        }

        public DataTable SearchID(int idIcoming)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM icoming_cash_flow WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idIcoming);
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
                    _sql = "SELECT * FROM icoming_cash_flow";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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
        
        public DataTable GetDataIcomingIdCash(int idCash)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT * FROM icoming_cash_flow WHERE cash_flow_id = @idCash AND description_icoming <> 'Valor inicial'";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@idCash", idCash);
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

        public DataTable GetDataIcoming(int idCash, string entryTimeCashFlow, string openingDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT * FROM icoming_cash_flow WHERE entry_date = @date AND CONVERT(TIME, entry_time, 103)  > CONVERT(TIME, @time, 103) AND cash_Flow_id = @idCash";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@idCash", idCash);
                    adapter.SelectCommand.Parameters.AddWithValue("@date", openingDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@time", entryTimeCashFlow);
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

        public decimal GetValueEntryInitial(int idCash)
        {
            decimal valueEntry = 0.00M;

            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT value_money FROM icoming_cash_flow WHERE cash_flow_id = @idCash AND description_icoming = 'Valor inicial'";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("idCash", idCash);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        valueEntry = decimal.Parse(dr["value_money"].ToString());
                }
                catch
                {
                    throw;
                }
            }

            return valueEntry;
        }

        public decimal GetSumValueEntryMoney(int idCash)
        {
            decimal sumValue = 0.00M;

            using( var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT SUM(value_money) FROM icoming_cash_flow WHERE cash_flow_id <= @idCash AND description_icoming <> 'Valor inicial'";
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@idCash", idCash);
                    if(command.ExecuteScalar() != DBNull.Value)
                    {
                        sumValue = Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
                catch
                {
                    throw;
                }
            }

            return sumValue;
        }
        
        public decimal GetSumValueEntryCard(int idCash)
        {
            decimal sumValue = 0.00M;

            using( var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT SUM(value_card) FROM icoming_cash_flow WHERE cash_flow_id = @idCash";
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@idCash", idCash);
                    if(command.ExecuteScalar() != DBNull.Value)
                    {
                        sumValue = Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
                catch
                {
                    throw;
                }
            }

            return sumValue;
        }

        public decimal GetSumAllValueEntryCard(int idCash)
        {
            decimal sumValue = 0.00M;

            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT SUM(value_card) FROM icoming_cash_flow WHERE cash_flow_id <= @idCash";
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@idCash", idCash);
                    if (command.ExecuteScalar() != DBNull.Value)
                    {
                        sumValue = Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
                catch
                {
                    throw;
                }
            }

            return sumValue;
        }
    }
}
