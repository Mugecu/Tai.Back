using Common.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tai.Authentications.DTO;
using Tai.Authentications.Entities;

namespace Tai.Apis
{
    public class UserApi
    {
        public void Register(WebApplication app)
        {

            app?.MapPost("api/users/create", Create)
                .Produces<Guid>(StatusCodes.Status200OK)
                .WithName("CreateUser")
                .WithTags("Users");

            app?.MapGet("api/users/{id:Guid}", GetById)
                .Produces<UserDTO>(StatusCodes.Status200OK)
                .WithName("GetUser")
                .WithTags("Users");
        }

        private async Task<IResult> Create([FromBody] UserDTO userDto, Repository<User> userRepository)
        {
            var user = await userRepository.CreateAsync(userDto.ToModel());
            await userRepository.SaveAsync();

            return user is User 
                ? Results.Ok(user)
                : Results.BadRequest();
        }

        private async Task<IResult> GetById(Guid id, Repository<User> userRepository)
            => await userRepository.GetAsync(id) is User user
                    ? Results.Ok(user)
                    : Results.NotFound("Не существует.");

        [Authorize]
        private async Task<IResult> Update([FromBody] UserDTO userDto, Repository<User> userRepository)
        {
            var updatedUser = userDto?.ToModel();

            if (updatedUser is null) { return Results.BadRequest("Отсутствуют данные для обновления."); }

            var user = await userRepository.GetAsync(updatedUser.Id);

            if (user is null) { return Results.NotFound($@"Пользователь с идентификатором {updatedUser.Id} отсутствует."); }

            user

            user.Rename()

            await userRepository.SaveAsync();

            return user is User
                ? Results.Ok(user)
                : Results.BadRequest();
        }
    }
}
