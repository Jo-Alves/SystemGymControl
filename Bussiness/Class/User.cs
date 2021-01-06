using System.Data;

namespace Bussiness
{
    public class User
    {
        private int id;
        private string name;
        private string user;
        private string email;
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
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public string _email
        {
            get { return email; }
            set { email = value; }
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

        public string ValidateFieldsAndGetMessage()
        {
            string message = "";

            if (string.IsNullOrEmpty(this._name))
                message = "Campo 'Nome' obrigatório!";
            else if (string.IsNullOrEmpty(this._user))
                message = "Campo 'Usuário' obrigatório!";
            else if (new Database.User().CheckedNameUserExist(this._user) && this.id == 0)
                message = "O nome de usuário já existe!";
            else if (new Database.User().CheckedEmailUserExist(this._email) && this.id == 0)
                message = "Este email já existe!";
            else if (!ValidateEmail.Validate(this._email))
                message = "Email inválido!";
            else if (string.IsNullOrEmpty(this._password))
                message = "Campo 'Senha' obrigatório!";
            else if (this._password.Length < 5)
                message = "A senha deve ter no mínimo 5 cararacteres!";
            else if (string.IsNullOrEmpty(this._question))
                message = "Campo 'Pergunta de Segurança' obrigatório!";
            else if (string.IsNullOrEmpty(this._answer))
                message = "Campo 'Resposta de Segurança' obrigatório!";

            return message;
        }

        public void Save()
        {
            Database.User user = new Database.User();
            user._id = this._id;
            user._name = this._name;
            user._email = this._email;
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

        public DataTable SearchID(int idUser)
        {
            return new Database.User().SearchID(idUser);
        } 
        
        public DataTable GetUserOrName(string user)
        {
            return new Database.User().GetUserOrName(user);
        }

        public bool Logout(string user, string password)
        {
            return new Database.User().Logout(user, password);
        } 

        public bool ExitNameOrUser(string user)
        {
            return new Database.User().ExitNameOrUser(user);
            
        }

        public bool CheckedAnswerSecurity(string name, string answer)
        {
            return new Database.User().CheckedAnswerSecurity(name, answer);
        }

        public void ResetSecurity()
        {
            new Database.User()
            {
                _user = this.user,
                _email = this.user,
                _password = this._password
            }
            .ResetSecurity();
        }
    }
}
