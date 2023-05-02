using Common.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tai.Authentications.Entities;

namespace Tai
{
    public static partial class Program
    {
        public static WebApplication? AddLoginMaps(this WebApplication? web)
        {
            //добавить userDTO дабы пароль на светился на верх.
            web?.MapGet("api/authentication/login",  async ([FromBody] User user, Repository<User> repo)
                => await repo.GetAsync(user.Id)  is User findedUser
                    ? Results.Ok("Autorize")
                    : Results.Unauthorized());

            return web;
        }
    }
}
