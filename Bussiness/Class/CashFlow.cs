using System.Data;

namespace Bussiness
{
    public class CashFlow
    {
        private int id;
        private string openingDate;
        private string openingTime;
        private decimal cashValueTotal;
        private decimal outputValueTotal;
        private string closingDate;
        private string closingTime;

        Database.CashFlow cash = new Database.CashFlow();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _openingTime
        {
            get { return openingTime; }
            set { openingTime = value; }
        }
        public string _openingDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }
        public decimal _cashValueTotal
        {
            get { return cashValueTotal; }
            set { cashValueTotal = value; }
        }
        public decimal _outputValueTotal
        {
            get { return outputValueTotal; }
            set { outputValueTotal = value; }
        }
        public string _closingDate
        {
            get { return closingDate; }
            set { closingDate = value; }
        }
        public string _closingTime
        {
            get { return closingTime; }
            set { closingTime = value; }
        }

        public void Save(IcomingCashFlow icomingCashFlow)
        {
            Database.IcomingCashFlow icomingCash = new Database.IcomingCashFlow()
            {
                _descriptionIcoming = icomingCashFlow._descriptionIcoming,
                _entryDate = icomingCashFlow._entryDate,
                _entryTime = icomingCashFlow._entryTime,
                _valueCard = icomingCashFlow._valueCard,
                _valueMoney = icomingCashFlow._valueMoney
            };

            var cashFlow = new Database.CashFlow()
            {
                _cashValueTotal = this._cashValueTotal,
                _closingDate = this._closingDate,
                _closingTime = this._closingTime,
                _openingDate = this._openingDate,
                _openingTime = this._openingTime,
                _outputValueTotal = this._outputValueTotal
            };

            cashFlow.Save(icomingCash);

            this.id = icomingCash._cashFlowID;
        }

        public DataTable SearchID(int cashFlow)
        {
            return cash.SearchID(cashFlow);
        }

        public DataTable SearchAll()
        {
            return cash.SearchAll();
        }


        public int GetMaxCashFlowID()
        {
            return cash.GetMaxCashFlowID();
        }

        public bool HaveCashFlowOpen()
        {
            return cash.HaveCashFlowOpen();
        }

        public void ClosingBox(decimal balance, int idCash)
        {
            cash.ClosingBox(balance, idCash);
        }
    }
}
