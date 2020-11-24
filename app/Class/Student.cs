using System.Data;
using System.Data.SqlClient;

namespace SystemGymControl
{
    class Student : Person
    {
        string _sql;

        
        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        private string photo;
        public string _photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public override void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id > 0)
                _sql = "INSERT INTO students VALUES (@name, @cpf, @cep, @district, @address, @number, @birth, @city, @state, @photo)";
            else
                _sql = "UPDATE students SET name = @name, cpf = @cpf, cep = @cep, distict = @district, adress = @address, number = @number, birth = @birth, city = @city, state = @state, photo = @photo WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@name", _name);
            command.Parameters.AddWithValue("@cpf", _cpf);
            command.Parameters.AddWithValue("@cep", _cep);
            command.Parameters.AddWithValue("@district", _district);
            command.Parameters.AddWithValue("@address", _address);
            command.Parameters.AddWithValue("@number", _number);
            command.Parameters.AddWithValue("@birth", _birth);
            command.Parameters.AddWithValue("@city", _city);
            command.Parameters.AddWithValue("@state", _state);
            command.Parameters.AddWithValue("@photo", _photo);
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

        public void Delete()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            _sql = "DELETE FROM students WHERE id = @id";
            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
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


        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM students";
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

        public override DataTable SearchID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM students WHERE id = @id";
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
