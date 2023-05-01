using Tai.Authentications.Interfaces;
using Tai.Authentications.Services;

namespace Tai
{
    public static partial class Program
    {
        private static WebApplicationBuilder? AddAuthenticateServices(this WebApplicationBuilder? builder)
        {
            builder?.Services?.AddScoped<IDateTime, DateTimeService>();
            builder?.Services?.AddScoped<ITokenService, TokenService>();

            return builder;
        }
    }
}
