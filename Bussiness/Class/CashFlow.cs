using System.Data;

namespace Bussiness
{
    public class CashFlow
    {
        private int id;
        private string openingTime;
        private decimal cashValueTotal;
        private decimal outputValueTotal;
        private string closingDate;
        private string closingTime;


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

        public void Save()
        {

            new Database.CashFlow()
            {
                _id = this._id,
                _openingTime = this._openingTime,
                _outputValueTotal = this._outputValueTotal,
                _cashValueTotal = this._cashValueTotal,
                _closingDate = this._closingDate,
                _closingTime = this._closingTime,
            }.Save();
        }

        public DataTable SearchID(int cashFlow)
        {
            return new Database.CashFlow().SearchID(cashFlow);
        }

        public DataTable SearchAll()
        {
            return new Database.CashFlow().SearchAll();
        }

        public int GetMaxCashFlowID()
        {
            return new Database.CashFlow().GetMaxCashFlowID();
        }
    }
}
