﻿using System.Data;

namespace Bussiness
{
    public class SituationsPlan
    {
        Database.SituationsPlan situationsPlan = new Database.SituationsPlan();
        private int id;
        private string situation;
        private string observation;
        private string deactivationDate;
        private int timeInactivated;
        private int planID;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _situation
        {
            get { return situation; }
            set { situation = value; }
        }
        public string _observation
        {
            get { return observation; }
            set { observation = value; }
        }
        public string _deactivationDate
        {
            get { return deactivationDate; }
            set { deactivationDate = value; }
        }
        public int _timeInactivated
        {
            get { return timeInactivated; }
            set { timeInactivated = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            situationsPlan._id = this._id;
            situationsPlan._situation = this._situation;
            situationsPlan._observation = this._observation;
            situationsPlan._planID = this._planID;
            situationsPlan._deactivationDate = this._deactivationDate;
            situationsPlan.Save();
        }

        public void updateTimeInactivated(int id)
        {
            situationsPlan._timeInactivated = this._timeInactivated;
            situationsPlan.updateTimeInactive(id);
        }

        public DataTable SearchID(int id)
        {
            return situationsPlan.SearchID(id);
        }
    }
}
