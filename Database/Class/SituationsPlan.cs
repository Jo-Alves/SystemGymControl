using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class SituationsPlan
    {
        private int id;
        private string situation;
        private string observation;
        private string timeInactivated;
        private string deactivationDate;
        private int planID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _situation
        {
            get { return situation; }
            set { situation = value; }
        }
        public string _observation
        {
            get { return observation; }
            set { observation = value; }
        }
        public string _deactivationDate
        {
            get { return deactivationDate; }
            set { deactivationDate = value; }
        }
        public string _timeInactivated
        {
            get { return timeInactivated; }
            set { timeInactivated = value; }
        }

        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {

                _sql = "UPDATE situations_plan SET situation = @situation, observation = @observation, deactivation_date = @deactivationDate, time_inactivated = @timeInactivated WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@situation", _situation);
                command.Parameters.AddWithValue("@observation", _observation);
                command.Parameters.AddWithValue("@deactivationDate", _deactivationDate);
                command.Parameters.AddWithValue("@timeInactivated", _timeInactivated);
                command.Parameters.AddWithValue("@planID", _planID);
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

        public void Save(SqlTransaction sqlTransaction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO situations_plan (situation, observation, plan_id) VALUES (@situation, @observation, @planID)";
                else
                    _sql = "UPDATE situations_plan SET situation = @situation, observation = @observation, deactivation_date = @deactivationDate, time_inactivated = @timeInactivated WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, sqlTransaction.Connection, sqlTransaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@situation", _situation);
                command.Parameters.AddWithValue("@observation", _observation);
                command.Parameters.AddWithValue("@deactivationDate", _deactivationDate);
                command.Parameters.AddWithValue("@timeInactivated", _timeInactivated);
                command.Parameters.AddWithValue("@planID", _planID);
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

        public void updateTimeInactive(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE situations_plan SET time_inactivated = @timeInactivated WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@timeInactivated", _timeInactivated);

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

        public void updateSituationPlan(int idPlan, string situation)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE situations_plan SET situation = @situation, observation = '', time_Inactivated = 0, deactivation_date = ''  WHERE plan_id = @idPlan";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@idPlan", idPlan);
                command.Parameters.AddWithValue("@situation", situation);

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
                    _sql = "SELECT * FROM situations_plan WHERE id = @id";
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
    }
}
