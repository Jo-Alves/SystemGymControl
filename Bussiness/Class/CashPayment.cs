using System.Data;

namespace Bussiness
{
    public class CashPayment
    {
        private int id;
        private decimal valueTotal;
        private decimal valueDiscount;
        private string payday;
        private string paymentTime;
        private int planID;

        Database.CashPayment cashPayment = new Database.CashPayment();

        public int _id
        {
            get { return id; }
            set { id = value; }
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
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public DataTable SearchID(int id)
        {
            return cashPayment.SearchID(id);
        }

        public DataTable SearchAll()
        {
            return cashPayment.SearchAll();
        }
    }
}
