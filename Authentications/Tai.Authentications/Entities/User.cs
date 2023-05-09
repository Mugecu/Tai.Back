using Common.Entities;
using Tai.Authentications.Entities.ValueObjects;
using Tai.Authentications.Guards;

namespace Tai.Authentications.Entities
{
    public class User : AggregateRoot
    {
        public UserNameSurname UserNameSurname { get;  set; }
        public UserLogin UserLogin { get;  set; }
        public UserEmail UserEmail { get;  set; }
        public UserPassword UserPassword { get;  set; }
        public TimeStamp? TimeStamp { get;  set; }

        private User() { }

        public User(
            UserNameSurname userNameSurname,
            UserLogin userLogin,
            UserEmail userEmail,
            UserPassword userPassword,
            TimeStamp timeStamp)
        {
            UserNameSurname = userNameSurname;
            UserLogin = userLogin;
            UserEmail = userEmail;
            UserPassword = userPassword;
            TimeStamp = timeStamp;
        }

        public User(
            UserNameSurname userNameSurname,
            UserLogin userLogin,
            UserEmail userEmail,
            UserPassword userPassword)
        {
            UserNameSurname = userNameSurname;
            UserLogin = userLogin;
            UserEmail = userEmail;
            UserPassword = userPassword;
        }

        public User SetTimeStamp(TimeStamp? timeStamp) 
        {
            if(timeStamp != null)
                TimeStamp = timeStamp;

            return this;
        }

        public void RenameUser(string name, string surname)
            => UserNameSurname = new UserNameSurname(name, surname);

        public void ChangeUserEmail(string emailName, string domainName)
            => UserEmail = new UserEmail(emailName, domainName);

        public void ChangeUserPassword(string password)
            => UserPassword.ChangePassword(password);

        public void ChangeUserLogin(string login)
            => UserLogin.ChangeLogin(login);
    }
}
