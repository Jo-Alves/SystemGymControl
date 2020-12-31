using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class FormsOfPayment
    {
        private int id;
        private string description;
        private int itemsPackageID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _description
        {
            get { return description; }
            set { description = value; }
        }
        public int _itemsPackageID
        {
            get { return itemsPackageID; }
            set { itemsPackageID = value; }
        }

        public void Save(SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO forms_of_payment VALUES (@description, @itemsPackageID)";
                else
                    _sql = "UPDATE forms_of_payment SET description = @description, items_package_id = @itemsPackageID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@description", _description);
                command.Parameters.AddWithValue("@itemsPackageID", _itemsPackageID);
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

        public DataTable SearchID(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM forms_of_payment WHERE id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
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

        public DataTable SearchItemsPackageID(int idItemsPackage)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM forms_of_payment WHERE items_package_id = @itemsPackageID";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@itemsPackageID", idItemsPackage);
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
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM forms_of_payment";
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
