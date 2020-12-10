using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class Modality
    {
        private int id;
        private string description;
        private int planID;

        Database.Modality modality = new Database.Modality();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _description
        {
            get { return description; }
            set { description = value; }
        }
        public int _planID
        {
            get { return planID; }
            set { planID = value; }
        }

        public void Save()
        {
            modality._id = this._id;
            modality._description = this._description;
            modality._planID = this._planID;
            modality.Save();
        }

        public DataTable SearchPlanID(int planID)
        {
            return modality.SearchPlanID(planID);
        }
    }
}
