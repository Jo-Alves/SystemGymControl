using Database;
using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class FormsOfPayment
    {
        Database.FormsOfPayment formsOfPayment = new Database.FormsOfPayment();

        private int id;
        private string description;
        private int itemsPackageID;

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
        public int _itemsPackageID
        {
            get { return itemsPackageID; }
            set { itemsPackageID = value; }
        }

        public void Save()
        {
            formsOfPayment._id = this._id;
            formsOfPayment._description = this._description;
            formsOfPayment._itemsPackageID = this._itemsPackageID;
            formsOfPayment.Save();
        }

        public DataTable SearchID(int idItemsPackage)
        {
            return formsOfPayment.SearchID(idItemsPackage);
        }

        public DataTable SearchAll()
        {
            return formsOfPayment.SearchAll();
        }
    }
}
