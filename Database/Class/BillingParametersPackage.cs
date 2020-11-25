using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class BillingParametersPackage
    {
        private int id;
        private decimal valuePenalty;
        private decimal valueInterest;
        private string packageID;


        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
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
        public string _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO billing_parameters_package VALUES (@valuePenalty, @valueInterest, @packageID)";
            else
                _sql = "UPDATE billing_parameters_package SET valuePenalty = @value_penalty, value_interest = @valueInterest, package_id = @packageID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@valuePenalty", _valuePenalty);
            command.Parameters.AddWithValue("@valueInterest", _valueInterest);
            command.Parameters.AddWithValue("@packageID", _packageID);
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
                _sql = "SELECT * FROM billing_parameters_package WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _valuePenalty = decimal.Parse(dr["value_penalty"].ToString());
                    _valueInterest = decimal.Parse(dr["value_interest"].ToString());
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
