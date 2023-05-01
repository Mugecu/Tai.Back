using Common.Entities;
using Tai.Authentications.Entities.ValueObjects;

namespace Tai.Authentications.Entities
{
    public class User : Entity
    {
        public UserNameSurname UserNameSurname { get; private set; }
        public UserLogin UserLogin { get; private set; }
        public UserEmail UserEmail { get; private set; }
        public UserPassword UserPassword { get; private set; }
        public TimeStamp TimeStamp { get; private set; }

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
    }
}
