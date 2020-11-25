using System.Data;

namespace Bussiness
{
    public abstract class Person
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

        //string _sql;

        public abstract int _id { get; set; }
        public abstract string _name { get; set; }
        public abstract string _cpf { get; set; }
        public string _cep { get; set; }
        public string _district { get; set; }
        public string _address { get; set; }
        public int _number { get; set; }
        public string _birth { get; set; }
        public string _city { get; set; }
        public string _state { get; set; }

        public abstract void SaveStudent();
        public abstract DataTable SearchID();
    }
}
