using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class Plan
    {
        private int id;
        private int numberPortions;
        private string datePurchasePlan;
        private string timePurchasePlan;
        private int itemsPackageID;
        private int studentID;

        Database.Plan plan = new Database.Plan();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _numberPortions
        {
            get { return numberPortions; }
            set { numberPortions = value; }
        }
        public string _timePurchasePlan
        {
            get { return timePurchasePlan; }
            set { timePurchasePlan = value; }
        }
        public string _datePurchasePlan
        {
            get { return datePurchasePlan; }
            set { datePurchasePlan = value; }
        }
        public int _itemsPackageID
        {
            get { return itemsPackageID; }
            set { itemsPackageID = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save()
        {
            plan._id = this.id;
            plan._datePurchasePlan = this._datePurchasePlan;
            plan._timePurchasePlan = this._timePurchasePlan;
            plan._itemsPackageID = this._itemsPackageID;
            plan._studentID = this._studentID;
            plan.Save();
        }

        public DataTable SearchID(int id)
        {
            return plan.SearchID(id);
        }

        public DataTable SearchAll()
        {
            return plan.SearchAll();
        }
        
        public int GetMaxId()
        {
            return plan.GetMaxId();
        }
    }
}
