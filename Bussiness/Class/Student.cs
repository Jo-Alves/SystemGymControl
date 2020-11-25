using System.Data;

namespace Bussiness
{
    public class Student : Person
    {
        Database.Student student = new Database.Student();

        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        private string photo;

        public string _photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string ValidationBox()
        {
            string message = null;

            if (string.IsNullOrEmpty(this._name))
                message = "Campo Nome obrigatório!";
            else if (string.IsNullOrEmpty(this._cpf))
                message = "Campo CPF obrigatório!";
            else if (string.IsNullOrEmpty(this._cep))
                message = "Campo CEP obrigatório!";
            else if (string.IsNullOrEmpty(this._district))
                message = "Campo Bairro obrigatório!";
            else if (string.IsNullOrEmpty(this._address))
                message = "Campo Endereço obrigatório!";
            else if (string.IsNullOrEmpty(this._city))
                message = "Campo Cidade obrigatório!";
            else if (string.IsNullOrEmpty(this._state))
                message = "Campo Estado obrigatório!";
            else if (student.SearchCPF(this._cpf) && this._id == 0)
                message = "Este CPF já está cadastrado!";

            return message;
        }

        public override void SaveStudent()
        {
            student._id = this._id;
            student._name = this._name;
            student._cpf = this._cpf;
            student._birth = this._birth;
            student._cep = this._cep;
            student._district = this._district;
            student._address = this._address;
            student._number = this._number;
            student._city = this._city;
            student._state = this._state;
            student._photo = this.photo;

            student.Save();
        }

        public void Delete()
        {
            student.Delete(this._id);

        }

        public override DataTable SearchID()
        {
            return student.SearchID(this._id);
        }


        public DataTable SearchAll()
        {
            return student.SearchAll();
        }
    }
}
