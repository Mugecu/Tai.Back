using Common.Entities;
using Tai.Authentications.Entities.ValueObjects;
using Tai.Authentications.Guards;

namespace Tai.Authentications.Entities
{
    public class User : AggregateRoot
    {
        public UserNameSurname UserNameSurname { get; private set; }
        public UserLogin UserLogin { get; private set; }
        public UserEmail UserEmail { get; private set; }
        public UserPassword UserPassword { get; private set; }
        public TimeStamp? TimeStamp { get; private set; }

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
    }
}
