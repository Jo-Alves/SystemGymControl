using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl.Class
{
    class ItemsPpackage
    {
        private int id;
        private string formOfPayment;
        private decimal valuePackage;
        private int packageID;


        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _formOfPayment
        {
            get { return formOfPayment; }
            set { formOfPayment = value; }
        }
        public decimal _valuePackage
        {
            get { return valuePackage; }
            set { valuePackage = value; }
        }
        public int _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO items_package VALUES (@formOfPayment, @valuePackage, @packageID)";
            else
                _sql = "UPDATE items_package SET formOfPayment = @formOfPayment, value = @valuePackage, package_id = @packageID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@formOfPayment", _formOfPayment);
            command.Parameters.AddWithValue("@valuePackage", _valuePackage);
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
                _sql = "SELECT * FROM items_package WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _formOfPayment = dr["formOfPayment"].ToString();
                    _valuePackage = decimal.Parse(dr["value"].ToString());
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
