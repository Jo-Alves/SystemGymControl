using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class Package
    {
        private int id;
        private string description;
        private decimal valuePackage;
        private int duration;
        private string period;

        Database.Package package = new Database.Package();

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
        public int _duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public decimal _value
        {
            get { return valuePackage; }
            set { valuePackage = value; }
        }
        public string _period
        {
            get { return period; }
            set { period = value; }
        }

        public void Save()
        {
          
        }

        public void Delete()
        {
          
        }

        public DataTable SearchAll()
        {
            return package.SearchAll();
        }
        
        public DataTable SearchDescription(string description)
        {
            return package.SearchDescription(description);
        }


        //public SqlDataReader SearchID()
        //{
          
        //}
    }
}
