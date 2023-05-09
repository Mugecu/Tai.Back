using Tai.Authentications.DTO.UsersVO;
using Tai.Authentications.Entities;

namespace Tai.Authentications.DTO
{
    public class UserDTO
    {
        public UserNameSurnameDTO UserNameSurname { get; set; }
        public UserLoginDTO UserLogin { get; set; }
        public UserEmailDTO UserEmail { get; set; }
        public UserPasswordDTO UserPassword { get; set; }
        public TimeStampDTO TimeStamp { get; set; }

        public UserDTO ToDto(User model) 
        {
            UserNameSurname = new UserNameSurnameDTO().ToDto(model.UserNameSurname);
            UserLogin = new UserLoginDTO().ToDto(model.UserLogin);
            UserEmail = new UserEmailDTO().ToDto(model.UserEmail);
            UserPassword = new UserPasswordDTO().ToDto(model.UserPassword);
            TimeStamp = new TimeStampDTO().ToDto(model.TimeStamp);

            return this;
        }

        public User ToModel()
            => new User(
                UserNameSurname.ToModel(),
                UserLogin.ToModel(),
                UserEmail.ToModel(),
                UserPassword.ToModel());
    }
}
