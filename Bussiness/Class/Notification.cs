namespace Bussiness
{
    public class Notification
    {
        private int id;
        private string situation;
        private string message;
        private string dateNotification;

        Database.Notification notification = new Database.Notification();

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
        public string _message
        {
            get { return message; }
            set { message = value; }
        }
        public string _dateNotification
        {
            get { return dateNotification; }
            set { dateNotification = value; }
        }

        public void GerateMessage()
        {
            notification._message = this._message;
            notification._situation = this._situation;
            notification._dateNotification = this._dateNotification;
            notification.GerateMessage();
        }

        public void MarctMessage(int id)
        {
            notification.MarctMessage(id);
        }
    }
}
