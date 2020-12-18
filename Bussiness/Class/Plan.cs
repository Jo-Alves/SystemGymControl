using System.Data;

namespace Bussiness
{
    public class Plan
    {
        private int id;
        private int numberPortions;
        private string datePurchasePlan;
        private string dateTerminalPlan;
        private string dateTerminalPlanLast;
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
        public string _dateTerminalPlanLast
        {
            get { return dateTerminalPlanLast; }
            set { dateTerminalPlanLast = value; }
        }
        public string _dateTerminalPlan
        {
            get { return dateTerminalPlan; }
            set { dateTerminalPlan = value; }
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
            plan._dateTerminalPlan = this._dateTerminalPlan;
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
        
        public void UpdateTerminalPlanLast(int id)
        {
            plan._dateTerminalPlanLast = this._dateTerminalPlanLast;
            plan.UpdateTerminalPlanLast(id);
        }
        
        public void UpdateTerminalPlan(int id)
        {
            plan._dateTerminalPlan = this._dateTerminalPlan;
            plan.UpdateTerminalPlan(id);
        }

        public DataTable SearchPlanNameStudent(string name)
        {
            return plan.SearchPlanNameStudent(name);
        }

        public int GetMaxId()
        {
            return plan.GetMaxId();
        }

        public bool ModalitiesBeforePlanTerminalCurrentEqual(int id, string description)
        {
            return plan.ModalitiesBeforePlanTerminalCurrentEqual(id, description);
        }
    }
}
