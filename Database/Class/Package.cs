using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Package
    {
        private int id;
        private string description;
        private int duration;
        private string period;

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
        public int _duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string _period
        {
            get { return period; }
            set { period = value; }
        }

        public void Save(DataTable dataItemsAndFormsPayment, BillingParametersPackage billingParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO packages VALUES (@description, @duration, @period); SELECT @@IDENTITY";
                else
                    _sql = "UPDATE packages SET description = @description, duration = @duration, period = @period WHERE id = @id";

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(_sql, connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@description", _description);
                command.Parameters.AddWithValue("@duration", _duration);
                command.Parameters.AddWithValue("@period", _period);
                try
                {
                    int idPackage = 0;
                    if (_id == 0)
                        idPackage = Convert.ToInt32(command.ExecuteScalar());
                    else
                        idPackage = _id;

                    billingParameters._packageID = idPackage;
                    billingParameters.Save(transaction);

                    foreach (DataRow dr in dataItemsAndFormsPayment.Rows)
                    {
                        ItemsPackage itemsPackage = new ItemsPackage() { _id = int.Parse(dr["id"].ToString()), _valuePackage = decimal.Parse(dr["value"].ToString()), _packageID = idPackage };
                        itemsPackage.Save(transaction);

                        int idItemsPackage = 0;
                        if (int.Parse(dr["id"].ToString()) == 0)
                        {
                            idItemsPackage = itemsPackage._id;
                        }
                        else
                            idItemsPackage = int.Parse(dr["id"].ToString());


                        FormsOfPayment formsOfPayment = new FormsOfPayment() { _description = dr["formOfPayment"].ToString(), _id = int.Parse(dr["idFormOfPayment"].ToString()), _itemsPackageID = idItemsPackage };
                        formsOfPayment.Save(transaction);
                    }

                    if (_id > 0)
                    {
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(int idPackage)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "DELETE FROM packages WHERE id = @id";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", idPackage);
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

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM packages";
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

        public DataTable SearchAllItemsAndPackage()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT pc.id, pc.description, pc.duration, pc.period, ip.id as idItems, ip.value, fp.description as formOfPayment FROM packages as pc INNER JOIN items_package as ip ON  ip.package_id = pc.id INNER JOIN forms_of_Payment AS fp ON fp.items_package_id = ip.id ORDER BY pc.description, fp.description, ip.value ASC";
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

        public DataTable SearchDescriptionPackageAndItems(string description)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = $"SELECT pc.id, pc.description, pc.duration, pc.period, ip.id as idItems, ip.value, fp.description as formOfPayment FROM packages as pc INNER JOIN items_package as ip ON  ip.package_id = pc.id INNER JOIN forms_of_Payment AS fp ON fp.items_package_id = ip.id WHERE pc.description LIKE '%{description}%' ORDER BY pc.description, fp.description, ip.value ASC";
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


        public SqlDataReader SearchID(int idPackage)
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            try
            {
                connection.Open();
                _sql = "SELECT * FROM packages WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", idPackage);
                SqlDataReader dr = adapter.ExecuteReader();
                dr.Read();
                return dr;
            }
            catch
            {
                throw;
            }
        }

        public DataTable SearchDescription(string description)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM packages WHERE description like '%{description}%'";
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

        public DataTable GetPackageAndItemsPackageId(int idPackage)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT forms_of_payment.description FROM items_package INNER JOIN packages ON packages.id = items_package.package_id INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id WHERE packages.id = @idPackage";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@idPackage", idPackage);
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

        public DataTable GetValuePackageAndId(int idPackage, string descriptionForms)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT items_package.value, items_package.id FROM items_package INNER JOIN packages ON packages.id = items_package.package_id INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id WHERE packages.id = @idPackage AND forms_of_payment.description = @descriptionForms";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@idPackage", idPackage);
                    adapter.SelectCommand.Parameters.AddWithValue("@descriptionForms", descriptionForms);
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

        public int GetMaxId()
        {
            int maxId = 0;
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT MAX(id) as maxID FROM packages";
                    var command = new SqlCommand(_sql, connection);
                    connection.Open();
                    var dr = command.ExecuteReader();
                    if (dr.Read())
                        maxId = int.Parse(dr["maxID"].ToString());
                }
                catch
                {
                    throw;
                }
            }

            return maxId;
        }

        public DataTable GetDescriptionFormPayment(int idPackage)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = $"SELECT forms_of_payment.description FROM packages INNER JOIN items_package ON items_package.package_id = packages.id  INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id WHERE packages.id = {idPackage}";
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
