using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class CardPayment
    {
        private int id;
        private decimal numberPortion;
        private decimal valuePortion;
        private string payday;
        private string paymentTime;
        private string dueDate;
        private int planID;

        Database.CardPayment cardPayment = new Database.CardPayment();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal _numberPortion
        {
            get { return numberPortion; }
            set { numberPortion = value; }
        }
        public decimal _valuePortion
        {
            get { return valuePortion; }
            set { valuePortion = value; }
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
        public string _dueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            cardPayment._id = this._id;
            cardPayment._numberPortion = this._numberPortion;
            cardPayment._valuePortion = this._valuePortion;
            cardPayment._payday = this._payday;
            cardPayment._paymentTime = this._paymentTime;
            cardPayment._dueDate = this._dueDate;
            cardPayment._planID = this._planID;
            cardPayment.Save();
        }

        public DataTable SearchID(int id)
        {
            return cardPayment.SearchID(id);
        }

        public DataTable SearchAll()
        {
            return cardPayment.SearchAll();
        }
    }
}
