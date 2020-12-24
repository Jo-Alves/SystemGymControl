using System.Data;

namespace Bussiness
{
    public class ItemsPackage
    {
        private int id;
        private decimal valuePackage;
        private int packageID;
        Database.ItemsPackage itemsPackage = new Database.ItemsPackage();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal _valuePackage
        {
            get { return valuePackage; }
            set { valuePackage = value; }
        }
        public int _packageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public void Save()
        {
            itemsPackage._id = this._id;
            itemsPackage._valuePackage = this._valuePackage;
            itemsPackage._packageID = this._packageID;
            //itemsPackage.Save();
        }

        public DataTable SearchID(int idItemsPackage)
        {
            return itemsPackage.SearchID(idItemsPackage);
        }

        public void Delete(int idItemsPackage)
        {
            itemsPackage.Delete(idItemsPackage);
        }

        public int GetMaxId()
        {
            return itemsPackage.GetMaxId();
        }
    }
}
