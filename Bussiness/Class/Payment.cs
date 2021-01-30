using System.Data;

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
        private decimal valuePenalty;
        private decimal valueInterest;

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
        public decimal _valueInterest
        {
            get { return valueInterest; }
            set { valueInterest = value; }
        }
        public decimal _valuePenalty
        {
            get { return valuePenalty; }
            set { valuePenalty = value; }
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

        public DataTable GetDataCashPaymentPlanMounth(int idPlan)
        {
            return payment.GetDataCashPaymentPlanMounth(idPlan);
        }

        public DataTable GetDataCashPaymentPlanIDCash(int idCash)
        {
            return payment.GetDataCashPaymentPlanIDCash(idCash);
        }

        public void UpdatePaymentPlanMensal(int idPlan, string duedate)
        {
            payment.UpdatePaymentPlanMensal(idPlan, duedate);
        }

        public DataTable HistoryPayment(string entryTimeCashFlow, string openingDate)
        {
            return payment.HistoryPayment(entryTimeCashFlow, openingDate);
        }

        public DataTable GetSumValueTotalAndDiscount(string entryTimeCashFlow, string openingDate)
        {
            return payment.GetSumValueTotalAndDiscount(entryTimeCashFlow, openingDate);
        }

        public DataTable GetDataPaymentDueDateLate()
        {
            return payment.GetDataPaymentDueDateLate();
        }

        public DataTable SearchPaymentDateNow()
        {
            return payment.SearchPaymentDateNow();
        }

        public DataTable GetDataPayments(int idPayment)
        {
            return payment.GetDataPayments(idPayment);
        }

        public int GetMaxIdPayment()
        {
            return payment.GetMaxIdPayment();
        }

        public void UpdatePaymentOnAccount(int idPayment, IcomingCashFlow icomingCashFlow)
        {
            Database.IcomingCashFlow icomingCash = new Database.IcomingCashFlow()
            {
                _descriptionIcoming = icomingCashFlow._descriptionIcoming,
                _cashFlowID = icomingCashFlow._cashFlowID,
                _entryDate = icomingCashFlow._entryDate,
                _entryTime = icomingCashFlow._entryTime,
                _valueCard = icomingCashFlow._valueCard,
                _valueMoney = icomingCashFlow._valueMoney
            };

            payment.UpdatePaymentOnAccount(idPayment, icomingCash);
        }
    }
}
