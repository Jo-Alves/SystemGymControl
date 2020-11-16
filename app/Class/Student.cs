using System.Data;
using System.Data.SqlClient;

namespace SystemGynControl
{
    class Student
    {
        private int id;
        private string name;
        private string cpf;
        private string cep;
        private string district;
        private string address;
        private int number;
        private string birth;
        private string city;
        private string state;
        private string photo;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public string _cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string _cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string _district
        {
            get { return district; }
            set { district = value; }
        }
        public string _address
        {
            get { return address; }
            set { address = value; }
        }
        public int _number
        {
            get { return number; }
            set { number = value; }
        }
        public string _birth
        {
            get { return birth; }
            set { birth = value; }
        }
        public string _city
        {
            get { return city; }
            set { city = value; }
        }
        public string _state
        {
            get { return state; }
            set { state = value; }
        }
        public string _photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if(_id > 0)
                _sql = "INSERT INTO student VALUES (@name, @cpf, @cep, @district, @address, @number, @birth, @city, @state, @photo)";
            else
                _sql = "UPDATE student SET name = @name, cpf = @cpf, cep = @cep, distict = @district, adress = @address, number = @number, birth = @birth, city = @city, state = @state, photo = @photo WHERE id = @id";

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
            _sql = "DELETE FROM student WHERE id = @id";
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


        public DataTable Search()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM student";
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
