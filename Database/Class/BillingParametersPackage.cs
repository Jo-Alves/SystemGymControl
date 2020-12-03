using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class BillingParametersPackage
    {
        private int id;
        private decimal valuePenalty;
        private decimal valueInterest;
        private int packageID;
        private string typePenalty;
        private string typeInterest;

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
        public string _typePenalty
        {
            get { return typePenalty; }
            set { typePenalty = value; }
        }
        public string _typeInterest
        {
            get { return typeInterest; }
            set { typeInterest = value; }
        }
        public int _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id == 0)
                _sql = "INSERT INTO billing_parameters_package VALUES (@valuePenalty, @valueInterest, @typePenalty, @typeInterest, @packageID)";
            else
                _sql = "UPDATE billing_parameters_package SET value_penalty = @valuepenalty, type_penalty = @typePenalty, type_interest = @typeInterest, value_interest = @valueInterest, package_id = @packageID WHERE package_id = @packageID";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@valuePenalty", _valuePenalty);
            command.Parameters.AddWithValue("@valueInterest", _valueInterest);
            command.Parameters.AddWithValue("@typePenalty", _typePenalty);
            command.Parameters.AddWithValue("@typeInterest", _typeInterest);
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

        public SqlDataReader SearchID(int packageID)
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            try
            {
                connection.Open();
                _sql = "SELECT * FROM billing_parameters_package WHERE package_id = @id";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", packageID);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                return dr;
            }
            catch
            {
                throw;
            }
        }
    }
}
