using Common.Entities;
using Microsoft.AspNetCore.Mvc;
using Tai.Authentications.Entities;

namespace Tai
{
    public static partial class Program
    {
        public static WebApplication? AddUserMaps(this WebApplication? web)
        {
            //добавить userDTO дабы пароль на светился на верх.
            web?.MapPost("api/users/create", async ([FromBody] User user, Repository<User> repo)
                => await repo.CreateAsync(user) is User createdUser
                    ? Results.Ok(createdUser.Id)
                    : Results.BadRequest("Пользователь не создан."));

            web?.MapGet("api/users/{id:Guid}", async (Guid id, Repository<User> repo)
                => await repo.GetAsync(id) is User user
                    ? Results.Ok(user)
                    : Results.NotFound("Не существует."));

            return web;
        }
    }
}
