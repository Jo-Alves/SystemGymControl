using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Student : Person
    {
        string _sql;


        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        public override string _phone { get; set; }

        private string photo;
        private string email;

        public string _email
        {
            get { return email; }
            set { email = value; }
        }
        public string _photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public override void Save()
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO students VALUES (@name, @cpf, @birth, @phone, @cep, @district, @address, @number, @city, @state, @email, @photo)";
                else
                    _sql = "UPDATE students SET name = @name, phone = @phone, cep = @cep, district = @district, address = @address, number = @number, birth = @birth, city = @city, state = @state, email = @email, photo = @photo WHERE id = @id";

                var command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@cpf", _cpf);
                command.Parameters.AddWithValue("@phone", _phone);
                command.Parameters.AddWithValue("@cep", _cep);
                command.Parameters.AddWithValue("@district", _district);
                command.Parameters.AddWithValue("@address", _address);
                command.Parameters.AddWithValue("@number", _number);
                command.Parameters.AddWithValue("@birth", _birth);
                command.Parameters.AddWithValue("@city", _city);
                command.Parameters.AddWithValue("@state", _state);
                command.Parameters.AddWithValue("@email", _email);
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
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "DELETE FROM students WHERE id = @id";
                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", id);
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
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {

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
        }

        public override DataTable SearchID(int id)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM students WHERE id = @id";
                    var adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable SearchName(string name)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM students WHERE name LIKE '%{name}%'";
                    var adapter = new SqlDataAdapter(_sql, connection);
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

        public bool SearchCPF(string CPF)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT * FROM students WHERE cpf = @cpf";
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@cpf", CPF);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                        return true;
                    else
                        return false;
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
                    _sql = "SELECT MAX(id) as maxID FROM students";
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

        public DataTable GetBirthStudents(string dayAndMounth)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = $"SELECT * FROM students WHERE birth LIKE '%{dayAndMounth}%'";
                    var adapter = new SqlDataAdapter(_sql, connection);
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
