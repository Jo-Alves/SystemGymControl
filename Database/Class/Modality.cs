using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Modality
    {
        private int id;
        private string description;
        private int planID;

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
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save(SqlTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                if (_id == 0)
                    _sql = "INSERT INTO modalities VALUES (@description, @planID)";
                else
                    _sql = "UPDATE modalities SET description = @description, plan_id = @planID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@description", _description);
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
                    _sql = "SELECT * FROM modalities WHERE plan_id = @planID";
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
    }
}
