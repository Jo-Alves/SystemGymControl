using System.Data;

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

        public DataTable SearchID(int id)
        {
            return formsOfPayment.SearchID(id);
        }

        public DataTable SearchItemsPackageID(int idItemsPackage)
        {
            return formsOfPayment.SearchItemsPackageID(idItemsPackage);
        }

        public DataTable SearchAll()
        {
            return formsOfPayment.SearchAll();
        }
    }
}
