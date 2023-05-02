using Common.Entities;
using Microsoft.EntityFrameworkCore;
using Tai.Authentications.Entities;
using Tai.Authentications.Infrastructure.Repositories;
using Tai.Authentications.Interfaces;
using Tai.Authentications.Services;

namespace Tai
{
    public static partial class Program
    {
        private static WebApplicationBuilder? AddAuthenticationServices(this WebApplicationBuilder? builder)
        {
            builder?.Services?.AddScoped<IDateTime, DateTimeService>();
            builder?.Services?.AddScoped<ITokenService, TokenService>();

            return builder;
        }

        private static WebApplicationBuilder? AddAutenticationRepository(this WebApplicationBuilder? builder)
        {
            // добавсть DbContext.
            builder?.Services?.AddScoped<Repository<User>, UserRepository>();

            return builder;
        }
    }
}
