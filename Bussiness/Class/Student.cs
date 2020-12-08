using System.Data;

namespace Bussiness
{
    public class Student : Person
    {
        Database.Student student = new Database.Student();

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

        public string ValidateFieldsAndGetMessage()
        {
            string message = null;

            if (string.IsNullOrEmpty(this._name))
                message = "Campo Nome obrigatório!";
            else if (this._cpf.Length < 14)
                message = "Campo CPF obrigatório!";
            else if (string.IsNullOrEmpty(this._district))
                message = "Campo Bairro obrigatório!";
            else if (string.IsNullOrEmpty(this._address))
                message = "Campo Endereço obrigatório!";
            else if (string.IsNullOrEmpty(this._city))
                message = "Campo Cidade obrigatório!";
            else if (string.IsNullOrEmpty(this._state))
                message = "Campo Estado obrigatório!";
            else if (!string.IsNullOrEmpty(this._email))
            {
                if (!ValidateEmail.Validate(this._email))
                    message = "Email inválido!";
            }
            else if (student.SearchCPF(this._cpf) && this._id == 0)
                message = "Este CPF já está cadastrado!";
            else if (!CPF.ValidateCPF(this._cpf) && this._id == 0)
                message = "CPF inválido!";

            return message;
        }

        public override void Save()
        {
            student._id = this._id;
            student._name = this._name;
            student._cpf = this._cpf;
            student._phone = this._phone;
            student._birth = this._birth;
            student._cep = this._cep;
            student._district = this._district;
            student._address = this._address;
            student._number = this._number;
            student._city = this._city;
            student._state = this._state;
            student._email = this._email;
            student._photo = this.photo;

            student.Save();
        }

        public void Delete(int id)
        {
            student.Delete(id);

        }

        public override DataTable SearchID(int id)
        {
            return student.SearchID(id);
        }


        public DataTable SearchAll()
        {
            return student.SearchAll();
        }

        public DataTable SearchName(string name)
        {
            return student.SearchName(name);
        }

        public int GetMaxID()
        {
            return student.GetMaxId();

        }
    }
}
