using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Payment
    {
        private int id;
        private int numberPortion;
        private decimal valueTotal;
        private decimal valueDiscount;
        private string payday;
        private string paymentTime;
        private string duedate;
        private string formPayment;
        private string paymentOnAccount;
        private decimal valuePenalty;
        private decimal valueInterest;
        private int planID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _numberPortion
        {
            get { return numberPortion; }
            set { numberPortion = value; }
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
        public decimal _valuePenalty
        {
            get { return valuePenalty; }
            set { valuePenalty = value; }
        }
        public decimal _valueInterest
        {
            get { return valueInterest; }
            set { valueInterest = value; }
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
        public string _formPayment
        {
            get { return formPayment; }
            set { formPayment = value; }
        }
        public string _paymentOnAccount
        {
            get { return paymentOnAccount; }
            set { paymentOnAccount = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save(SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO payments (portion, value_total, value_discount, payday,payment_time, duedate, form_Payment, payment_on_account, plan_id) VALUES (@portion, @valueTotal, @valueDiscount, @payday, @paymentTime, @duedate, @formPayment, @paymentOnAccount, @planID)";
                else
                    _sql = "UPDATE  payments SET value_total = @valueTotal, value_discount = @valueDiscount, payday =  @payday, payment_time = @paymentTime, form_Payment = @formPayment, payment_on_account = @paymentOnAccount, duedate =  @duedate WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@portion", _numberPortion);
                command.Parameters.AddWithValue("@valueTotal", _valueTotal);
                command.Parameters.AddWithValue("@valueDiscount", _valueDiscount);
                command.Parameters.AddWithValue("@payday", _payday);
                command.Parameters.AddWithValue("@paymentTime", _paymentTime);
                command.Parameters.AddWithValue("@duedate", _duedate);
                command.Parameters.AddWithValue("@formPayment", _formPayment);
                command.Parameters.AddWithValue("@paymentOnAccount", _paymentOnAccount);
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

        public void SavePaymentEffected(SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO payments (portion, value_total, value_discount, payday, value_interest, value_penalty, payment_time, duedate, form_Payment, payment_on_account, plan_id) VALUES (@portion, @valueTotal, @valueDiscount, @payday, @valueInterest, @valuePenalty, @paymentTime, @duedate, @formPayment, @paymentOnAccount, @planID)";
                else
                    _sql = "UPDATE payments SET value_total = @valueTotal, value_discount = @valueDiscount, payday =  @payday, value_interest = @valueInterest, value_penalty = @valuePenalty, payment_time = @paymentTime, form_Payment = @formPayment, payment_on_account = @paymentOnAccount, duedate =  @duedate WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@portion", _numberPortion);
                command.Parameters.AddWithValue("@valueTotal", _valueTotal);
                command.Parameters.AddWithValue("@valueDiscount", _valueDiscount);
                command.Parameters.AddWithValue("@valueInterest", _valueInterest);
                command.Parameters.AddWithValue("@valuePenalty", _valuePenalty);
                command.Parameters.AddWithValue("@payday", _payday);
                command.Parameters.AddWithValue("@paymentTime", _paymentTime);
                command.Parameters.AddWithValue("@duedate", _duedate);
                command.Parameters.AddWithValue("@formPayment", _formPayment);
                command.Parameters.AddWithValue("@paymentOnAccount", _paymentOnAccount);
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

        public void UpdatePaymentOnAccount(int idPayment, IcomingCashFlow icomingCashFlow)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {

                _sql = "UPDATE payments SET payment_on_account = 'yes' WHERE id = @id";

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(_sql, connection, transaction);
                command.Parameters.AddWithValue("@id", idPayment);
                try
                {
                    icomingCashFlow.Save(transaction);

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

        public DataTable SearchPaymentDateNow()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = $"SELECT id, duedate, form_payment, value_total FROM payments WHERE form_payment <> 'dinheiro' AND duedate = '{DateTime.Now.ToShortDateString()}' AND payment_on_account = 'no'";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable SearchPlanID(int planID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM payments WHERE plan_id = @planID AND payday = ''";
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

        public DataTable SearchCashPaymentPlanMounth(int idPlan)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT *, payments.id as idPayment, students.id as idStudent FROM payments INNER JOIN plans ON plans.id = payments.plan_id INNER JOIN students ON students.id = plans.student_id WHERE plans.id = @id ORDER BY payments.id DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idPlan);
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

        public DataTable SearchCashPaymentPlanIDCash(int idCash)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT *, payments.id AS idCash, students.id AS idStudent, items_package.value AS valuePackage, billing_parameters_package.value_interest AS valueInterest, billing_parameters_package.value_penalty AS valuePenalty FROM payments INNER JOIN plans ON plans.id = payments.plan_id INNER JOIN students ON students.id = plans.student_id INNER JOIN items_package ON items_package.id = plans.items_package_id INNER JOIN packages ON packages.id = items_package.package_id INNER JOIN billing_parameters_package ON billing_parameters_package.package_id = packages.id WHERE payments.id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idCash);
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

        public void UpdatePaymentPlanMensal(int idPlan, string duedate)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                _sql = "UPDATE payments SET duedate = @duedate WHERE plan_id = @planID and payday = ''";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@planID", idPlan);
                command.Parameters.AddWithValue("@duedate", duedate);
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

        public DataTable HistoryPayment(string entryTimeCashFlow, string openingDate)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM payments INNER JOIN plans ON planS.id = payments.plan_id INNER JOIN items_package ON items_package.id = plans.items_package_id INNER JOIN packages ON packages.id = items_package.package_id WHERE payments.payday = '{openingDate}' AND CONVERT(time, payment_time, 103) > CONVERT(time, '{entryTimeCashFlow}', 103)";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable GetSumValueTotalAndDiscount(string entryTimeCashFlow, string openingDate)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT SUM(value_total) AS valueTotal, SUM(value_discount) AS discount  FROM payments WHERE form_Payment = 'dinheiro' AND CONVERT(DATE, payments.payday, 103) = CONVERT(DATE, '{openingDate}', 103) AND CONVERT(time, payment_time, 103) > CONVERT(time, '{entryTimeCashFlow}', 103)";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        // retorna dados dos pagamentos atrasados

        public DataTable GetDataPaymentDueDateLate()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM payments INNER JOIN plans ON plans.id = payments.plan_id INNER JOIN students ON students.id = plans.student_id INNER JOIN items_package ON items_package.id = plans.items_package_id INNER JOIN packages ON packages.id = items_package.package_id WHERE CONVERT(DATE, payments.duedate, 103) < CONVERT(DATE, '{DateTime.Now.ToShortDateString()}', 103) AND packages.period = 'mensal' AND payments.payment_on_account = 'no' AND payments.payday = ''";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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
