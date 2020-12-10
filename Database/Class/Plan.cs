using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Plan
    {
        private int id;
        private int numberPortions;
        private string datePurchasePlan;
        private string timePurchasePlan;
        private int itemsPackageID;
        private int studentID;


        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _numberPortions
        {
            get { return numberPortions; }
            set { numberPortions = value; }
        }
        public string _datePurchasePlan
        {
            get { return datePurchasePlan; }
            set { datePurchasePlan = value; }
        }
        public string _timePurchasePlan
        {
            get { return timePurchasePlan; }
            set { timePurchasePlan = value; }
        }
        public int _itemsPackageID
        {
            get { return itemsPackageID; }
            set { itemsPackageID = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO plans VALUES (@datePurchasePlan, @timePurchasePlan, @itemsPackageID, @studentID)";
                else
                    _sql = "UPDATE plans SET date_purchase_plan = @datePurchasePlan, time_purchase_plan = @timePurchasePlan, itemns_package_id = @itemsPackageID, student_id = @studentID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@datePurchasePlan", _datePurchasePlan);
                command.Parameters.AddWithValue("@timePurchasePlan", _timePurchasePlan);
                command.Parameters.AddWithValue("@itemsPackageID", _itemsPackageID);
                command.Parameters.AddWithValue("@studentID", _studentID);
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

        public DataTable SearchID(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT * FROM plans WHERE id = @id";
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

        public DataTable SearchAll()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT * FROM plans INNER JOIN situations_plan ON situations_plan.plan_id = plans.id WHERE plans.id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", _id);
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

        public int GetMaxId()
        {
            int maxId = 0;
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT MAX(id) as maxID FROM plans";
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
    }
}
