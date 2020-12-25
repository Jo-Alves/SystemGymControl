using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class CashPayment
    {
        private int id;
        private decimal valueTotal;
        private decimal valueDiscount;
        private string payday;
        private string paymentTime;
        private string duedate;
        private int planID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal _valueTotal
        {
            get { return valueTotal; }
            set { valueTotal = value; }
        }
        public decimal _valueDiscount
        {
            get { return valueDiscount; }
            set { valueDiscount = value; }
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
        public string _duedate
        {
            get { return duedate; }
            set { duedate = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save(SqlTransaction sqlTransaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO cash_payments VALUES (@valueTotal, @valueDiscount, @payday, @paymentTime, @duedate, @planID)";
                else
                    _sql = "UPDATE  cash_payments SET value_total = @valueTotal, value_discount = @valueDiscount, payday =  @payday, payment_time = @paymentTime, duedate =  @duedate WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, sqlTransaction.Connection, sqlTransaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@valueTotal", _valueTotal);
                command.Parameters.AddWithValue("@valueDiscount", _valueDiscount);
                command.Parameters.AddWithValue("@payday", _payday);
                command.Parameters.AddWithValue("@paymentTime", _paymentTime);
                command.Parameters.AddWithValue("@duedate", _duedate);
                command.Parameters.AddWithValue("@planID", _planID);
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

        public DataTable SearchPlanID(int planID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM cash_payments WHERE plan_id = @planID AND payday = ''";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@planID", planID);
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
                    _sql = "SELECT * FROM cash_payments WHERE id = @id";
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
