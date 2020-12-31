using System.Data;

namespace Bussiness
{
    public class OutgoingCashFlow
    {
        private int id;
        private string exitDate;
        private string exitTime;
        private string descriptionExit;
        private decimal valueOutput;
        private int cashFlowID;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _exitDate
        {
            get { return exitDate; }
            set { exitDate = value; }
        }
        public string _exitTime
        {
            get { return exitTime; }
            set { exitTime = value; }
        }
        public string _descriptionExit
        {
            get { return descriptionExit; }
            set { descriptionExit = value; }
        }
        public decimal _valueOutput
        {
            get { return valueOutput; }
            set { valueOutput = value; }
        }
        public int _cashFlowID
        {
            get { return cashFlowID; }
            set { cashFlowID = value; }
        }

        public void Save()
        {
            new Database.OutgoingCashFlow() { _id = this._id, _cashFlowID = this._cashFlowID, _descriptionExit = _descriptionExit, _exitDate = this._exitDate, _exitTime = this._exitTime, _valueOutput = this._valueOutput }.Save();
        }

        public DataTable SearchID(int idOutgoing)
        {
            return new Database.OutgoingCashFlow().SearchID(idOutgoing);
        }

        public DataTable SearchAll()
        {
            return new Database.OutgoingCashFlow().SearchAll();
        }
    }
}
