using System.Data.SqlClient;

namespace Database
{
    public class Backup
    {
        public void Generatebackup(string path)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("", connection);
                    command.CommandText = $"BACKUP DATABASE dbGymControl TO DISK = '{path}'";

                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }
        
        public void RestoreDatabase(string path)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnectionMaster))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("", connection);
                    command.CommandText = $"RESTORE DATABASE dbGymControl FROM DISK = '{path}'";

                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
