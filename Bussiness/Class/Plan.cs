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

        public void Save(Modality modality, SituationsPlan situationsPlan, DataTable dataCardPayment, CashPayment cashPayment, string formPayment, string period)
        {
            plan._id = this.id;
            plan._datePurchasePlan = this._datePurchasePlan;
            plan._dateTerminalPlan = this._dateTerminalPlan;
            plan._timePurchasePlan = this._timePurchasePlan;
            plan._itemsPackageID = this._itemsPackageID;
            plan._studentID = this._studentID;

            Database.Modality modalityDataBase = new Database.Modality() { _description = modality._description, _id = modality._id };

            Database.SituationsPlan situationsPlanDataBase = new Database.SituationsPlan() { _observation = "", _situation = situationsPlan._situation, _deactivationDate = situationsPlan._deactivationDate, _timeInactivated = situationsPlan._timeInactivated, _id = situationsPlan._id };

            Database.CashPayment cashPaymentDatabase = new Database.CashPayment() { _id = cashPayment._id, _payday = cashPayment._payday, _paymentTime = cashPayment._paymentTime, _valueDiscount = cashPayment._valueDiscount, _valueTotal = cashPayment._valueTotal, _duedate = cashPayment._duedate };

            plan.Save(modalityDataBase, situationsPlanDataBase, dataCardPayment, cashPaymentDatabase, formPayment, period.ToLower());
        }

        public DataTable SearchID(int id)
        {
            return plan.SearchID(id);
        }

        public DataTable SearchAll()
        {
            return plan.SearchAll();
        } 
        
        public DataTable SearchAllWhereMoney()
        {
            return plan.SearchAllWhereMoney();
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

        public DataTable GetDatePlanExpired()
        {
            return plan.GetDatePlanExpired();
        }
    }
}
