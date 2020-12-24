using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class BillingParametersPackage
    {
        private int id;
        private decimal valuePenalty;
        private decimal valueInterest;
        private string typePenalty;
        private string typeInterest;
        private int packageID;

        Database.BillingParametersPackage parametersPackage = new Database.BillingParametersPackage();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal _valuePenalty
        {
            get { return valuePenalty; }
            set { valuePenalty = value; }
        }
        public decimal _valueInterest
        {
            get { return valueInterest; }
            set { valueInterest = value; }
        }
        public string _typePenalty
        {
            get { return typePenalty; }
            set { typePenalty = value; }
        }
        public string _typeInterest
        {
            get { return typeInterest; }
            set { typeInterest = value; }
        }
        public int _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public void Save()
        {
            parametersPackage._id = this._id;
            parametersPackage._valuePenalty = this._valuePenalty;
            parametersPackage._valueInterest = this._valueInterest;
            parametersPackage._typeInterest = this._typeInterest;
            parametersPackage._typePenalty = this._typePenalty;
            parametersPackage._packageID = this._packageID;
            //parametersPackage.Save();
        }

        public DataTable SearchID(int idPackage)
        {
            return parametersPackage.SearchID(idPackage);
        }
    }
}
