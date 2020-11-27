using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class ResponsibleStudent : Person
    {

        Database.ResponsibleStudent responsible = new Database.ResponsibleStudent();

        private string kinship;
        private int studentID;

        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        public override string _phone { get; set; }
        public string _kinship
        {
            get { return kinship; }
            set { kinship = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string ValidateFields()
        {
            string message = null;

            if (string.IsNullOrEmpty(this._name))
                message = "Campo Nome do responsável obrigatório!";
            else if (this._cpf.Length < 14)
                message = "Campo CPF obrigatório!"; 
            else if (string.IsNullOrEmpty(this._kinship))
                message = "Campo Grau de Parentesco obrigatório!";
            else if (responsible.SearchCPF(this._cpf) && this._studentID == 0)
                message = "Este CPF já está cadastrado!"; 
            else if (!CPF.ValidateCPF(this._cpf))
                message = "CPF inválido!";

            return message;
        }

        public override void Save()
        {
            responsible._id = this._id;
            responsible._name = this._name;
            responsible._cpf = this._cpf;
            responsible._kinship = this._kinship;
            responsible._studentID = this._studentID;
            responsible._phone = this._phone;
            responsible.Save();
        }

        public override DataTable SearchID()
        {
            return responsible.SearchID(this.studentID);
        }
    }
}