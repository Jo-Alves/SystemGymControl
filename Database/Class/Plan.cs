using System.Data;
using System.Data.SqlClient;

namespace Database
{
    class Plan
    {
        private int id;
        private int numberPortions;
        private string datePurchasePlan;
        private int packageID;
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
        public int _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO plans VALUES (@numberPortions, @datePurchasePlan, @packageID, @studenID)";
            else
                _sql = "UPDATE plans SET number_portions = @numberPortions, date_purchase_plan = @datePurchasePlan, package_id = @packageID, student_id = @studentID WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@numberPortions", _numberPortions);
            command.Parameters.AddWithValue("@datePurchasePlan", _datePurchasePlan);
            command.Parameters.AddWithValue("@packageID", _packageID);
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
                _sql = "SELECT * FROM plans WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", _id);
                SqlDataReader dr = adapter.ExecuteReader();
                if (dr.Read())
                {
                    _numberPortions = int.Parse(dr["number_portion"].ToString());
                    _datePurchasePlan = dr["date_Purchase_plan"].ToString();
                }
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

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM plans INNER JOIN situations_plan ON situations_plan.plan_id = plans.id WHERE plans.id = @id";
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
