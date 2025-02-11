﻿using System.Data;

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

        Database.OutgoingCashFlow outgoingCashFlow = new Database.OutgoingCashFlow();

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

        public DataTable SearchID(int idOutgoing)
        {
            return outgoingCashFlow.SearchID(idOutgoing);
        }

        public DataTable SearchAll()
        {
            return outgoingCashFlow.SearchAll();
        }

        public void ExitMoney()
        {
            new Database.OutgoingCashFlow()
            {
                _cashFlowID = this._cashFlowID,
                _descriptionExit = this._descriptionExit,
                _exitDate = this._exitDate,
                _exitTime = this._exitTime,
                _valueOutput = this._valueOutput
            }.ExitMoney();
        }

        public DataTable GetDataOutgoingIdCash(int idCash)
        {
            return outgoingCashFlow.GetDataOutgoingIdCash(idCash);
        }
    }
}
