using System.Data;

namespace Bussiness
{
    public class IcomingCashFlow
    {
        private int id;
        private string entryDate;
        private string entryTime;
        private string descriptionIcoming;
        private decimal valueMoney;
        private decimal valueCard;
        private int cashFlowID;

        Database.IcomingCashFlow icomingCashFlow = new Database.IcomingCashFlow();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _entryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
        public string _descriptionIcoming
        {
            get { return descriptionIcoming; }
            set { descriptionIcoming = value; }
        }
        public string _entryTime
        {
            get { return entryTime; }
            set { entryTime = value; }
        }
        public decimal _valueMoney
        {
            get { return valueMoney; }
            set { valueMoney = value; }
        }
        public decimal _valueCard
        {
            get { return valueCard; }
            set { valueCard = value; }
        }
        public int _cashFlowID
        {
            get { return cashFlowID; }
            set { cashFlowID = value; }
        }

        public DataTable SearchID(int idIcoming)
        {
            return icomingCashFlow.SearchID(idIcoming);
        }

        public DataTable SearchAll()
        {
            return icomingCashFlow.SearchAll();
        }

        public decimal GetValueEntryInitial(int idCash)
        {
            return icomingCashFlow.GetValueEntryInitial(idCash);
        }

        public DataTable GetDataIcoming(int idCash, string entryTimeCashFlow, string openingDate)
        {
            return icomingCashFlow.GetDataIcoming(idCash, entryTimeCashFlow, openingDate);
        }

        public decimal GetSumValueEntryMoney(int idCash)
        {
            return icomingCashFlow.GetSumValueEntryMoney(idCash);
        }

        public decimal GetSumValueEntryCard(int idCash)
        {
            return icomingCashFlow.GetSumValueEntryCard(idCash);
        }

        public DataTable GetDataIcomingIdCash(int idCash)
        {
            return icomingCashFlow.GetDataIcomingIdCash(idCash);
        }

    }
}
