using Database;
using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class User
    {
        private int id;
        private string user;
        private string password;
        private string question;
        private string answer;
        private string avatar;
        private string dateRegistion;


        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _user
        {
            get { return user; }
            set { user = value; }
        }
        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        public string _question
        {
            get { return question; }
            set { question = value; }
        }
        public string _answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public string _avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public string _dateRegistion
        {
            get { return dateRegistion; }
            set { dateRegistion = value; }
        }


        public void Save()
        {
            Database.User user = new Database.User();
            user._id = this._id;
            user._user = this._user;
            user._password = this._password;
            user._question = this._question;
            user._answer = this._answer;
            user._avatar = this._avatar;
            user._dateRegistion = this._dateRegistion;
            user.Save();
        }

        public void Delete(int idUser)
        {
            new Database.User().Delete(idUser);
        }

        public DataTable SearchAll()
        {
            return new Database.User().SearchAll();
        }

        public DataTable SearchUser(string user)
        {
            return new Database.User().SearchUser(user);
        }
    }
}
