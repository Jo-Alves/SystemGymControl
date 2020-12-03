using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class ItemsPackage
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
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
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
            }
        }
        
        public void Delete(int idItemsPackage)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                 _sql = "DELETE FROM items_package WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", idItemsPackage);
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

        public DataTable SearchID(int idItemsPackage)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM items_package WHERE Package_id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idItemsPackage);
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
