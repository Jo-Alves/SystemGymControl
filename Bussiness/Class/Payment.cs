using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class Payment
    {
        private int id;
        private int numberPortion;
        private decimal valueTotal;
        private decimal valueDiscount;
        private string payday;
        private string paymentTime;
        private string duedate;
        private string formPayment;
        private string paymentOnAccount;
        private int planID;

        Database.Payment payment = new Database.Payment();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _numberPortion
        {
            get { return numberPortion; }
            set { numberPortion = value; }
        }
        public decimal _valueTotal
        {
            get { return valueTotal; }
            set { valueTotal = value; }
        }
        public decimal _valueDiscount
        {
            get { return valueDiscount; }
            set { valueDiscount = value; }
        }
        public string _payday
        {
            get { return payday; }
            set { payday = value; }
        }
        public string _paymentTime
        {
            get { return paymentTime; }
            set { paymentTime = value; }
        }
        public string _duedate
        {
            get { return duedate; }
            set { duedate = value; }
        }
        public string _formPayment
        {
            get { return formPayment; }
            set { formPayment = value; }
        }
        public string _paymentOnAccount
        {
            get { return paymentOnAccount; }
            set { paymentOnAccount = value; }
        }
        
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public DataTable SearchPlanID(int planID)
        {
            return payment.SearchPlanID(planID);
        }

        public DataTable SearchCashPaymentPlanMoney(int idPlan)
        {
            return payment.SearchCashPaymentPlanMoney(idPlan);
        }

        public DataTable SearchCashPaymentPlanIDCash(int idCash)
        {
            return payment.SearchCashPaymentPlanIDCash(idCash);
        }
    }
}
