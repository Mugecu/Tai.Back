using Tai.Authentications.Guards;

namespace Tai.Authentications.Entities.ValueObjects
{
    public class UserLogin
    {
        public string Login { get; }

        public UserLogin(string login)
        {
            Login = Guard.CheckStringValueOnNullEmptyAndWhiteSpace(login, "Пустое имя логина.");
        }

        public UserLogin ChangeLogin(string login)
            => new UserLogin(login);
    }
}
