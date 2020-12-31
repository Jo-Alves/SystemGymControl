using System.Data;

namespace Bussiness
{
    public class IcomingCashFlow
    {
        private int id;
        private string entryDate;
        private string entryTime;
        private decimal valueMoney;
        private decimal valueCard;
        private int cashFlowID;

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
            return new Database.IcomingCashFlow().SearchID(idIcoming);
        }

        public DataTable SearchAll()
        {
            return new Database.IcomingCashFlow().SearchAll();
        }
    }
}
